namespace CoinsManagement
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitcoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datacoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTien = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnfirstrun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.hỗTrợToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitcoinToolStripMenuItem,
            this.datacoinToolStripMenuItem,
            this.jPYToolStripMenuItem,
            this.eURToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // bitcoinToolStripMenuItem
            // 
            this.bitcoinToolStripMenuItem.Name = "bitcoinToolStripMenuItem";
            this.bitcoinToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.bitcoinToolStripMenuItem.Text = "USD";
            this.bitcoinToolStripMenuItem.Click += new System.EventHandler(this.bitcoinToolStripMenuItem_Click);
            // 
            // datacoinToolStripMenuItem
            // 
            this.datacoinToolStripMenuItem.Name = "datacoinToolStripMenuItem";
            this.datacoinToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.datacoinToolStripMenuItem.Text = "VND";
            this.datacoinToolStripMenuItem.Click += new System.EventHandler(this.datacoinToolStripMenuItem_Click);
            // 
            // jPYToolStripMenuItem
            // 
            this.jPYToolStripMenuItem.Name = "jPYToolStripMenuItem";
            this.jPYToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.jPYToolStripMenuItem.Text = "JPY";
            this.jPYToolStripMenuItem.Click += new System.EventHandler(this.jPYToolStripMenuItem_Click);
            // 
            // eURToolStripMenuItem
            // 
            this.eURToolStripMenuItem.Name = "eURToolStripMenuItem";
            this.eURToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.eURToolStripMenuItem.Text = "EUR";
            this.eURToolStripMenuItem.Click += new System.EventHandler(this.eURToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmToolStripMenuItem,
            this.lưuToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại tiền";
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTien.Location = new System.Drawing.Point(121, 44);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(36, 20);
            this.lbTien.TabIndex = 1;
            this.lbTien.Text = "Tèo";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(27, 84);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 3;
            this.btnLoc.Text = "Làm mới";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(557, 84);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(75, 23);
            this.btnPre.TabIndex = 3;
            this.btnPre.Text = "Trang trước";
            this.btnPre.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(638, 84);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Trang sau";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 273);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnfirstrun
            // 
            this.btnfirstrun.Location = new System.Drawing.Point(585, 55);
            this.btnfirstrun.Name = "btnfirstrun";
            this.btnfirstrun.Size = new System.Drawing.Size(93, 23);
            this.btnfirstrun.TabIndex = 5;
            this.btnfirstrun.Text = "Chạy lần đầu";
            this.btnfirstrun.UseVisualStyleBackColor = true;
            this.btnfirstrun.Click += new System.EventHandler(this.btnfirstrun_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 86400000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 403);
            this.Controls.Add(this.btnfirstrun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.lbTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitcoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datacoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTien;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem jPYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eURToolStripMenuItem;
        private System.Windows.Forms.Button btnfirstrun;
        private System.Windows.Forms.Timer timer1;
    }
}

