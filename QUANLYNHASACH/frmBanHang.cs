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
    public partial class pnlGioHang : Form
    {
        public pnlGioHang()
        {
            InitializeComponent();
        }

        int tongTienGioHang = 0;

        public static Dictionary<string, int> TonKho = new Dictionary<string, int>();

        public void ThemSachVaoGio(string maSach, string tenSach, int giaTien)
        {
            if (dgvGioHang.Columns.Count == 0)
            {
                dgvGioHang.Columns.Add("Ma", "Mã");
                dgvGioHang.Columns.Add("Ten", "Tên sách");
                dgvGioHang.Columns.Add("SoLuong", "SL");
                dgvGioHang.Columns.Add("ThanhTien", "Thành tiền");

                dgvGioHang.Columns[0].Width = 40;
                dgvGioHang.Columns[2].Width = 40;
                dgvGioHang.Columns[3].Width = 90;
                dgvGioHang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            string tenSachGoc = tenSach.Replace("🔥 SALE -30% | ", "");

            if (TonKho.ContainsKey(tenSachGoc))
            {
                int soLuongKhoDangCo = TonKho[tenSachGoc];

                if (soLuongKhoDangCo <= 0)
                {
                    MessageBox.Show("Rất tiếc! Sách '" + tenSachGoc + "' đã được bán sạch kho!", "Hết hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int soLuongDangTrongGio = 0;
                foreach (DataGridViewRow row in dgvGioHang.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == tenSach)
                    {
                        soLuongDangTrongGio = int.Parse(row.Cells[2].Value.ToString());
                        break;
                    }
                }

                if (soLuongDangTrongGio + 1 > soLuongKhoDangCo)
                {
                    MessageBox.Show("Kho chỉ còn đúng " + soLuongKhoDangCo + " cuốn thôi! Bạn không thể mua lố số lượng được nha.", "Cảnh báo tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            bool daCoTrongGio = false;

            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == maSach)
                {
                    int soLuongCu = int.Parse(row.Cells[2].Value.ToString());
                    row.Cells[2].Value = soLuongCu + 1;

                    int thanhTienMoi = (soLuongCu + 1) * giaTien;
                    row.Cells[3].Value = thanhTienMoi.ToString("N0") + " đ";

                    daCoTrongGio = true;
                    break;
                }
            }

            if (daCoTrongGio == false)
            {
                dgvGioHang.Rows.Add(maSach, tenSach, 1, giaTien.ToString("N0") + " đ");
            }

            tongTienGioHang += giaTien;
            lblTongTien.Text = "Tổng cộng: " + tongTienGioHang.ToString("N0") + " đ";
        }

        private void LoadDanhSachSach(string theLoaiCanTim = "Tất cả")
        {
            flpDanhSachSach.Controls.Clear();
            flpDanhSachSach.SuspendLayout();

            string[] cacTheLoai = { "Văn học", "Kinh tế", "Kỹ năng sống", "Sách Ngoại ngữ", "Manga - Comic",
                                    "Thám hiểm", "Sách trẻ em", "Sách âm nhạc", "Sách nấu ăn", "Sách thủ công" };

            foreach (string loai in cacTheLoai)
            {
                if (theLoaiCanTim == "Tất cả" || theLoaiCanTim == loai || theLoaiCanTim == "Deal Hot")
                {
                    for (int i = 1; i <= 40; i++)
                    {
                        bool laSachGiamGia = (i % 5 == 0);

                        if (theLoaiCanTim == "Deal Hot" && laSachGiamGia == false)
                        {
                            continue;
                        }

                        string tenSachGoc = (loai.StartsWith("Sách") ? loai : "Sách " + loai) + " - Tập " + i;
                        if (!TonKho.ContainsKey(tenSachGoc))
                        {
                            TonKho.Add(tenSachGoc, 5);
                        }

                        ucSachCard theSach = new ucSachCard();

                        string tenSach = tenSachGoc;
                        int giaTien = 50000 + (i * 5000);

                        if (theLoaiCanTim == "Deal Hot")
                        {
                            giaTien = (int)(giaTien * 0.7);
                            tenSach = "🔥 SALE -30% | " + tenSach;
                        }

                        string nhaXuatBan = (loai == "Manga - Comic") ? "NXB Kim Đồng" : "NXB Trẻ";
                        string namXuatBan = "202" + (i % 6);
                        string danhGia = (i % 2 == 0) ? "⭐⭐⭐⭐⭐" : "⭐⭐⭐⭐ rưỡi";

                        int tonKhoHienTai = TonKho[tenSachGoc];
                        string noiDung = "Kho hiện còn: " + tonKhoHienTai + " cuốn.\nCuốn sách " + tenSach + " là một siêu phẩm xoay quanh chủ đề " + loai + ". Nội dung cực kỳ lôi cuốn, mang lại nhiều kiến thức thực tế và giải trí thú vị. Đọc là cuốn không dứt ra được!";

                        int maHinh = (i <= 20) ? i : (i - 20);

                        theSach.DoiThongTin("S" + maHinh, tenSach, giaTien, nhaXuatBan, namXuatBan, noiDung, danhGia);

                        flpDanhSachSach.Controls.Add(theSach);
                    }
                }
            }

            pictureBox2.Margin = new Padding(0);
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Width = flpDanhSachSach.ClientSize.Width;
            pictureBox2.Height = 450;
            flpDanhSachSach.Controls.Add(pictureBox2);

            flpDanhSachSach.ResumeLayout();
        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e) { }
        private void pnlHeader_Paint(object sender, PaintEventArgs e) { }
        private void pnlKhuVucGioHang_Paint(object sender, PaintEventArgs e) { }

        private void pnlGioHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachSach("Tất cả");
        }

        private void btnTatCa_Click(object sender, EventArgs e) { LoadDanhSachSach("Tất cả"); }
        private void btnVanHoc_Click(object sender, EventArgs e) { LoadDanhSachSach("Văn học"); }
        private void btnKinhTe_Click(object sender, EventArgs e) { LoadDanhSachSach("Kinh tế"); }
        private void btnManga_Click(object sender, EventArgs e) { LoadDanhSachSach("Manga - Comic"); }
        private void btnKyNangSong_Click(object sender, EventArgs e) { LoadDanhSachSach("Kỹ năng sống"); }
        private void btnNgoaiNgu_Click(object sender, EventArgs e) { LoadDanhSachSach("Sách Ngoại ngữ"); }

        private void flpDanhSachSach_Paint(object sender, PaintEventArgs e) { }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemThongMinh.Text.ToLower().Trim();
            flpDanhSachSach.SuspendLayout();

            foreach (Control obj in flpDanhSachSach.Controls)
            {
                if (obj is ucSachCard)
                {
                    ucSachCard theSach = (ucSachCard)obj;
                    string tenCuaSach = theSach.TenSachGoc.ToLower();
                    bool canHienThi = (tuKhoa == "" || tenCuaSach.Contains(tuKhoa));

                    if (theSach.Visible != canHienThi)
                    {
                        theSach.Visible = canHienThi;
                    }
                }
            }

            flpDanhSachSach.ResumeLayout();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (tongTienGioHang == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn sách trước khi thanh toán nha.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmThanhToan fThanhToan = new frmThanhToan();
            fThanhToan.ShowDialog();

            frmBaoCao.Ketsat_TongDoanhThu += tongTienGioHang;

            int tongSoSachMua = 0;
            foreach (DataGridViewRow row in dgvGioHang.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    string tenTrongGio = row.Cells[1].Value.ToString();
                    string tenGoc = tenTrongGio.Replace("🔥 SALE -30% | ", "");
                    int soLuongMua = int.Parse(row.Cells[2].Value.ToString());

                    tongSoSachMua += soLuongMua;

                    if (TonKho.ContainsKey(tenGoc))
                    {
                        TonKho[tenGoc] -= soLuongMua;
                    }
                }
            }
            frmBaoCao.Ketsat_TongSoSach += tongSoSachMua;

            dgvGioHang.Rows.Clear();
            tongTienGioHang = 0;
            lblTongTien.Text = "Tổng cộng: 0 đ";
        }

        private void DoiNgonNgu(string ngonNgu)
        {
            if (ngonNgu.Contains("Anh"))
            {
                btnTatCa.Text = "All Books";
                btnVanHoc.Text = "Literature";
                btnKinhTe.Text = "Economics";
                btnKyNangSong.Text = "Life Skills";
                btnNgoaiNgu.Text = "Foreign Books";
                btnManga.Text = "Manga - Comics";
                btnThamHiem.Text = "Adventure Books";
                btnTreEm.Text = "Children's Books";
                btnAmNhac.Text = "Music Books";
                btnNauAn.Text = "Cookbooks";
                btnThuCong.Text = "Craft Books";
                btnGiamGia.Text = "Hot Deals 🔥";
                btnThanhToan.Text = "CHECKOUT NOW";
            }
            else
            {
                btnTatCa.Text = "Tất cả sách";
                btnVanHoc.Text = "Văn học";
                btnKinhTe.Text = "Kinh tế";
                btnKyNangSong.Text = "Kỹ năng sống";
                btnNgoaiNgu.Text = "Sách Ngoại ngữ";
                btnManga.Text = "Manga - Comic";
                btnThamHiem.Text = "Thám hiểm";
                btnTreEm.Text = "Sách trẻ em";
                btnAmNhac.Text = "Sách âm nhạc";
                btnNauAn.Text = "Sách nấu ăn";
                btnThuCong.Text = "Sách thủ công";
                btnGiamGia.Text = "Deal Hot 🔥";
                btnThanhToan.Text = "THANH TOÁN NGAY";
            }
        }

        private void cboNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoiNgonNgu(cboNgonNgu.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void btnThamHiem_Click(object sender, EventArgs e) { LoadDanhSachSach("Thám hiểm"); }
        private void btnTreEm_Click(object sender, EventArgs e) { LoadDanhSachSach("Sách trẻ em"); }
        private void btnAmNhac_Click(object sender, EventArgs e) { LoadDanhSachSach("Sách âm nhạc"); }
        private void btnNauAn_Click(object sender, EventArgs e) { LoadDanhSachSach("Sách nấu ăn"); }
        private void btnThuCong_Click(object sender, EventArgs e) { LoadDanhSachSach("Sách thủ công"); }
        private void btnGiamGia_Click(object sender, EventArgs e) { LoadDanhSachSach("Deal Hot"); }

        private void btnXoaKhoiGio_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count > 0 && dgvGioHang.CurrentRow != null)
            {
                if (dgvGioHang.CurrentRow.Cells[3].Value != null)
                {
                    string chuoiGia = dgvGioHang.CurrentRow.Cells[3].Value.ToString();
                    chuoiGia = chuoiGia.Replace(" đ", "").Replace(",", "").Replace(".", "");
                    int giaTienBiTru = int.Parse(chuoiGia);

                    tongTienGioHang -= giaTienBiTru;
                    dgvGioHang.Rows.RemoveAt(dgvGioHang.CurrentRow.Index);
                    lblTongTien.Text = "Tổng cộng: " + tongTienGioHang.ToString("N0") + " đ";
                }
            }
            else
            {
                MessageBox.Show("Giỏ hàng đang trống hoặc bạn chưa chọn món nào để xóa nha!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}