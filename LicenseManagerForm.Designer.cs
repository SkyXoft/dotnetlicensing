namespace DotNetLicensing
{
    partial class LicenseManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TrialDaysText = new System.Windows.Forms.TextBox();
            this.CreateLicenseButton = new System.Windows.Forms.Button();
            this.CompanyText = new System.Windows.Forms.TextBox();
            this.CustomerNameText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OpenPublicKeyButton = new System.Windows.Forms.Button();
            this.PublicKeyText = new System.Windows.Forms.TextBox();
            this.OpenKeyPairButton = new System.Windows.Forms.Button();
            this.CreateKeyPairButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ValidateLicenseButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trial Days";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 266);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ValidateLicenseButton);
            this.tabPage1.Controls.Add(this.TrialDaysText);
            this.tabPage1.Controls.Add(this.CreateLicenseButton);
            this.tabPage1.Controls.Add(this.CompanyText);
            this.tabPage1.Controls.Add(this.CustomerNameText);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 240);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "License";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TrialDaysText
            // 
            this.TrialDaysText.Location = new System.Drawing.Point(112, 97);
            this.TrialDaysText.Name = "TrialDaysText";
            this.TrialDaysText.Size = new System.Drawing.Size(137, 20);
            this.TrialDaysText.TabIndex = 6;
            // 
            // CreateLicenseButton
            // 
            this.CreateLicenseButton.Location = new System.Drawing.Point(154, 179);
            this.CreateLicenseButton.Name = "CreateLicenseButton";
            this.CreateLicenseButton.Size = new System.Drawing.Size(95, 39);
            this.CreateLicenseButton.TabIndex = 5;
            this.CreateLicenseButton.Text = "Create License";
            this.CreateLicenseButton.UseVisualStyleBackColor = true;
            this.CreateLicenseButton.Click += new System.EventHandler(this.CreateLicenseButton_Click);
            // 
            // CompanyText
            // 
            this.CompanyText.Location = new System.Drawing.Point(112, 45);
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(137, 20);
            this.CompanyText.TabIndex = 4;
            // 
            // CustomerNameText
            // 
            this.CustomerNameText.Location = new System.Drawing.Point(112, 19);
            this.CustomerNameText.Name = "CustomerNameText";
            this.CustomerNameText.Size = new System.Drawing.Size(137, 20);
            this.CustomerNameText.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.OpenPublicKeyButton);
            this.tabPage2.Controls.Add(this.PublicKeyText);
            this.tabPage2.Controls.Add(this.OpenKeyPairButton);
            this.tabPage2.Controls.Add(this.CreateKeyPairButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 240);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Key Pairs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // OpenPublicKeyButton
            // 
            this.OpenPublicKeyButton.Location = new System.Drawing.Point(260, 160);
            this.OpenPublicKeyButton.Name = "OpenPublicKeyButton";
            this.OpenPublicKeyButton.Size = new System.Drawing.Size(84, 49);
            this.OpenPublicKeyButton.TabIndex = 3;
            this.OpenPublicKeyButton.Text = "Open PUBLIC Key Pair File";
            this.OpenPublicKeyButton.UseVisualStyleBackColor = true;
            this.OpenPublicKeyButton.Click += new System.EventHandler(this.OpenPublicKeyButton_Click);
            // 
            // PublicKeyText
            // 
            this.PublicKeyText.Location = new System.Drawing.Point(0, 0);
            this.PublicKeyText.Multiline = true;
            this.PublicKeyText.Name = "PublicKeyText";
            this.PublicKeyText.Size = new System.Drawing.Size(459, 154);
            this.PublicKeyText.TabIndex = 2;
            // 
            // OpenKeyPairButton
            // 
            this.OpenKeyPairButton.Location = new System.Drawing.Point(157, 160);
            this.OpenKeyPairButton.Name = "OpenKeyPairButton";
            this.OpenKeyPairButton.Size = new System.Drawing.Size(84, 49);
            this.OpenKeyPairButton.TabIndex = 1;
            this.OpenKeyPairButton.Text = "Open PRIVATE Key Pair File";
            this.OpenKeyPairButton.UseVisualStyleBackColor = true;
            this.OpenKeyPairButton.Click += new System.EventHandler(this.OpenKeyPairButton_Click);
            // 
            // CreateKeyPairButton
            // 
            this.CreateKeyPairButton.Location = new System.Drawing.Point(47, 160);
            this.CreateKeyPairButton.Name = "CreateKeyPairButton";
            this.CreateKeyPairButton.Size = new System.Drawing.Size(83, 49);
            this.CreateKeyPairButton.TabIndex = 0;
            this.CreateKeyPairButton.Text = "Create Key Pair";
            this.CreateKeyPairButton.UseVisualStyleBackColor = true;
            this.CreateKeyPairButton.Click += new System.EventHandler(this.CreateKeyPairButton_Click);
            // 
            // ValidateLicenseButton
            // 
            this.ValidateLicenseButton.Location = new System.Drawing.Point(271, 179);
            this.ValidateLicenseButton.Name = "ValidateLicenseButton";
            this.ValidateLicenseButton.Size = new System.Drawing.Size(95, 39);
            this.ValidateLicenseButton.TabIndex = 7;
            this.ValidateLicenseButton.Text = "Validate License";
            this.ValidateLicenseButton.UseVisualStyleBackColor = true;
            this.ValidateLicenseButton.Click += new System.EventHandler(this.ValidateLicenseButton_Click);
            // 
            // LicenseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 266);
            this.Controls.Add(this.tabControl1);
            this.Name = "LicenseManagerForm";
            this.Text = "License Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button CreateLicenseButton;
        private System.Windows.Forms.TextBox CompanyText;
        private System.Windows.Forms.TextBox CustomerNameText;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button OpenKeyPairButton;
        private System.Windows.Forms.Button CreateKeyPairButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox PublicKeyText;
        private System.Windows.Forms.Button OpenPublicKeyButton;
        private System.Windows.Forms.TextBox TrialDaysText;
        private System.Windows.Forms.Button ValidateLicenseButton;
    }
}

