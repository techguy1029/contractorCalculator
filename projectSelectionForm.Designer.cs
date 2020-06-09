namespace contractorCalculator
{
    partial class projectSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(projectSelectionForm));
            this.retainingWallRadioButton = new System.Windows.Forms.RadioButton();
            this.selectProjectLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.searchProjectsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonSeedCalculator = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // retainingWallRadioButton
            // 
            this.retainingWallRadioButton.AutoSize = true;
            this.retainingWallRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retainingWallRadioButton.Location = new System.Drawing.Point(12, 73);
            this.retainingWallRadioButton.Name = "retainingWallRadioButton";
            this.retainingWallRadioButton.Size = new System.Drawing.Size(150, 24);
            this.retainingWallRadioButton.TabIndex = 0;
            this.retainingWallRadioButton.TabStop = true;
            this.retainingWallRadioButton.Text = "Retaining Wall";
            this.retainingWallRadioButton.UseVisualStyleBackColor = true;
            this.retainingWallRadioButton.CheckedChanged += new System.EventHandler(this.retainingWallRadioButton_CheckedChanged);
            // 
            // selectProjectLabel
            // 
            this.selectProjectLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectProjectLabel.AutoSize = true;
            this.selectProjectLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectProjectLabel.Location = new System.Drawing.Point(12, 9);
            this.selectProjectLabel.Name = "selectProjectLabel";
            this.selectProjectLabel.Size = new System.Drawing.Size(191, 32);
            this.selectProjectLabel.TabIndex = 3;
            this.selectProjectLabel.Text = "Select Project";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(607, 389);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(181, 49);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // searchProjectsButton
            // 
            this.searchProjectsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchProjectsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProjectsButton.Location = new System.Drawing.Point(12, 389);
            this.searchProjectsButton.Name = "searchProjectsButton";
            this.searchProjectsButton.Size = new System.Drawing.Size(186, 49);
            this.searchProjectsButton.TabIndex = 1;
            this.searchProjectsButton.Text = "Search Projects";
            this.searchProjectsButton.UseVisualStyleBackColor = true;
            this.searchProjectsButton.Click += new System.EventHandler(this.searchProjectsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(718, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButtonSeedCalculator
            // 
            this.radioButtonSeedCalculator.AutoSize = true;
            this.radioButtonSeedCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSeedCalculator.Location = new System.Drawing.Point(12, 103);
            this.radioButtonSeedCalculator.Name = "radioButtonSeedCalculator";
            this.radioButtonSeedCalculator.Size = new System.Drawing.Size(76, 24);
            this.radioButtonSeedCalculator.TabIndex = 6;
            this.radioButtonSeedCalculator.TabStop = true;
            this.radioButtonSeedCalculator.Text = "Seed";
            this.radioButtonSeedCalculator.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(642, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // projectSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.radioButtonSeedCalculator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchProjectsButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.selectProjectLabel);
            this.Controls.Add(this.retainingWallRadioButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "projectSelectionForm";
            this.Text = "Contractor Calculator";
            this.Load += new System.EventHandler(this.projectSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton retainingWallRadioButton;
        private System.Windows.Forms.Label selectProjectLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button searchProjectsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonSeedCalculator;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

