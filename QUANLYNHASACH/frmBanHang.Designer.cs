namespace QUANLYNHASACH
{
    partial class pnlGioHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlGioHang));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlThanhTimKiem = new System.Windows.Forms.Panel();
            this.picTimKiemIcon = new System.Windows.Forms.PictureBox();
            this.cboNgonNgu = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiemThongMinh = new System.Windows.Forms.TextBox();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnGiamGia = new System.Windows.Forms.Button();
            this.btnThuCong = new System.Windows.Forms.Button();
            this.btnNauAn = new System.Windows.Forms.Button();
            this.btnAmNhac = new System.Windows.Forms.Button();
            this.btnTreEm = new System.Windows.Forms.Button();
            this.btnThamHiem = new System.Windows.Forms.Button();
            this.btnManga = new System.Windows.Forms.Button();
            this.btnNgoaiNgu = new System.Windows.Forms.Button();
            this.btnKyNangSong = new System.Windows.Forms.Button();
            this.btnKinhTe = new System.Windows.Forms.Button();
            this.btnVanHoc = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.lblDanhMucHeader = new System.Windows.Forms.Label();
            this.pnlKhuVucGioHang = new System.Windows.Forms.Panel();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.grdGioHang = new System.Windows.Forms.DataGridView();
            this.pnlThanhToanBottom = new System.Windows.Forms.Panel();
            this.btnXoaKhoiGio = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGioHangHeader = new System.Windows.Forms.Label();
            this.flpDanhSachSach = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlThanhTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiemIcon)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            this.pnlKhuVucGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGioHang)).BeginInit();
            this.pnlThanhToanBottom.SuspendLayout();
            this.flpDanhSachSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Yellow;
            this.pnlHeader.Controls.Add(this.pnlThanhTimKiem);
            this.pnlHeader.Controls.Add(this.cboNgonNgu);
            this.pnlHeader.Controls.Add(this.btnTimKiem);
            this.pnlHeader.Controls.Add(this.txtTimKiemThongMinh);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1170, 60);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // pnlThanhTimKiem
            // 
            this.pnlThanhTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlThanhTimKiem.Controls.Add(this.picTimKiemIcon);
            this.pnlThanhTimKiem.Location = new System.Drawing.Point(497, 17);
            this.pnlThanhTimKiem.Name = "pnlThanhTimKiem";
            this.pnlThanhTimKiem.Size = new System.Drawing.Size(30, 28);
            this.pnlThanhTimKiem.TabIndex = 3;
            // 
            // picTimKiemIcon
            // 
            this.picTimKiemIcon.Image = ((System.Drawing.Image)(resources.GetObject("picTimKiemIcon.Image")));
            this.picTimKiemIcon.Location = new System.Drawing.Point(0, -4);
            this.picTimKiemIcon.Name = "picTimKiemIcon";
            this.picTimKiemIcon.Size = new System.Drawing.Size(30, 34);
            this.picTimKiemIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiemIcon.TabIndex = 0;
            this.picTimKiemIcon.TabStop = false;
            // 
            // cboNgonNgu
            // 
            this.cboNgonNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgonNgu.ForeColor = System.Drawing.Color.Blue;
            this.cboNgonNgu.FormattingEnabled = true;
            this.cboNgonNgu.Items.AddRange(new object[] {
            "Tiếng Anh ",
            "Tiếng Việt"});
            this.cboNgonNgu.Location = new System.Drawing.Point(613, 22);
            this.cboNgonNgu.Name = "cboNgonNgu";
            this.cboNgonNgu.Size = new System.Drawing.Size(121, 24);
            this.cboNgonNgu.TabIndex = 2;
            this.cboNgonNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgonNgu_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Red;
            this.btnTimKiem.Location = new System.Drawing.Point(13, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(129, 34);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemThongMinh
            // 
            this.txtTimKiemThongMinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemThongMinh.Location = new System.Drawing.Point(148, 17);
            this.txtTimKiemThongMinh.Name = "txtTimKiemThongMinh";
            this.txtTimKiemThongMinh.Size = new System.Drawing.Size(379, 28);
            this.txtTimKiemThongMinh.TabIndex = 0;
            this.txtTimKiemThongMinh.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSideBar.Controls.Add(this.btnGiamGia);
            this.pnlSideBar.Controls.Add(this.btnThuCong);
            this.pnlSideBar.Controls.Add(this.btnNauAn);
            this.pnlSideBar.Controls.Add(this.btnAmNhac);
            this.pnlSideBar.Controls.Add(this.btnTreEm);
            this.pnlSideBar.Controls.Add(this.btnThamHiem);
            this.pnlSideBar.Controls.Add(this.btnManga);
            this.pnlSideBar.Controls.Add(this.btnNgoaiNgu);
            this.pnlSideBar.Controls.Add(this.btnKyNangSong);
            this.pnlSideBar.Controls.Add(this.btnKinhTe);
            this.pnlSideBar.Controls.Add(this.btnVanHoc);
            this.pnlSideBar.Controls.Add(this.btnTatCa);
            this.pnlSideBar.Controls.Add(this.lblDanhMucHeader);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 60);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(200, 794);
            this.pnlSideBar.TabIndex = 1;
            this.pnlSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSideBar_Paint);
            // 
            // btnGiamGia
            // 
            this.btnGiamGia.BackColor = System.Drawing.Color.White;
            this.btnGiamGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiamGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiamGia.ForeColor = System.Drawing.Color.Red;
            this.btnGiamGia.Location = new System.Drawing.Point(0, 407);
            this.btnGiamGia.Name = "btnGiamGia";
            this.btnGiamGia.Size = new System.Drawing.Size(200, 37);
            this.btnGiamGia.TabIndex = 7;
            this.btnGiamGia.Text = "Deal Hot 🔥";
            this.btnGiamGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiamGia.UseVisualStyleBackColor = false;
            this.btnGiamGia.Click += new System.EventHandler(this.btnGiamGia_Click);
            // 
            // btnThuCong
            // 
            this.btnThuCong.BackColor = System.Drawing.Color.White;
            this.btnThuCong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThuCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuCong.Location = new System.Drawing.Point(0, 370);
            this.btnThuCong.Name = "btnThuCong";
            this.btnThuCong.Size = new System.Drawing.Size(200, 37);
            this.btnThuCong.TabIndex = 6;
            this.btnThuCong.Text = "Sách thủ công";
            this.btnThuCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThuCong.UseVisualStyleBackColor = false;
            this.btnThuCong.Click += new System.EventHandler(this.btnThuCong_Click);
            // 
            // btnNauAn
            // 
            this.btnNauAn.BackColor = System.Drawing.Color.White;
            this.btnNauAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNauAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNauAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNauAn.Location = new System.Drawing.Point(0, 333);
            this.btnNauAn.Name = "btnNauAn";
            this.btnNauAn.Size = new System.Drawing.Size(200, 37);
            this.btnNauAn.TabIndex = 5;
            this.btnNauAn.Text = "Sách nấu ăn";
            this.btnNauAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNauAn.UseVisualStyleBackColor = false;
            this.btnNauAn.Click += new System.EventHandler(this.btnNauAn_Click);
            // 
            // btnAmNhac
            // 
            this.btnAmNhac.BackColor = System.Drawing.Color.White;
            this.btnAmNhac.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAmNhac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmNhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmNhac.Location = new System.Drawing.Point(0, 296);
            this.btnAmNhac.Name = "btnAmNhac";
            this.btnAmNhac.Size = new System.Drawing.Size(200, 37);
            this.btnAmNhac.TabIndex = 4;
            this.btnAmNhac.Text = "Sách âm nhạc";
            this.btnAmNhac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAmNhac.UseVisualStyleBackColor = false;
            this.btnAmNhac.Click += new System.EventHandler(this.btnAmNhac_Click);
            // 
            // btnTreEm
            // 
            this.btnTreEm.BackColor = System.Drawing.Color.White;
            this.btnTreEm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTreEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreEm.Location = new System.Drawing.Point(0, 259);
            this.btnTreEm.Name = "btnTreEm";
            this.btnTreEm.Size = new System.Drawing.Size(200, 37);
            this.btnTreEm.TabIndex = 3;
            this.btnTreEm.Text = "Sách trẻ em";
            this.btnTreEm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTreEm.UseVisualStyleBackColor = false;
            this.btnTreEm.Click += new System.EventHandler(this.btnTreEm_Click);
            // 
            // btnThamHiem
            // 
            this.btnThamHiem.BackColor = System.Drawing.Color.White;
            this.btnThamHiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThamHiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThamHiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThamHiem.Location = new System.Drawing.Point(0, 222);
            this.btnThamHiem.Name = "btnThamHiem";
            this.btnThamHiem.Size = new System.Drawing.Size(200, 37);
            this.btnThamHiem.TabIndex = 2;
            this.btnThamHiem.Text = "Thám hiểm";
            this.btnThamHiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThamHiem.UseVisualStyleBackColor = false;
            this.btnThamHiem.Click += new System.EventHandler(this.btnThamHiem_Click);
            // 
            // btnManga
            // 
            this.btnManga.BackColor = System.Drawing.Color.White;
            this.btnManga.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManga.Location = new System.Drawing.Point(0, 185);
            this.btnManga.Name = "btnManga";
            this.btnManga.Size = new System.Drawing.Size(200, 37);
            this.btnManga.TabIndex = 1;
            this.btnManga.Text = "Manga - Comic";
            this.btnManga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManga.UseVisualStyleBackColor = false;
            this.btnManga.Click += new System.EventHandler(this.btnManga_Click);
            // 
            // btnNgoaiNgu
            // 
            this.btnNgoaiNgu.BackColor = System.Drawing.Color.White;
            this.btnNgoaiNgu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNgoaiNgu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgoaiNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNgoaiNgu.Location = new System.Drawing.Point(0, 148);
            this.btnNgoaiNgu.Name = "btnNgoaiNgu";
            this.btnNgoaiNgu.Size = new System.Drawing.Size(200, 37);
            this.btnNgoaiNgu.TabIndex = 1;
            this.btnNgoaiNgu.Text = "Sách Ngoại ngữ";
            this.btnNgoaiNgu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNgoaiNgu.UseVisualStyleBackColor = false;
            this.btnNgoaiNgu.Click += new System.EventHandler(this.btnNgoaiNgu_Click);
            // 
            // btnKyNangSong
            // 
            this.btnKyNangSong.BackColor = System.Drawing.Color.White;
            this.btnKyNangSong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKyNangSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKyNangSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyNangSong.Location = new System.Drawing.Point(0, 111);
            this.btnKyNangSong.Name = "btnKyNangSong";
            this.btnKyNangSong.Size = new System.Drawing.Size(200, 37);
            this.btnKyNangSong.TabIndex = 1;
            this.btnKyNangSong.Text = "Kỹ năng sống";
            this.btnKyNangSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKyNangSong.UseVisualStyleBackColor = false;
            this.btnKyNangSong.Click += new System.EventHandler(this.btnKyNangSong_Click);
            // 
            // btnKinhTe
            // 
            this.btnKinhTe.BackColor = System.Drawing.Color.White;
            this.btnKinhTe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKinhTe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKinhTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKinhTe.Location = new System.Drawing.Point(0, 74);
            this.btnKinhTe.Name = "btnKinhTe";
            this.btnKinhTe.Size = new System.Drawing.Size(200, 37);
            this.btnKinhTe.TabIndex = 1;
            this.btnKinhTe.Text = "Kinh tế";
            this.btnKinhTe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKinhTe.UseVisualStyleBackColor = false;
            this.btnKinhTe.Click += new System.EventHandler(this.btnKinhTe_Click);
            // 
            // btnVanHoc
            // 
            this.btnVanHoc.BackColor = System.Drawing.Color.White;
            this.btnVanHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVanHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVanHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVanHoc.Location = new System.Drawing.Point(0, 37);
            this.btnVanHoc.Name = "btnVanHoc";
            this.btnVanHoc.Size = new System.Drawing.Size(200, 37);
            this.btnVanHoc.TabIndex = 1;
            this.btnVanHoc.Text = "Văn học";
            this.btnVanHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVanHoc.UseVisualStyleBackColor = false;
            this.btnVanHoc.Click += new System.EventHandler(this.btnVanHoc_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.White;
            this.btnTatCa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.Location = new System.Drawing.Point(0, 0);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(200, 37);
            this.btnTatCa.TabIndex = 1;
            this.btnTatCa.Text = "Tất cả sách";
            this.btnTatCa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // lblDanhMucHeader
            // 
            this.lblDanhMucHeader.AutoSize = true;
            this.lblDanhMucHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhMucHeader.Location = new System.Drawing.Point(10, 19);
            this.lblDanhMucHeader.Name = "lblDanhMucHeader";
            this.lblDanhMucHeader.Size = new System.Drawing.Size(174, 22);
            this.lblDanhMucHeader.TabIndex = 0;
            this.lblDanhMucHeader.Text = "DANH MỤC SÁCH";
            // 
            // pnlKhuVucGioHang
            // 
            this.pnlKhuVucGioHang.BackColor = System.Drawing.Color.White;
            this.pnlKhuVucGioHang.Controls.Add(this.dgvGioHang);
            this.pnlKhuVucGioHang.Controls.Add(this.grdGioHang);
            this.pnlKhuVucGioHang.Controls.Add(this.pnlThanhToanBottom);
            this.pnlKhuVucGioHang.Controls.Add(this.lblGioHangHeader);
            this.pnlKhuVucGioHang.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlKhuVucGioHang.Location = new System.Drawing.Point(865, 60);
            this.pnlKhuVucGioHang.Name = "pnlKhuVucGioHang";
            this.pnlKhuVucGioHang.Size = new System.Drawing.Size(305, 794);
            this.pnlKhuVucGioHang.TabIndex = 2;
            this.pnlKhuVucGioHang.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKhuVucGioHang_Paint);
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(6, 37);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.Size = new System.Drawing.Size(296, 542);
            this.dgvGioHang.TabIndex = 3;
            this.dgvGioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellContentClick);
            // 
            // grdGioHang
            // 
            this.grdGioHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGioHang.Location = new System.Drawing.Point(0, 29);
            this.grdGioHang.Margin = new System.Windows.Forms.Padding(0);
            this.grdGioHang.Name = "grdGioHang";
            this.grdGioHang.RowHeadersWidth = 51;
            this.grdGioHang.RowTemplate.Height = 24;
            this.grdGioHang.Size = new System.Drawing.Size(305, 619);
            this.grdGioHang.TabIndex = 2;
            // 
            // pnlThanhToanBottom
            // 
            this.pnlThanhToanBottom.Controls.Add(this.btnXoaKhoiGio);
            this.pnlThanhToanBottom.Controls.Add(this.btnThanhToan);
            this.pnlThanhToanBottom.Controls.Add(this.lblTongTien);
            this.pnlThanhToanBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThanhToanBottom.Location = new System.Drawing.Point(0, 648);
            this.pnlThanhToanBottom.Name = "pnlThanhToanBottom";
            this.pnlThanhToanBottom.Size = new System.Drawing.Size(305, 146);
            this.pnlThanhToanBottom.TabIndex = 1;
            // 
            // btnXoaKhoiGio
            // 
            this.btnXoaKhoiGio.BackColor = System.Drawing.Color.Pink;
            this.btnXoaKhoiGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoiGio.ForeColor = System.Drawing.Color.Blue;
            this.btnXoaKhoiGio.Location = new System.Drawing.Point(106, 77);
            this.btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            this.btnXoaKhoiGio.Size = new System.Drawing.Size(196, 40);
            this.btnXoaKhoiGio.TabIndex = 2;
            this.btnXoaKhoiGio.Text = "Xóa món đã chọn ❌";
            this.btnXoaKhoiGio.UseVisualStyleBackColor = false;
            this.btnXoaKhoiGio.Click += new System.EventHandler(this.btnXoaKhoiGio_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Yellow;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Red;
            this.btnThanhToan.Location = new System.Drawing.Point(6, 28);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(237, 43);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "THANH TOÁN NGAY";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(0, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(158, 25);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng cộng: 0 đ";
            // 
            // lblGioHangHeader
            // 
            this.lblGioHangHeader.AutoSize = true;
            this.lblGioHangHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGioHangHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioHangHeader.Location = new System.Drawing.Point(0, 0);
            this.lblGioHangHeader.Name = "lblGioHangHeader";
            this.lblGioHangHeader.Size = new System.Drawing.Size(138, 29);
            this.lblGioHangHeader.TabIndex = 0;
            this.lblGioHangHeader.Text = "GIỎ HÀNG";
            // 
            // flpDanhSachSach
            // 
            this.flpDanhSachSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDanhSachSach.AutoScroll = true;
            this.flpDanhSachSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flpDanhSachSach.Controls.Add(this.pictureBox2);
            this.flpDanhSachSach.Location = new System.Drawing.Point(206, 60);
            this.flpDanhSachSach.Name = "flpDanhSachSach";
            this.flpDanhSachSach.Size = new System.Drawing.Size(665, 791);
            this.flpDanhSachSach.TabIndex = 3;
            this.flpDanhSachSach.Paint += new System.Windows.Forms.PaintEventHandler(this.flpDanhSachSach_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(665, 365);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnlGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 854);
            this.Controls.Add(this.flpDanhSachSach);
            this.Controls.Add(this.pnlKhuVucGioHang);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "pnlGioHang";
            this.Text = "frmBanHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pnlGioHang_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlThanhTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiemIcon)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            this.pnlKhuVucGioHang.ResumeLayout(false);
            this.pnlKhuVucGioHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGioHang)).EndInit();
            this.pnlThanhToanBottom.ResumeLayout(false);
            this.pnlThanhToanBottom.PerformLayout();
            this.flpDanhSachSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtTimKiemThongMinh;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Label lblDanhMucHeader;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button btnKinhTe;
        private System.Windows.Forms.Button btnVanHoc;
        private System.Windows.Forms.Button btnManga;
        private System.Windows.Forms.Button btnNgoaiNgu;
        private System.Windows.Forms.Button btnKyNangSong;
        private System.Windows.Forms.Panel pnlKhuVucGioHang;
        private System.Windows.Forms.Label lblGioHangHeader;
        private System.Windows.Forms.Panel pnlThanhToanBottom;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.DataGridView grdGioHang;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSachSach;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.ComboBox cboNgonNgu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnNauAn;
        private System.Windows.Forms.Button btnAmNhac;
        private System.Windows.Forms.Button btnTreEm;
        private System.Windows.Forms.Button btnThamHiem;
        private System.Windows.Forms.Button btnThuCong;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel pnlThanhTimKiem;
        private System.Windows.Forms.PictureBox picTimKiemIcon;
        private System.Windows.Forms.Button btnGiamGia;
        private System.Windows.Forms.Button btnXoaKhoiGio;
    }
}