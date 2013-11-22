using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DotNetLicensing
{
    public partial class LicenseManagerForm : Form
    {
        private string privateKey;
        private string publicKey;
        private string testFolder = @"c:\temp\";
        public LicenseManagerForm()
        {
            InitializeComponent();
        }

        private void CreateLicenseButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(privateKey))
            {
                MessageBox.Show("Create or open a private/public key pair file");
                return;
            }
            StringBuilder licenseContent = new StringBuilder();
            licenseContent.Append("<license>");
            licenseContent.AppendFormat("<customer>{0}</customer>", CustomerNameText.Text);
            licenseContent.AppendFormat("<company>{0}</company>", CompanyText.Text);
            licenseContent.AppendFormat("<trial>{0}</trial>", TrialDaysText.Text);
            licenseContent.Append("</license>");

            License license = new License();

            XmlDocument fileContent = license.SignXmlDocument(licenseContent.ToString(), privateKey);

            StringToFile(testFolder + @"\testlicense.lic", fileContent.OuterXml);

            MessageBox.Show("Done");

        }
        private void StringToFile(string outfile, string data)
        {
            StreamWriter outStream = System.IO.File.CreateText(outfile);
            outStream.Write(data);
            outStream.Close();
        }
        

        private void CreateKeyPairButton_Click(object sender, EventArgs e)
        {
            LicenseAdmin admin = new LicenseAdmin();
            admin.CreateKeyPairs(testFolder + @"\test");

        }

        private void OpenKeyPairButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LicenseAdmin admin = new LicenseAdmin();
                string pk = admin.LoadKeyPairs(openFileDialog1.FileName);

                this.privateKey = pk;
            }
        }

        private void OpenPublicKeyButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LicenseAdmin admin = new LicenseAdmin();
                string pk = admin.LoadKeyPairs(openFileDialog1.FileName);

                PublicKeyText.Text = pk;
                this.publicKey = pk;
            }
        }
        private string FileToString(string infile)
        {
            StreamReader stream = System.IO.File.OpenText(infile);
            string content = stream.ReadToEnd();
            stream.Close();
            return content;
        }
        private void ValidateLicenseButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PublicKeyText.Text))
            {
                MessageBox.Show("Create or open a public key pair file");
                return;
            }
            License license = new License();
            string licenseContent = FileToString(testFolder + @"\testlicense.lic");

            bool valid = license.VerifyXmlDocument(PublicKeyText.Text, licenseContent);

            if (valid)
            {
                MessageBox.Show("License is valid");
            }
            else
            {
                MessageBox.Show("License file was modified");
            }
        }
        
    }
}
