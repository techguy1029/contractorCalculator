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
            this.retainingWallRadioButton = new System.Windows.Forms.RadioButton();
            this.selectProjectLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // retainingWallRadioButton
            // 
            this.retainingWallRadioButton.AutoSize = true;
            this.retainingWallRadioButton.Location = new System.Drawing.Point(18, 63);
            this.retainingWallRadioButton.Name = "retainingWallRadioButton";
            this.retainingWallRadioButton.Size = new System.Drawing.Size(136, 24);
            this.retainingWallRadioButton.TabIndex = 0;
            this.retainingWallRadioButton.TabStop = true;
            this.retainingWallRadioButton.Text = "Retaining Wall";
            this.retainingWallRadioButton.UseVisualStyleBackColor = true;
            // 
            // selectProjectLabel
            // 
            this.selectProjectLabel.AutoSize = true;
            this.selectProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectProjectLabel.Location = new System.Drawing.Point(12, 9);
            this.selectProjectLabel.Name = "selectProjectLabel";
            this.selectProjectLabel.Size = new System.Drawing.Size(370, 32);
            this.selectProjectLabel.TabIndex = 1;
            this.selectProjectLabel.Text = "Select Type of Project Label";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(650, 392);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(138, 46);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // projectSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.selectProjectLabel);
            this.Controls.Add(this.retainingWallRadioButton);
            this.Name = "projectSelectionForm";
            this.Text = "Select Project";
            this.Load += new System.EventHandler(this.projectSelectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton retainingWallRadioButton;
        private System.Windows.Forms.Label selectProjectLabel;
        private System.Windows.Forms.Button nextButton;
    }
}

