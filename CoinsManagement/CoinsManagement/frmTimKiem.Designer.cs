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
            this.dateTimePickerBefore = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAfter = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(256, 97);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 0;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại coin";
            // 
            // cbbLoaiCoin
            // 
            this.cbbLoaiCoin.FormattingEnabled = true;
            this.cbbLoaiCoin.Location = new System.Drawing.Point(256, 40);
            this.cbbLoaiCoin.Name = "cbbLoaiCoin";
            this.cbbLoaiCoin.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiCoin.TabIndex = 2;
            // 
            // dateTimePickerBefore
            // 
            this.dateTimePickerBefore.CustomFormat = "\'Ngày\' dd \'Tháng\' MM \'Năm\' yyyy";
            this.dateTimePickerBefore.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBefore.Location = new System.Drawing.Point(12, 41);
            this.dateTimePickerBefore.Name = "dateTimePickerBefore";
            this.dateTimePickerBefore.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBefore.TabIndex = 3;
            // 
            // dateTimePickerAfter
            // 
            this.dateTimePickerAfter.CustomFormat = "\'Ngày\' dd \'Tháng\' MM \'Năm\' yyyy";
            this.dateTimePickerAfter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAfter.Location = new System.Drawing.Point(12, 100);
            this.dateTimePickerAfter.Name = "dateTimePickerAfter";
            this.dateTimePickerAfter.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAfter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến ngày";
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 137);
            this.Controls.Add(this.dateTimePickerAfter);
            this.Controls.Add(this.dateTimePickerBefore);
            this.Controls.Add(this.cbbLoaiCoin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.DateTimePicker dateTimePickerBefore;
        private System.Windows.Forms.DateTimePicker dateTimePickerAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}