namespace QUANLYNHASACH
{
    partial class frmTrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLySach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeThongDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuQuanLySach,
            this.mnuBanHang,
            this.báoCáoThốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(128, 252);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.BackColor = System.Drawing.Color.Yellow;
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThongDangXuat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(159, 42);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuQuanLySach
            // 
            this.mnuQuanLySach.BackColor = System.Drawing.Color.Yellow;
            this.mnuQuanLySach.Name = "mnuQuanLySach";
            this.mnuQuanLySach.Size = new System.Drawing.Size(206, 42);
            this.mnuQuanLySach.Text = "Quản lý sách";
            this.mnuQuanLySach.Click += new System.EventHandler(this.mnuQuanLySach_Click);
            // 
            // mnuBanHang
            // 
            this.mnuBanHang.BackColor = System.Drawing.Color.Yellow;
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Size = new System.Drawing.Size(155, 42);
            this.mnuBanHang.Text = "Bán hàng";
            this.mnuBanHang.Click += new System.EventHandler(this.mnuBanHang_Click);
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(264, 42);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            this.báoCáoThốngKêToolStripMenuItem.Click += new System.EventHandler(this.báoCáoThốngKêToolStripMenuItem_Click_1);
            // 
            // mnuHeThongDangXuat
            // 
            this.mnuHeThongDangXuat.Name = "mnuHeThongDangXuat";
            this.mnuHeThongDangXuat.Size = new System.Drawing.Size(224, 26);
            this.mnuHeThongDangXuat.Text = "Đăng xuất";
            this.mnuHeThongDangXuat.Click += new System.EventHandler(this.mnuHeThongDangXuat_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1139, 615);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChu";
            this.Text = "Phần Mềm Quản Lý Nhà Sách - Trang Chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLySach;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThongDangXuat;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
    }
}