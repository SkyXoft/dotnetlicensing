using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLicensing
{
    public class LicenseAdmin
    {
        public string LoadKeyPairs(string file)
        {
            StreamReader stream = System.IO.File.OpenText(file);
            return stream.ReadToEnd();
        }
        public void CreateKeyPairs(string directory)
        {
            RSACryptoServiceProvider key = new RSACryptoServiceProvider(2048);


            string publicPrivateKeyXML = key.ToXmlString(true);
            string publicOnlyKeyXML = key.ToXmlString(false);

            StringToFile(directory + "_public.xml", publicOnlyKeyXML);
            StringToFile(directory + "_private.xml", publicPrivateKeyXML);
        }
        private void StringToFile(string outfile, string data)
        {
            StreamWriter outStream = System.IO.File.CreateText(outfile);
            outStream.Write(data);
            outStream.Close();
        }
         
        

    }
}
