namespace contractorCalculator
{
    partial class retainingWallForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;


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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.includeCapsCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonSaveOptions = new System.Windows.Forms.Button();
            this.displayBlocksLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.blockDimensionsLabel = new System.Windows.Forms.Label();
            this.wallDimensionsLabel = new System.Windows.Forms.Label();
            this.blockHeightTextBox = new System.Windows.Forms.TextBox();
            this.blockLengthTextBox = new System.Windows.Forms.TextBox();
            this.wallLengthTextBox = new System.Windows.Forms.TextBox();
            this.wallHeightTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.saveToDbButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.includeCapsCheckBox);
            this.tabPage1.Controls.Add(this.buttonSaveOptions);
            this.tabPage1.Controls.Add(this.displayBlocksLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.calculateButton);
            this.tabPage1.Controls.Add(this.lengthLabel);
            this.tabPage1.Controls.Add(this.heightLabel);
            this.tabPage1.Controls.Add(this.blockDimensionsLabel);
            this.tabPage1.Controls.Add(this.wallDimensionsLabel);
            this.tabPage1.Controls.Add(this.blockHeightTextBox);
            this.tabPage1.Controls.Add(this.blockLengthTextBox);
            this.tabPage1.Controls.Add(this.wallLengthTextBox);
            this.tabPage1.Controls.Add(this.wallHeightTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enter Dimensions";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // includeCapsCheckBox
            // 
            this.includeCapsCheckBox.AutoSize = true;
            this.includeCapsCheckBox.Location = new System.Drawing.Point(85, 238);
            this.includeCapsCheckBox.Name = "includeCapsCheckBox";
            this.includeCapsCheckBox.Size = new System.Drawing.Size(128, 24);
            this.includeCapsCheckBox.TabIndex = 10;
            this.includeCapsCheckBox.Text = "Include Caps";
            this.includeCapsCheckBox.UseVisualStyleBackColor = true;
            this.includeCapsCheckBox.CheckedChanged += new System.EventHandler(this.includeCapsCheckBox_CheckedChanged);
            // 
            // buttonSaveOptions
            // 
            this.buttonSaveOptions.Location = new System.Drawing.Point(506, 359);
            this.buttonSaveOptions.Name = "buttonSaveOptions";
            this.buttonSaveOptions.Size = new System.Drawing.Size(278, 50);
            this.buttonSaveOptions.TabIndex = 9;
            this.buttonSaveOptions.Text = "Next (Save and Share Options)";
            this.buttonSaveOptions.UseVisualStyleBackColor = true;
            this.buttonSaveOptions.Click += new System.EventHandler(this.buttonSaveOptions_Click);
            // 
            // displayBlocksLabel
            // 
            this.displayBlocksLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.displayBlocksLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayBlocksLabel.Location = new System.Drawing.Point(157, 339);
            this.displayBlocksLabel.Name = "displayBlocksLabel";
            this.displayBlocksLabel.Size = new System.Drawing.Size(150, 23);
            this.displayBlocksLabel.TabIndex = 8;
            this.displayBlocksLabel.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(157, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Of Blocks Needed";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(276, 226);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(136, 47);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(3, 179);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(59, 20);
            this.lengthLabel.TabIndex = 7;
            this.lengthLabel.Text = "Length";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(3, 90);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(56, 20);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // blockDimensionsLabel
            // 
            this.blockDimensionsLabel.AutoSize = true;
            this.blockDimensionsLabel.Location = new System.Drawing.Point(262, 64);
            this.blockDimensionsLabel.Name = "blockDimensionsLabel";
            this.blockDimensionsLabel.Size = new System.Drawing.Size(161, 20);
            this.blockDimensionsLabel.TabIndex = 5;
            this.blockDimensionsLabel.Text = "Block Dimensions (in)";
            // 
            // wallDimensionsLabel
            // 
            this.wallDimensionsLabel.AutoSize = true;
            this.wallDimensionsLabel.Location = new System.Drawing.Point(73, 64);
            this.wallDimensionsLabel.Name = "wallDimensionsLabel";
            this.wallDimensionsLabel.Size = new System.Drawing.Size(150, 20);
            this.wallDimensionsLabel.TabIndex = 4;
            this.wallDimensionsLabel.Text = "Wall Dimensions (ft)";
            // 
            // blockHeightTextBox
            // 
            this.blockHeightTextBox.Location = new System.Drawing.Point(276, 87);
            this.blockHeightTextBox.Name = "blockHeightTextBox";
            this.blockHeightTextBox.Size = new System.Drawing.Size(136, 26);
            this.blockHeightTextBox.TabIndex = 2;
            this.blockHeightTextBox.Tag = "Block Height Box";
            // 
            // blockLengthTextBox
            // 
            this.blockLengthTextBox.Location = new System.Drawing.Point(276, 173);
            this.blockLengthTextBox.Name = "blockLengthTextBox";
            this.blockLengthTextBox.Size = new System.Drawing.Size(136, 26);
            this.blockLengthTextBox.TabIndex = 4;
            this.blockLengthTextBox.Tag = "Block Length Box";
            // 
            // wallLengthTextBox
            // 
            this.wallLengthTextBox.Location = new System.Drawing.Point(77, 173);
            this.wallLengthTextBox.Name = "wallLengthTextBox";
            this.wallLengthTextBox.Size = new System.Drawing.Size(136, 26);
            this.wallLengthTextBox.TabIndex = 3;
            this.wallLengthTextBox.Tag = "Wall Length Box";
            // 
            // wallHeightTextBox
            // 
            this.wallHeightTextBox.Location = new System.Drawing.Point(77, 87);
            this.wallHeightTextBox.Name = "wallHeightTextBox";
            this.wallHeightTextBox.Size = new System.Drawing.Size(136, 26);
            this.wallHeightTextBox.TabIndex = 1;
            this.wallHeightTextBox.Tag = "Wall Height Box";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.saveToDbButton);
            this.tabPage2.Controls.Add(this.projectNameLabel);
            this.tabPage2.Controls.Add(this.projectNameTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 423);
            this.tabPage2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 100);
            this.tabPage3.TabIndex = 0;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(37, 51);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.projectNameTextBox.TabIndex = 0;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(33, 28);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(104, 20);
            this.projectNameLabel.TabIndex = 1;
            this.projectNameLabel.Text = "Project Name";
            // 
            // saveToDbButton
            // 
            this.saveToDbButton.Location = new System.Drawing.Point(666, 377);
            this.saveToDbButton.Name = "saveToDbButton";
            this.saveToDbButton.Size = new System.Drawing.Size(118, 32);
            this.saveToDbButton.TabIndex = 2;
            this.saveToDbButton.Text = "Save";
            this.saveToDbButton.UseVisualStyleBackColor = true;
            this.saveToDbButton.Click += new System.EventHandler(this.saveToDbButton_Click);
            // 
            // retainingWallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "retainingWallForm";
            this.Text = "retainingWallForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox blockHeightTextBox;
        private System.Windows.Forms.TextBox blockLengthTextBox;
        private System.Windows.Forms.TextBox wallLengthTextBox;
        private System.Windows.Forms.TextBox wallHeightTextBox;
        private System.Windows.Forms.Label blockDimensionsLabel;
        private System.Windows.Forms.Label wallDimensionsLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayBlocksLabel;
        private System.Windows.Forms.Button buttonSaveOptions;
        private System.Windows.Forms.CheckBox includeCapsCheckBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Button saveToDbButton;
    }
}