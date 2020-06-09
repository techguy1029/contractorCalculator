namespace contractorCalculator
{
    partial class searchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchForm));
            this.searchButton = new System.Windows.Forms.Button();
            this.buttonResetSearch = new System.Windows.Forms.Button();
            this.textBoxSearchBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(369, 349);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(190, 48);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search Project Names";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // buttonResetSearch
            // 
            this.buttonResetSearch.Location = new System.Drawing.Point(565, 349);
            this.buttonResetSearch.Name = "buttonResetSearch";
            this.buttonResetSearch.Size = new System.Drawing.Size(100, 47);
            this.buttonResetSearch.TabIndex = 3;
            this.buttonResetSearch.Text = "Reset";
            this.buttonResetSearch.UseVisualStyleBackColor = true;
            this.buttonResetSearch.Click += new System.EventHandler(this.buttonResetSearch_Click);
            // 
            // textBoxSearchBox
            // 
            this.textBoxSearchBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxSearchBox.Location = new System.Drawing.Point(145, 360);
            this.textBoxSearchBox.Name = "textBoxSearchBox";
            this.textBoxSearchBox.Size = new System.Drawing.Size(178, 26);
            this.textBoxSearchBox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 331);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSearchBox);
            this.Controls.Add(this.buttonResetSearch);
            this.Controls.Add(this.searchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "searchForm";
            this.Text = "Search Projects";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.searchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button buttonResetSearch;
        private System.Windows.Forms.TextBox textBoxSearchBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}