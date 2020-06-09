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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(retainingWallForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelDisplayNumberOfCaps = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.includeCapsCheckBox = new System.Windows.Forms.CheckBox();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelCostOfCaps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCostOfBlocks = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalculateCost = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCostOfCap = new System.Windows.Forms.TextBox();
            this.textBoxCostOfBlock = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSaveFileToDirectory = new System.Windows.Forms.Button();
            this.saveToDbButton = new System.Windows.Forms.Button();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.labelDisplayNumberOfCaps);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.includeCapsCheckBox);
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
            this.tabPage1.Text = "  Dimensions  ";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelDisplayNumberOfCaps
            // 
            this.labelDisplayNumberOfCaps.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelDisplayNumberOfCaps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDisplayNumberOfCaps.Location = new System.Drawing.Point(384, 318);
            this.labelDisplayNumberOfCaps.Name = "labelDisplayNumberOfCaps";
            this.labelDisplayNumberOfCaps.Size = new System.Drawing.Size(142, 23);
            this.labelDisplayNumberOfCaps.TabIndex = 21;
            this.labelDisplayNumberOfCaps.Text = "\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(384, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "# Of Caps Needed";
            // 
            // includeCapsCheckBox
            // 
            this.includeCapsCheckBox.AutoSize = true;
            this.includeCapsCheckBox.Location = new System.Drawing.Point(226, 178);
            this.includeCapsCheckBox.Name = "includeCapsCheckBox";
            this.includeCapsCheckBox.Size = new System.Drawing.Size(128, 24);
            this.includeCapsCheckBox.TabIndex = 10;
            this.includeCapsCheckBox.Text = "Include Caps";
            this.includeCapsCheckBox.UseVisualStyleBackColor = true;
            this.includeCapsCheckBox.CheckedChanged += new System.EventHandler(this.includeCapsCheckBox_CheckedChanged);
            // 
            // displayBlocksLabel
            // 
            this.displayBlocksLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.displayBlocksLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayBlocksLabel.Location = new System.Drawing.Point(217, 318);
            this.displayBlocksLabel.Name = "displayBlocksLabel";
            this.displayBlocksLabel.Size = new System.Drawing.Size(152, 23);
            this.displayBlocksLabel.TabIndex = 8;
            this.displayBlocksLabel.Text = "\r\n";
            this.displayBlocksLabel.Click += new System.EventHandler(this.displayBlocksLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(217, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Of Blocks Needed";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(388, 166);
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
            this.lengthLabel.Location = new System.Drawing.Point(125, 122);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(59, 20);
            this.lengthLabel.TabIndex = 7;
            this.lengthLabel.Text = "Length";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(125, 46);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(56, 20);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Height";
            // 
            // blockDimensionsLabel
            // 
            this.blockDimensionsLabel.AutoSize = true;
            this.blockDimensionsLabel.Location = new System.Drawing.Point(384, 22);
            this.blockDimensionsLabel.Name = "blockDimensionsLabel";
            this.blockDimensionsLabel.Size = new System.Drawing.Size(161, 20);
            this.blockDimensionsLabel.TabIndex = 5;
            this.blockDimensionsLabel.Text = "Block Dimensions (in)";
            // 
            // wallDimensionsLabel
            // 
            this.wallDimensionsLabel.AutoSize = true;
            this.wallDimensionsLabel.Location = new System.Drawing.Point(196, 22);
            this.wallDimensionsLabel.Name = "wallDimensionsLabel";
            this.wallDimensionsLabel.Size = new System.Drawing.Size(150, 20);
            this.wallDimensionsLabel.TabIndex = 4;
            this.wallDimensionsLabel.Text = "Wall Dimensions (ft)";
            // 
            // blockHeightTextBox
            // 
            this.blockHeightTextBox.Location = new System.Drawing.Point(398, 46);
            this.blockHeightTextBox.Name = "blockHeightTextBox";
            this.blockHeightTextBox.Size = new System.Drawing.Size(136, 26);
            this.blockHeightTextBox.TabIndex = 2;
            this.blockHeightTextBox.Tag = "Block Height Box";
            // 
            // blockLengthTextBox
            // 
            this.blockLengthTextBox.Location = new System.Drawing.Point(398, 117);
            this.blockLengthTextBox.Name = "blockLengthTextBox";
            this.blockLengthTextBox.Size = new System.Drawing.Size(136, 26);
            this.blockLengthTextBox.TabIndex = 4;
            this.blockLengthTextBox.Tag = "Block Length Box";
            // 
            // wallLengthTextBox
            // 
            this.wallLengthTextBox.Location = new System.Drawing.Point(199, 119);
            this.wallLengthTextBox.Name = "wallLengthTextBox";
            this.wallLengthTextBox.Size = new System.Drawing.Size(136, 26);
            this.wallLengthTextBox.TabIndex = 3;
            this.wallLengthTextBox.Tag = "Wall Length Box";
            // 
            // wallHeightTextBox
            // 
            this.wallHeightTextBox.Location = new System.Drawing.Point(199, 46);
            this.wallHeightTextBox.Name = "wallHeightTextBox";
            this.wallHeightTextBox.Size = new System.Drawing.Size(136, 26);
            this.wallHeightTextBox.TabIndex = 1;
            this.wallHeightTextBox.Tag = "Wall Height Box";
            this.wallHeightTextBox.TextChanged += new System.EventHandler(this.wallHeightTextBox_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelTotalCost);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.labelCostOfCaps);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.labelCostOfBlocks);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.buttonCalculateCost);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBoxCostOfCap);
            this.tabPage3.Controls.Add(this.textBoxCostOfBlock);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 423);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "  Cost  ";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelTotalCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTotalCost.Location = new System.Drawing.Point(538, 271);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(142, 23);
            this.labelTotalCost.TabIndex = 37;
            this.labelTotalCost.Text = "\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(555, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Total Cost";
            // 
            // labelCostOfCaps
            // 
            this.labelCostOfCaps.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelCostOfCaps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCostOfCaps.Location = new System.Drawing.Point(357, 271);
            this.labelCostOfCaps.Name = "labelCostOfCaps";
            this.labelCostOfCaps.Size = new System.Drawing.Size(142, 23);
            this.labelCostOfCaps.TabIndex = 35;
            this.labelCostOfCaps.Text = "\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(374, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Cost of Caps";
            // 
            // labelCostOfBlocks
            // 
            this.labelCostOfBlocks.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelCostOfBlocks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCostOfBlocks.Location = new System.Drawing.Point(154, 271);
            this.labelCostOfBlocks.Name = "labelCostOfBlocks";
            this.labelCostOfBlocks.Size = new System.Drawing.Size(152, 23);
            this.labelCostOfBlocks.TabIndex = 32;
            this.labelCostOfBlocks.Text = "\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(174, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cost of Blocks";
            // 
            // buttonCalculateCost
            // 
            this.buttonCalculateCost.Location = new System.Drawing.Point(340, 151);
            this.buttonCalculateCost.Name = "buttonCalculateCost";
            this.buttonCalculateCost.Size = new System.Drawing.Size(136, 47);
            this.buttonCalculateCost.TabIndex = 28;
            this.buttonCalculateCost.Text = "Calculate";
            this.buttonCalculateCost.UseVisualStyleBackColor = true;
            this.buttonCalculateCost.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cap";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Block";
            // 
            // textBoxCostOfCap
            // 
            this.textBoxCostOfCap.Location = new System.Drawing.Point(448, 77);
            this.textBoxCostOfCap.Name = "textBoxCostOfCap";
            this.textBoxCostOfCap.Size = new System.Drawing.Size(136, 26);
            this.textBoxCostOfCap.TabIndex = 24;
            this.textBoxCostOfCap.Tag = "Block Height Box";
            // 
            // textBoxCostOfBlock
            // 
            this.textBoxCostOfBlock.Location = new System.Drawing.Point(259, 77);
            this.textBoxCostOfBlock.Name = "textBoxCostOfBlock";
            this.textBoxCostOfBlock.Size = new System.Drawing.Size(136, 26);
            this.textBoxCostOfBlock.TabIndex = 23;
            this.textBoxCostOfBlock.Tag = "Wall Height Box";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonCopy);
            this.tabPage2.Controls.Add(this.buttonSaveFileToDirectory);
            this.tabPage2.Controls.Add(this.saveToDbButton);
            this.tabPage2.Controls.Add(this.projectNameLabel);
            this.tabPage2.Controls.Add(this.projectNameTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 423);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "  Save and Share Options  ";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // buttonSaveFileToDirectory
            // 
            this.buttonSaveFileToDirectory.Location = new System.Drawing.Point(509, 377);
            this.buttonSaveFileToDirectory.Name = "buttonSaveFileToDirectory";
            this.buttonSaveFileToDirectory.Size = new System.Drawing.Size(151, 32);
            this.buttonSaveFileToDirectory.TabIndex = 4;
            this.buttonSaveFileToDirectory.Text = "Save On Text File";
            this.buttonSaveFileToDirectory.UseVisualStyleBackColor = true;
            this.buttonSaveFileToDirectory.Click += new System.EventHandler(this.button1_Click);
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
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(33, 28);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(104, 20);
            this.projectNameLabel.TabIndex = 1;
            this.projectNameLabel.Text = "Project Name";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(37, 51);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(224, 26);
            this.projectNameTextBox.TabIndex = 0;
            this.projectNameTextBox.Tag = "Project Name Box";
            this.projectNameTextBox.TextChanged += new System.EventHandler(this.projectNameTextBox_TextChanged);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(385, 377);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(118, 32);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // retainingWallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "retainingWallForm";
            this.Text = "Retaining Wall";
            this.Load += new System.EventHandler(this.retainingWallForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox blockHeightTextBox;
        private System.Windows.Forms.TextBox blockLengthTextBox;
        private System.Windows.Forms.TextBox wallLengthTextBox;
        private System.Windows.Forms.Label blockDimensionsLabel;
        private System.Windows.Forms.Label wallDimensionsLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayBlocksLabel;
        private System.Windows.Forms.CheckBox includeCapsCheckBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Button saveToDbButton;
        public System.Windows.Forms.TextBox wallHeightTextBox;
        private System.Windows.Forms.Button buttonSaveFileToDirectory;
        private System.Windows.Forms.Label labelDisplayNumberOfCaps;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelCostOfCaps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCostOfBlocks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCalculateCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCostOfCap;
        public System.Windows.Forms.TextBox textBoxCostOfBlock;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCopy;
    }
}