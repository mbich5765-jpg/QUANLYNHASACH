using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYNHASACH
{
    public partial class frmQuanLyKhoSach : Form
    {
        List<Sach> danhSachKho = new List<Sach>();

        public frmQuanLyKhoSach()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaSach.Text;
            string ten = txtTenSach.Text;
            string theLoai = cboTheLoai.Text;
            int gia = int.Parse(txtGiaTien.Text);

            Sach sachMoi = new Sach(ma, ten, theLoai, gia);

            danhSachKho.Add(sachMoi);

            grdDanhSach.DataSource = null;
            grdDanhSach.DataSource = danhSachKho;
            XoaTrang();
        }

        private void frmQuanLyKhoSach_Load(object sender, EventArgs e)
        {
            cboTheLoai.Items.Clear();

            string[] cacTheLoai = { "Văn học", "Kinh tế", "Kỹ năng sống", "Sách Ngoại ngữ", "Manga - Comic",
                                    "Thám hiểm", "Sách trẻ em", "Sách âm nhạc", "Sách nấu ăn", "Sách thủ công" };

            foreach (string loai in cacTheLoai)
            {
                cboTheLoai.Items.Add(loai);
            }

            if (cboTheLoai.Items.Count > 0)
            {
                cboTheLoai.SelectedIndex = 0;
            }
        }

        private void XoaTrang()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtGiaTien.Clear();

            cboTheLoai.SelectedIndex = 0;

            txtMaSach.Focus();
        }

        private void grdDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dongDuocChon = grdDanhSach.Rows[e.RowIndex];

                txtMaSach.Text = dongDuocChon.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = dongDuocChon.Cells["TenSach"].Value.ToString();
                cboTheLoai.Text = dongDuocChon.Cells["TheLoai"].Value.ToString();
                txtGiaTien.Text = dongDuocChon.Cells["GiaTien"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (grdDanhSach.CurrentRow != null)
            {
                int viTri = grdDanhSach.CurrentRow.Index;

                danhSachKho.RemoveAt(viTri);

                grdDanhSach.DataSource = null;
                grdDanhSach.DataSource = danhSachKho;
                XoaTrang();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (grdDanhSach.CurrentRow != null)
            {
                int viTri = grdDanhSach.CurrentRow.Index;

                danhSachKho[viTri].MaSach = txtMaSach.Text;
                danhSachKho[viTri].TenSach = txtTenSach.Text;
                danhSachKho[viTri].TheLoai = cboTheLoai.Text;
                danhSachKho[viTri].GiaTien = int.Parse(txtGiaTien.Text);

                grdDanhSach.DataSource = null;
                grdDanhSach.DataSource = danhSachKho;
                XoaTrang();
            }
        }
    }
}