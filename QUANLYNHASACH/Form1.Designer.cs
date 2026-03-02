namespace QUANLYNHASACH
{
    partial class frmLogin
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
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.lblDangKy = new System.Windows.Forms.Label();
            this.pnlGachChan = new System.Windows.Forms.Panel();
            this.pnlDangNhap = new System.Windows.Forms.Panel();
            this.pnlDangKy = new System.Windows.Forms.Panel();
            this.txtDangKyTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtDangKyMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoan.Location = new System.Drawing.Point(217, 260);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(347, 30);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.Text = "Nhập số điện thoại hoặc email";
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtTaiKhoan.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
            this.txtTaiKhoan.Leave += new System.EventHandler(this.txtTaiKhoan_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.Location = new System.Drawing.Point(627, 298);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(347, 30);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.Text = "Nhập mật khẩu";
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Yellow;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.Black;
            this.btnDangNhap.Location = new System.Drawing.Point(274, 425);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(244, 52);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 3;
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.Location = new System.Drawing.Point(379, 85);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(105, 25);
            this.lblDangNhap.TabIndex = 4;
            this.lblDangNhap.Text = "Đăng nhập";
            this.lblDangNhap.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // lblDangKy
            // 
            this.lblDangKy.AutoSize = true;
            this.lblDangKy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKy.Location = new System.Drawing.Point(745, 85);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(83, 25);
            this.lblDangKy.TabIndex = 4;
            this.lblDangKy.Text = "Đăng ký ";
            this.lblDangKy.Click += new System.EventHandler(this.lblDangKy_Click);
            this.lblDangKy.Enter += new System.EventHandler(this.lblDangKy_Enter);
            // 
            // pnlGachChan
            // 
            this.pnlGachChan.BackColor = System.Drawing.Color.Red;
            this.pnlGachChan.Location = new System.Drawing.Point(342, 124);
            this.pnlGachChan.Name = "pnlGachChan";
            this.pnlGachChan.Size = new System.Drawing.Size(183, 10);
            this.pnlGachChan.TabIndex = 5;
            this.pnlGachChan.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGachChan_Paint);
            // 
            // pnlDangNhap
            // 
            this.pnlDangNhap.BackColor = System.Drawing.Color.Yellow;
            this.pnlDangNhap.Location = new System.Drawing.Point(217, 156);
            this.pnlDangNhap.Name = "pnlDangNhap";
            this.pnlDangNhap.Size = new System.Drawing.Size(347, 10);
            this.pnlDangNhap.TabIndex = 6;
            // 
            // pnlDangKy
            // 
            this.pnlDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlDangKy.Location = new System.Drawing.Point(627, 156);
            this.pnlDangKy.Name = "pnlDangKy";
            this.pnlDangKy.Size = new System.Drawing.Size(347, 10);
            this.pnlDangKy.TabIndex = 6;
            this.pnlDangKy.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDangKy_Paint);
            // 
            // txtDangKyTaiKhoan
            // 
            this.txtDangKyTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDangKyTaiKhoan.Location = new System.Drawing.Point(627, 212);
            this.txtDangKyTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDangKyTaiKhoan.Name = "txtDangKyTaiKhoan";
            this.txtDangKyTaiKhoan.Size = new System.Drawing.Size(347, 30);
            this.txtDangKyTaiKhoan.TabIndex = 1;
            this.txtDangKyTaiKhoan.Text = "Nhập số điện thoại hoặc email";
            this.txtDangKyTaiKhoan.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtDangKyTaiKhoan.Enter += new System.EventHandler(this.txtDangKyTaiKhoan_Enter);
            this.txtDangKyTaiKhoan.Leave += new System.EventHandler(this.txtDangKyTaiKhoan_Leave);
            // 
            // txtDangKyMatKhau
            // 
            this.txtDangKyMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDangKyMatKhau.Location = new System.Drawing.Point(627, 250);
            this.txtDangKyMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDangKyMatKhau.Name = "txtDangKyMatKhau";
            this.txtDangKyMatKhau.Size = new System.Drawing.Size(347, 30);
            this.txtDangKyMatKhau.TabIndex = 1;
            this.txtDangKyMatKhau.Text = "Nhập mật khẩu";
            this.txtDangKyMatKhau.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtDangKyMatKhau.Enter += new System.EventHandler(this.txtDangKyMatKhau_Enter);
            this.txtDangKyMatKhau.Leave += new System.EventHandler(this.txtDangKyMatKhau_Leave);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(217, 298);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(347, 30);
            this.txtXacNhanMatKhau.TabIndex = 1;
            this.txtXacNhanMatKhau.Text = "Nhập lại mật khẩu";
            this.txtXacNhanMatKhau.TextChanged += new System.EventHandler(this.txtTenDangNhap_TextChanged);
            this.txtXacNhanMatKhau.Enter += new System.EventHandler(this.txtXacNhanMatKhau_Enter);
            this.txtXacNhanMatKhau.Leave += new System.EventHandler(this.txtXacNhanMatKhau_Leave);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.Black;
            this.btnDangKy.Location = new System.Drawing.Point(683, 425);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(244, 52);
            this.btnDangKy.TabIndex = 2;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            this.btnDangKy.Enter += new System.EventHandler(this.btnDangKy_Enter);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1406, 850);
            this.Controls.Add(this.pnlDangKy);
            this.Controls.Add(this.pnlDangNhap);
            this.Controls.Add(this.pnlGachChan);
            this.Controls.Add(this.lblDangKy);
            this.Controls.Add(this.lblDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtDangKyMatKhau);
            this.Controls.Add(this.txtDangKyTaiKhoan);
            this.Controls.Add(this.txtTaiKhoan);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Text = "Đăng Nhập Hệ Thống.";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label lblDangKy;
        private System.Windows.Forms.Panel pnlGachChan;
        private System.Windows.Forms.Panel pnlDangNhap;
        private System.Windows.Forms.Panel pnlDangKy;
        private System.Windows.Forms.TextBox txtDangKyTaiKhoan;
        private System.Windows.Forms.TextBox txtDangKyMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Button btnDangKy;
    }
}

