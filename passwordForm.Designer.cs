namespace contractorCalculator
{
    partial class passwordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwordForm));
            this.textBoxPasswordInput = new System.Windows.Forms.TextBox();
            this.buttonSubmitPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPasswordInput
            // 
            this.textBoxPasswordInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPasswordInput.Location = new System.Drawing.Point(270, 152);
            this.textBoxPasswordInput.Name = "textBoxPasswordInput";
            this.textBoxPasswordInput.Size = new System.Drawing.Size(261, 26);
            this.textBoxPasswordInput.TabIndex = 0;
            this.textBoxPasswordInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSubmitPassword
            // 
            this.buttonSubmitPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSubmitPassword.Location = new System.Drawing.Point(339, 237);
            this.buttonSubmitPassword.Name = "buttonSubmitPassword";
            this.buttonSubmitPassword.Size = new System.Drawing.Size(123, 62);
            this.buttonSubmitPassword.TabIndex = 1;
            this.buttonSubmitPassword.Text = "Login";
            this.buttonSubmitPassword.UseVisualStyleBackColor = true;
            this.buttonSubmitPassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmitPassword);
            this.Controls.Add(this.textBoxPasswordInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "passwordForm";
            this.Text = "Enter Password";
            this.Load += new System.EventHandler(this.passwordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPasswordInput;
        private System.Windows.Forms.Button buttonSubmitPassword;
    }
}