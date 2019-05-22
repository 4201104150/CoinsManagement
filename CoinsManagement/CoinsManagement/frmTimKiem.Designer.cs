namespace CoinsManagement
{
    partial class frmTimKiem
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
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiCoin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoaiCoin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(150, 41);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại tiền";
            // 
            // cbbLoaiCoin
            // 
            this.cbbLoaiCoin.FormattingEnabled = true;
            this.cbbLoaiCoin.Items.AddRange(new object[] {
            "USD",
            "JPY",
            "VND",
            "EUR"});
            this.cbbLoaiCoin.Location = new System.Drawing.Point(244, 43);
            this.cbbLoaiCoin.Name = "cbbLoaiCoin";
            this.cbbLoaiCoin.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiCoin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại Coin";
            // 
            // txtLoaiCoin
            // 
            this.txtLoaiCoin.Location = new System.Drawing.Point(30, 43);
            this.txtLoaiCoin.Name = "txtLoaiCoin";
            this.txtLoaiCoin.Size = new System.Drawing.Size(100, 20);
            this.txtLoaiCoin.TabIndex = 3;
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 91);
            this.Controls.Add(this.txtLoaiCoin);
            this.Controls.Add(this.cbbLoaiCoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFind);
            this.Name = "frmTimKiem";
            this.Text = "frmTimKiem";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLoaiCoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoaiCoin;
    }
}