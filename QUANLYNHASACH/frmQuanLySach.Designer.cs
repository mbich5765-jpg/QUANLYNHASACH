namespace QUANLYNHASACH
{
    partial class frmQuanLyKhoSach
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
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grdDanhSach = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.ForeColor = System.Drawing.Color.Red;
            this.lblMaSach.Location = new System.Drawing.Point(30, 27);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(101, 25);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách:";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.ForeColor = System.Drawing.Color.Red;
            this.lblTenSach.Location = new System.Drawing.Point(30, 60);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(109, 25);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Tên sách:";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.ForeColor = System.Drawing.Color.Red;
            this.lblTheLoai.Location = new System.Drawing.Point(570, 27);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(97, 25);
            this.lblTheLoai.TabIndex = 0;
            this.lblTheLoai.Text = "Thể loại:";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.ForeColor = System.Drawing.Color.Red;
            this.lblGiaTien.Location = new System.Drawing.Point(570, 60);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(93, 25);
            this.lblGiaTien.TabIndex = 0;
            this.lblGiaTien.Text = "Giá tiền:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(138, 29);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(317, 22);
            this.txtMaSach.TabIndex = 1;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(145, 64);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(317, 22);
            this.txtTenSach.TabIndex = 1;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(669, 64);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(317, 22);
            this.txtGiaTien.TabIndex = 1;
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Items.AddRange(new object[] {
            "Văn học",
            "Kỹ năng sống",
            "Sách Ngoại ngữ",
            "Manga - Comic",
            "Kinh tế",
            "Thám hiểm",
            "Sách trẻ em",
            "Sách âm nhạc",
            "Sách nấu ăn",
            "Sách thủ công"});
            this.cboTheLoai.Location = new System.Drawing.Point(673, 27);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(313, 24);
            this.cboTheLoai.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Red;
            this.btnThem.Location = new System.Drawing.Point(120, 118);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(191, 38);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm sách";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Location = new System.Drawing.Point(436, 118);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(171, 38);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(760, 118);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(167, 38);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa sách";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grdDanhSach
            // 
            this.grdDanhSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDanhSach.Location = new System.Drawing.Point(12, 171);
            this.grdDanhSach.Name = "grdDanhSach";
            this.grdDanhSach.RowHeadersWidth = 51;
            this.grdDanhSach.RowTemplate.Height = 24;
            this.grdDanhSach.Size = new System.Drawing.Size(1099, 442);
            this.grdDanhSach.TabIndex = 4;
            this.grdDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDanhSach_CellClick);
            this.grdDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDanhSach_CellContentClick);
            // 
            // frmQuanLyKhoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 625);
            this.Controls.Add(this.grdDanhSach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboTheLoai);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.lblTheLoai);
            this.Controls.Add(this.lblMaSach);
            this.Name = "frmQuanLyKhoSach";
            this.Text = "Quản Lý Kho Sách      ";
            this.Load += new System.EventHandler(this.frmQuanLyKhoSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView grdDanhSach;
    }
}