namespace CoinsManagement
{
    partial class frmLuuData
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
            this.cbbLoaiCoin = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.btnLuuData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbLoaiCoin
            // 
            this.cbbLoaiCoin.FormattingEnabled = true;
            this.cbbLoaiCoin.Items.AddRange(new object[] {
            "USD",
            "JPY",
            "VND",
            "EUR"});
            this.cbbLoaiCoin.Location = new System.Drawing.Point(69, 26);
            this.cbbLoaiCoin.Name = "cbbLoaiCoin";
            this.cbbLoaiCoin.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiCoin.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(1, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Loại Tiền";
            // 
            // btnLuuData
            // 
            this.btnLuuData.Location = new System.Drawing.Point(217, 24);
            this.btnLuuData.Name = "btnLuuData";
            this.btnLuuData.Size = new System.Drawing.Size(75, 23);
            this.btnLuuData.TabIndex = 3;
            this.btnLuuData.Text = "Lưu Data";
            this.btnLuuData.UseVisualStyleBackColor = true;
            this.btnLuuData.Click += new System.EventHandler(this.btnLuuData_Click);
            // 
            // frmLuuData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 71);
            this.Controls.Add(this.btnLuuData);
            this.Controls.Add(this.cbbLoaiCoin);
            this.Controls.Add(this.label);
            this.Name = "frmLuuData";
            this.Text = "frmLuuData";
            this.Load += new System.EventHandler(this.frmLuuData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbLoaiCoin;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnLuuData;
    }
}