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
    public partial class frmBaoCao : Form
    {
        public static int Ketsat_TongDoanhThu = 0;
        public static int Ketsat_TongSoSach = 0;

        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void pnlDoanhThu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            lblTongTienBanDuoc.Text = Ketsat_TongDoanhThu.ToString("N0") + " đ";
            lblTongSoLuongSach.Text = Ketsat_TongSoSach.ToString("N0") + " cuốn";

            lblTienThangNay.Text = "32,400,000 đ";
            lblTongDanhGia.Text = "4,285 lượt";
            lblTongKhachHang.Text = "840 người";
            lblTongTonKho.Text = "5,200 cuốn";
        }
    }
}