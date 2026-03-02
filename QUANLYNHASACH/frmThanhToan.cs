using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QUANLYNHASACH
{
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (chkDongY.Checked == false)
            {
                MessageBox.Show("Giám đốc ơi! Vui lòng tick chọn Đồng ý với điều khoản mua hàng nha!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtHoTen.Text.Trim() == "" || txtSDT.Text.Trim() == "" || txtDiaChiChiTiet.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ Họ tên, Số điện thoại và Địa chỉ để shipper còn biết đường giao nha!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thongBao = "==========================================\n";
            thongBao += "       HÓA ĐƠN NHÀ SÁCH HOA ANH ĐÀO       \n";
            thongBao += "==========================================\n\n";
            thongBao += "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "\n\n";
            thongBao += "Tên khách hàng: " + txtHoTen.Text.Trim() + "\n";
            thongBao += "Số điện thoại : " + txtSDT.Text.Trim() + "\n";
            thongBao += "Địa chỉ giao  : " + txtDiaChiChiTiet.Text.Trim() + "\n\n";
            thongBao += "CẢM ƠN QUÝ KHÁCH ĐÃ ỦNG HỘ NHÀ SÁCH CỦA CHÚNG TÔI!\n";
            thongBao += "==========================================";

            MessageBox.Show(thongBao, "Chốt Đơn Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                string duongDanDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string tenFile = "HoaDon_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                string duongDanHoanChinh = Path.Combine(duongDanDesktop, tenFile);

                File.WriteAllText(duongDanHoanChinh, thongBao);
            }
            catch
            {
            }

            this.Close();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}