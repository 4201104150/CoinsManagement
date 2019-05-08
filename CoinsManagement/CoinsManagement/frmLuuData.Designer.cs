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
            this.dateTimePickerBefore = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAfter = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLoaiCoin = new System.Windows.Forms.ComboBox();
            this.btnLuuData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerBefore
            // 
            this.dateTimePickerBefore.CustomFormat = "\'Ngày\' dd \'Tháng\' MM \'Năm\' yyyy";
            this.dateTimePickerBefore.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBefore.Location = new System.Drawing.Point(12, 37);
            this.dateTimePickerBefore.Name = "dateTimePickerBefore";
            this.dateTimePickerBefore.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBefore.TabIndex = 0;
            // 
            // dateTimePickerAfter
            // 
            this.dateTimePickerAfter.CustomFormat = "\'Ngày\' dd \'Tháng\' MM \'Năm\' yyyy";
            this.dateTimePickerAfter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAfter.Location = new System.Drawing.Point(12, 100);
            this.dateTimePickerAfter.Name = "dateTimePickerAfter";
            this.dateTimePickerAfter.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAfter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ngày";
            // 
            // cbbLoaiCoin
            // 
            this.cbbLoaiCoin.FormattingEnabled = true;
            this.cbbLoaiCoin.Location = new System.Drawing.Point(255, 36);
            this.cbbLoaiCoin.Name = "cbbLoaiCoin";
            this.cbbLoaiCoin.Size = new System.Drawing.Size(121, 21);
            this.cbbLoaiCoin.TabIndex = 2;
            // 
            // btnLuuData
            // 
            this.btnLuuData.Location = new System.Drawing.Point(255, 97);
            this.btnLuuData.Name = "btnLuuData";
            this.btnLuuData.Size = new System.Drawing.Size(75, 23);
            this.btnLuuData.TabIndex = 3;
            this.btnLuuData.Text = "Lưu Data";
            this.btnLuuData.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(252, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Loại coin";
            // 
            // frmLuuData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 152);
            this.Controls.Add(this.btnLuuData);
            this.Controls.Add(this.cbbLoaiCoin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerAfter);
            this.Controls.Add(this.dateTimePickerBefore);
            this.Name = "frmLuuData";
            this.Text = "frmLuuData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerBefore;
        private System.Windows.Forms.DateTimePicker dateTimePickerAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLoaiCoin;
        private System.Windows.Forms.Button btnLuuData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
    }
}