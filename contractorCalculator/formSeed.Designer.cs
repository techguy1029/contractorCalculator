namespace contractorCalculator
{
    partial class formSeed
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxTriangleHeight = new System.Windows.Forms.GroupBox();
            this.textBoxTriangleCoverageRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTriangleBase = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTriangleHeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxEllipsisCoverageRate = new System.Windows.Forms.TextBox();
            this.textBoxEllipsisBAxis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEllipsisAAxis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCircleCoverageRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCircleRadius = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxRectangleLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRectangleWidth = new System.Windows.Forms.TextBox();
            this.textBoxRectangleCoverage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSaveFileToDirectory = new System.Windows.Forms.Button();
            this.saveToDbButton = new System.Windows.Forms.Button();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxTriangleHeight.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.buttonCalculate);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.groupBoxTriangleHeight);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBoxShape);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Dimensions ";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(333, 120);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 39);
            this.buttonCalculate.TabIndex = 16;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(333, 185);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(314, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Seed Needed(lbs)";
            // 
            // groupBoxTriangleHeight
            // 
            this.groupBoxTriangleHeight.Controls.Add(this.textBoxTriangleCoverageRate);
            this.groupBoxTriangleHeight.Controls.Add(this.label12);
            this.groupBoxTriangleHeight.Controls.Add(this.textBoxTriangleBase);
            this.groupBoxTriangleHeight.Controls.Add(this.label9);
            this.groupBoxTriangleHeight.Controls.Add(this.textBoxTriangleHeight);
            this.groupBoxTriangleHeight.Controls.Add(this.label10);
            this.groupBoxTriangleHeight.Location = new System.Drawing.Point(457, 230);
            this.groupBoxTriangleHeight.Name = "groupBoxTriangleHeight";
            this.groupBoxTriangleHeight.Size = new System.Drawing.Size(273, 179);
            this.groupBoxTriangleHeight.TabIndex = 13;
            this.groupBoxTriangleHeight.TabStop = false;
            this.groupBoxTriangleHeight.Text = "Triangle";
            // 
            // textBoxTriangleCoverageRate
            // 
            this.textBoxTriangleCoverageRate.Location = new System.Drawing.Point(84, 114);
            this.textBoxTriangleCoverageRate.Name = "textBoxTriangleCoverageRate";
            this.textBoxTriangleCoverageRate.Size = new System.Drawing.Size(112, 26);
            this.textBoxTriangleCoverageRate.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Coverage Rate";
            // 
            // textBoxTriangleBase
            // 
            this.textBoxTriangleBase.Location = new System.Drawing.Point(143, 60);
            this.textBoxTriangleBase.Name = "textBoxTriangleBase";
            this.textBoxTriangleBase.Size = new System.Drawing.Size(100, 26);
            this.textBoxTriangleBase.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Height";
            // 
            // textBoxTriangleHeight
            // 
            this.textBoxTriangleHeight.Location = new System.Drawing.Point(23, 60);
            this.textBoxTriangleHeight.Name = "textBoxTriangleHeight";
            this.textBoxTriangleHeight.Size = new System.Drawing.Size(100, 26);
            this.textBoxTriangleHeight.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Base";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.textBoxEllipsisCoverageRate);
            this.groupBox3.Controls.Add(this.textBoxEllipsisBAxis);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxEllipsisAAxis);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(32, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 179);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ellipsis";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "B Axis";
            // 
            // textBoxEllipsisCoverageRate
            // 
            this.textBoxEllipsisCoverageRate.Location = new System.Drawing.Point(81, 114);
            this.textBoxEllipsisCoverageRate.Name = "textBoxEllipsisCoverageRate";
            this.textBoxEllipsisCoverageRate.Size = new System.Drawing.Size(112, 26);
            this.textBoxEllipsisCoverageRate.TabIndex = 6;
            // 
            // textBoxEllipsisBAxis
            // 
            this.textBoxEllipsisBAxis.Location = new System.Drawing.Point(143, 60);
            this.textBoxEllipsisBAxis.Name = "textBoxEllipsisBAxis";
            this.textBoxEllipsisBAxis.Size = new System.Drawing.Size(100, 26);
            this.textBoxEllipsisBAxis.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "A Axis";
            // 
            // textBoxEllipsisAAxis
            // 
            this.textBoxEllipsisAAxis.Location = new System.Drawing.Point(23, 60);
            this.textBoxEllipsisAAxis.Name = "textBoxEllipsisAAxis";
            this.textBoxEllipsisAAxis.Size = new System.Drawing.Size(100, 26);
            this.textBoxEllipsisAAxis.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Coverage Rate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCircleCoverageRate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxCircleRadius);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(457, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 164);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Circle";
            // 
            // textBoxCircleCoverageRate
            // 
            this.textBoxCircleCoverageRate.Location = new System.Drawing.Point(143, 60);
            this.textBoxCircleCoverageRate.Name = "textBoxCircleCoverageRate";
            this.textBoxCircleCoverageRate.Size = new System.Drawing.Size(100, 26);
            this.textBoxCircleCoverageRate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Radius";
            // 
            // textBoxCircleRadius
            // 
            this.textBoxCircleRadius.Location = new System.Drawing.Point(23, 60);
            this.textBoxCircleRadius.Name = "textBoxCircleRadius";
            this.textBoxCircleRadius.Size = new System.Drawing.Size(100, 26);
            this.textBoxCircleRadius.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Coverage Rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxRectangleLength);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxRectangleWidth);
            this.groupBox1.Controls.Add(this.textBoxRectangleCoverage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 164);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rectangle";
            // 
            // textBoxRectangleLength
            // 
            this.textBoxRectangleLength.Location = new System.Drawing.Point(143, 60);
            this.textBoxRectangleLength.Name = "textBoxRectangleLength";
            this.textBoxRectangleLength.Size = new System.Drawing.Size(100, 26);
            this.textBoxRectangleLength.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // textBoxRectangleWidth
            // 
            this.textBoxRectangleWidth.Location = new System.Drawing.Point(23, 60);
            this.textBoxRectangleWidth.Name = "textBoxRectangleWidth";
            this.textBoxRectangleWidth.Size = new System.Drawing.Size(100, 26);
            this.textBoxRectangleWidth.TabIndex = 0;
            // 
            // textBoxRectangleCoverage
            // 
            this.textBoxRectangleCoverage.Location = new System.Drawing.Point(81, 125);
            this.textBoxRectangleCoverage.Name = "textBoxRectangleCoverage";
            this.textBoxRectangleCoverage.Size = new System.Drawing.Size(100, 26);
            this.textBoxRectangleCoverage.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Coverage Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Length";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lawn Shape";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Items.AddRange(new object[] {
            "Rectangle",
            "Circle",
            "Ellipsis",
            "Triangle"});
            this.comboBoxShape.Location = new System.Drawing.Point(318, 23);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(133, 28);
            this.comboBoxShape.TabIndex = 8;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textBox11);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 423);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = " Cost ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Seed Cost";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(24, 45);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 26);
            this.textBox11.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSaveFileToDirectory);
            this.tabPage2.Controls.Add(this.saveToDbButton);
            this.tabPage2.Controls.Add(this.projectNameLabel);
            this.tabPage2.Controls.Add(this.projectNameTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 423);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = " Save and Share ";
            // 
            // buttonSaveFileToDirectory
            // 
            this.buttonSaveFileToDirectory.Location = new System.Drawing.Point(497, 370);
            this.buttonSaveFileToDirectory.Name = "buttonSaveFileToDirectory";
            this.buttonSaveFileToDirectory.Size = new System.Drawing.Size(151, 32);
            this.buttonSaveFileToDirectory.TabIndex = 8;
            this.buttonSaveFileToDirectory.Text = "Save On Text File";
            this.buttonSaveFileToDirectory.UseVisualStyleBackColor = true;
            // 
            // saveToDbButton
            // 
            this.saveToDbButton.Location = new System.Drawing.Point(654, 370);
            this.saveToDbButton.Name = "saveToDbButton";
            this.saveToDbButton.Size = new System.Drawing.Size(118, 32);
            this.saveToDbButton.TabIndex = 7;
            this.saveToDbButton.Text = "Save";
            this.saveToDbButton.UseVisualStyleBackColor = true;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(21, 21);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(104, 20);
            this.projectNameLabel.TabIndex = 6;
            this.projectNameLabel.Text = "Project Name";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(25, 44);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(224, 26);
            this.projectNameTextBox.TabIndex = 5;
            this.projectNameTextBox.Tag = "Project Name Box";
            // 
            // formSeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "formSeed";
            this.Text = "formSeed";
            this.Load += new System.EventHandler(this.formSeed_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBoxTriangleHeight.ResumeLayout(false);
            this.groupBoxTriangleHeight.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRectangleCoverage;
        private System.Windows.Forms.TextBox textBoxRectangleLength;
        private System.Windows.Forms.TextBox textBoxRectangleWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxTriangleHeight;
        private System.Windows.Forms.TextBox textBoxTriangleBase;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTriangleHeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEllipsisCoverageRate;
        private System.Windows.Forms.TextBox textBoxEllipsisBAxis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEllipsisAAxis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCircleCoverageRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCircleRadius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTriangleCoverageRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSaveFileToDirectory;
        private System.Windows.Forms.Button saveToDbButton;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonCalculate;
    }
}