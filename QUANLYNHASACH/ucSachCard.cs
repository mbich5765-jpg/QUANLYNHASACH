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
    public partial class ucSachCard : UserControl
    {
        public string MaSachDangChon;
        public string NhaXB;
        public string NamXB;
        public string NoiDungSach;
        public string DanhGiaSao;
        public string TenSachGoc;

        public void DoiThongTin(string maSach, string tenSach, int giaTien, string nxb, string nam, string noiDung, string sao)
        {
            MaSachDangChon = maSach;
            lblTenSach.Text = tenSach;
            lblGiaTien.Text = giaTien.ToString("N0") + " đ";

            TenSachGoc = tenSach;

            NhaXB = nxb;
            NamXB = nam;
            NoiDungSach = noiDung;
            DanhGiaSao = sao;

            try
            {
                string duongDan = Application.StartupPath + @"\HinhAnh\" + maSach + ".jpg";
                picBiaSach.Image = Image.FromFile(duongDan);
            }
            catch
            {
                picBiaSach.BackColor = System.Drawing.Color.LightGray;
                picBiaSach.Image = null;
            }
        }

        public ucSachCard()
        {
            InitializeComponent();
        }

        private void lblTenSach_Click(object sender, EventArgs e)
        {
        }

        private void picBiaSach_Click(object sender, EventArgs e)
        {
            string thongTin = "📖 THÔNG TIN CHI TIẾT SÁCH 📖\n\n" +
                              "🔖 Mã sách: " + MaSachDangChon + "\n" +
                              "📚 Tên sách: " + lblTenSach.Text + "\n" +
                              "💰 Giá bán: " + lblGiaTien.Text + "\n" +
                              "🏢 Nhà xuất bản: " + NhaXB + "\n" +
                              "📅 Năm sản xuất: " + NamXB + "\n" +
                              "⭐ Đánh giá: " + DanhGiaSao + "\n\n" +
                              "📝 Nội dung: " + NoiDungSach;

            MessageBox.Show(thongTin, "Chi tiết", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            pnlGioHang formChinh = (pnlGioHang)this.FindForm();

            string chuGiaTien = lblGiaTien.Text.Replace(" đ", "").Replace(",", "").Replace(".", "");
            int giaTienThat = int.Parse(chuGiaTien);

            formChinh.ThemSachVaoGio(MaSachDangChon, lblTenSach.Text, giaTienThat);
        }
    }
}