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
    public partial class frmLogin : Form
    {
        string taiKhoanCuaKhach = "admin";
        string matKhauCuaKhach = "123";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == taiKhoanCuaKhach && txtMatKhau.Text == matKhauCuaKhach)
            {
                frmTrangChu f = new frmTrangChu();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai rồi nha!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "Nhập số điện thoại hoặc email";
            txtTaiKhoan.ForeColor = Color.Gray;

            txtMatKhau.Text = "Nhập mật khẩu";
            txtMatKhau.ForeColor = Color.Gray;
            txtMatKhau.UseSystemPasswordChar = false;

            txtDangKyTaiKhoan.Text = "Nhập số điện thoại hoặc email";
            txtDangKyTaiKhoan.ForeColor = Color.Gray;

            txtDangKyMatKhau.Text = "Nhập mật khẩu";
            txtDangKyMatKhau.ForeColor = Color.Gray;
            txtDangKyMatKhau.UseSystemPasswordChar = false;

            txtXacNhanMatKhau.Text = "Nhập lại mật khẩu";
            txtXacNhanMatKhau.ForeColor = Color.Gray;
            txtXacNhanMatKhau.UseSystemPasswordChar = false;

            pnlDangKy.Location = pnlDangNhap.Location;
        }

        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Nhập số điện thoại hoặc email")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Text = "Nhập số điện thoại hoặc email";
                txtTaiKhoan.ForeColor = Color.Gray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Nhập mật khẩu";
                txtMatKhau.ForeColor = Color.Gray;
                txtMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void txtDangKyTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtDangKyTaiKhoan.Text == "Nhập số điện thoại hoặc email")
            {
                txtDangKyTaiKhoan.Text = "";
                txtDangKyTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txtDangKyTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtDangKyTaiKhoan.Text == "")
            {
                txtDangKyTaiKhoan.Text = "Nhập số điện thoại hoặc email";
                txtDangKyTaiKhoan.ForeColor = Color.Gray;
            }
        }

        private void txtDangKyMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtDangKyMatKhau.Text == "Nhập mật khẩu")
            {
                txtDangKyMatKhau.Text = "";
                txtDangKyMatKhau.ForeColor = Color.Black;
                txtDangKyMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtDangKyMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtDangKyMatKhau.Text == "")
            {
                txtDangKyMatKhau.Text = "Nhập mật khẩu";
                txtDangKyMatKhau.ForeColor = Color.Gray;
                txtDangKyMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void txtXacNhanMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.Text == "Nhập lại mật khẩu")
            {
                txtXacNhanMatKhau.Text = "";
                txtXacNhanMatKhau.ForeColor = Color.Black;
                txtXacNhanMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txtXacNhanMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtXacNhanMatKhau.Text == "")
            {
                txtXacNhanMatKhau.Text = "Nhập lại mật khẩu";
                txtXacNhanMatKhau.ForeColor = Color.Gray;
                txtXacNhanMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void pnlGachChan_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            lblDangNhap.Font = new Font(lblDangNhap.Font, FontStyle.Bold);
            lblDangKy.Font = new Font(lblDangKy.Font, FontStyle.Regular);

            pnlGachChan.Left = lblDangNhap.Left;
            pnlGachChan.Width = lblDangNhap.Width;

            pnlDangNhap.Visible = true;
            pnlDangKy.Visible = false;
        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            lblDangKy.Font = new Font(lblDangKy.Font, FontStyle.Bold);
            lblDangNhap.Font = new Font(lblDangNhap.Font, FontStyle.Regular);

            pnlGachChan.Left = lblDangKy.Left;
            pnlGachChan.Width = lblDangKy.Width;

            pnlDangKy.Visible = true;
            pnlDangNhap.Visible = false;
        }

        private void btnDangKy_Enter(object sender, EventArgs e)
        {
        }

        private void lblDangKy_Enter(object sender, EventArgs e)
        {
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            taiKhoanCuaKhach = txtDangKyTaiKhoan.Text;
            matKhauCuaKhach = txtDangKyMatKhau.Text;

            MessageBox.Show("Chúc mừng bạn đã Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnlDangKy_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}