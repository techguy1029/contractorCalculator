namespace contractorCalculator
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.buttonSetPs = new System.Windows.Forms.Button();
            this.textBoxPsInput = new System.Windows.Forms.TextBox();
            this.listBoxLanguage = new System.Windows.Forms.ListBox();
            this.labelSelectLanguage = new System.Windows.Forms.Label();
            this.textBoxConfirmPs = new System.Windows.Forms.TextBox();
            this.labelEnterPass = new System.Windows.Forms.Label();
            this.labelConfirmPass = new System.Windows.Forms.Label();
            this.radioButtonPsEnabled = new System.Windows.Forms.RadioButton();
            this.radioButtonPsDisabled = new System.Windows.Forms.RadioButton();
            this.labelPasswordSettings = new System.Windows.Forms.Label();
            this.buttonResetPs = new System.Windows.Forms.Button();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSetPs
            // 
            this.buttonSetPs.Location = new System.Drawing.Point(431, 158);
            this.buttonSetPs.Name = "buttonSetPs";
            this.buttonSetPs.Size = new System.Drawing.Size(145, 39);
            this.buttonSetPs.TabIndex = 1;
            this.buttonSetPs.Text = "Set Password";
            this.buttonSetPs.UseVisualStyleBackColor = true;
            this.buttonSetPs.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPsInput
            // 
            this.textBoxPsInput.Location = new System.Drawing.Point(228, 171);
            this.textBoxPsInput.Name = "textBoxPsInput";
            this.textBoxPsInput.Size = new System.Drawing.Size(197, 26);
            this.textBoxPsInput.TabIndex = 2;
            this.textBoxPsInput.TextChanged += new System.EventHandler(this.textBoxPsInput_TextChanged);
            // 
            // listBoxLanguage
            // 
            this.listBoxLanguage.ItemHeight = 20;
            this.listBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Spanish/Espanol"});
            this.listBoxLanguage.Location = new System.Drawing.Point(275, 302);
            this.listBoxLanguage.Name = "listBoxLanguage";
            this.listBoxLanguage.Size = new System.Drawing.Size(250, 84);
            this.listBoxLanguage.TabIndex = 3;
            this.listBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.listBoxLanguage_SelectedIndexChanged);
            // 
            // labelSelectLanguage
            // 
            this.labelSelectLanguage.AutoSize = true;
            this.labelSelectLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectLanguage.Location = new System.Drawing.Point(322, 268);
            this.labelSelectLanguage.Name = "labelSelectLanguage";
            this.labelSelectLanguage.Size = new System.Drawing.Size(145, 20);
            this.labelSelectLanguage.TabIndex = 4;
            this.labelSelectLanguage.Text = "Select Language";
            // 
            // textBoxConfirmPs
            // 
            this.textBoxConfirmPs.Location = new System.Drawing.Point(226, 227);
            this.textBoxConfirmPs.Name = "textBoxConfirmPs";
            this.textBoxConfirmPs.Size = new System.Drawing.Size(200, 26);
            this.textBoxConfirmPs.TabIndex = 5;
            // 
            // labelEnterPass
            // 
            this.labelEnterPass.AutoSize = true;
            this.labelEnterPass.Location = new System.Drawing.Point(225, 148);
            this.labelEnterPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEnterPass.Name = "labelEnterPass";
            this.labelEnterPass.Size = new System.Drawing.Size(121, 20);
            this.labelEnterPass.TabIndex = 6;
            this.labelEnterPass.Text = "Enter Password";
            this.labelEnterPass.Click += new System.EventHandler(this.labelEnterPass_Click);
            // 
            // labelConfirmPass
            // 
            this.labelConfirmPass.AutoSize = true;
            this.labelConfirmPass.Location = new System.Drawing.Point(225, 204);
            this.labelConfirmPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelConfirmPass.Name = "labelConfirmPass";
            this.labelConfirmPass.Size = new System.Drawing.Size(137, 20);
            this.labelConfirmPass.TabIndex = 7;
            this.labelConfirmPass.Text = "Confirm Password";
            // 
            // radioButtonPsEnabled
            // 
            this.radioButtonPsEnabled.AutoSize = true;
            this.radioButtonPsEnabled.Location = new System.Drawing.Point(226, 97);
            this.radioButtonPsEnabled.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPsEnabled.Name = "radioButtonPsEnabled";
            this.radioButtonPsEnabled.Size = new System.Drawing.Size(166, 24);
            this.radioButtonPsEnabled.TabIndex = 9;
            this.radioButtonPsEnabled.Text = "Password Enabled";
            this.radioButtonPsEnabled.UseVisualStyleBackColor = true;
            this.radioButtonPsEnabled.CheckedChanged += new System.EventHandler(this.radioButtonPsEnabled_CheckedChanged);
            // 
            // radioButtonPsDisabled
            // 
            this.radioButtonPsDisabled.AutoSize = true;
            this.radioButtonPsDisabled.Location = new System.Drawing.Point(407, 97);
            this.radioButtonPsDisabled.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPsDisabled.Name = "radioButtonPsDisabled";
            this.radioButtonPsDisabled.Size = new System.Drawing.Size(169, 24);
            this.radioButtonPsDisabled.TabIndex = 10;
            this.radioButtonPsDisabled.Text = "Password Disabled";
            this.radioButtonPsDisabled.UseVisualStyleBackColor = true;
            this.radioButtonPsDisabled.CheckedChanged += new System.EventHandler(this.radioButtonPsDisabled_CheckedChanged);
            // 
            // labelPasswordSettings
            // 
            this.labelPasswordSettings.AutoSize = true;
            this.labelPasswordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordSettings.Location = new System.Drawing.Point(322, 56);
            this.labelPasswordSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPasswordSettings.Name = "labelPasswordSettings";
            this.labelPasswordSettings.Size = new System.Drawing.Size(158, 20);
            this.labelPasswordSettings.TabIndex = 11;
            this.labelPasswordSettings.Text = "Password Settings";
            // 
            // buttonResetPs
            // 
            this.buttonResetPs.Location = new System.Drawing.Point(431, 207);
            this.buttonResetPs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonResetPs.Name = "buttonResetPs";
            this.buttonResetPs.Size = new System.Drawing.Size(145, 46);
            this.buttonResetPs.TabIndex = 12;
            this.buttonResetPs.Text = "Reset Password";
            this.buttonResetPs.UseVisualStyleBackColor = true;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(658, 399);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(130, 39);
            this.buttonSaveSettings.TabIndex = 13;
            this.buttonSaveSettings.Text = "Save Settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.buttonResetPs);
            this.Controls.Add(this.labelPasswordSettings);
            this.Controls.Add(this.radioButtonPsDisabled);
            this.Controls.Add(this.radioButtonPsEnabled);
            this.Controls.Add(this.labelConfirmPass);
            this.Controls.Add(this.labelEnterPass);
            this.Controls.Add(this.textBoxConfirmPs);
            this.Controls.Add(this.labelSelectLanguage);
            this.Controls.Add(this.listBoxLanguage);
            this.Controls.Add(this.textBoxPsInput);
            this.Controls.Add(this.buttonSetPs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSetPs;
        private System.Windows.Forms.TextBox textBoxPsInput;
        private System.Windows.Forms.ListBox listBoxLanguage;
        private System.Windows.Forms.Label labelSelectLanguage;
        private System.Windows.Forms.TextBox textBoxConfirmPs;
        private System.Windows.Forms.Label labelEnterPass;
        private System.Windows.Forms.Label labelConfirmPass;
        private System.Windows.Forms.RadioButton radioButtonPsEnabled;
        private System.Windows.Forms.RadioButton radioButtonPsDisabled;
        private System.Windows.Forms.Label labelPasswordSettings;
        private System.Windows.Forms.Button buttonResetPs;
        private System.Windows.Forms.Button buttonSaveSettings;
    }
}