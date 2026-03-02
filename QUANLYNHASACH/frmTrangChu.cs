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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void mnuHeThongDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void mnuQuanLySach_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoSach f = new frmQuanLyKhoSach();
            f.ShowDialog();
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            pnlGioHang formBH = new pnlGioHang();
            formBH.ShowDialog();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormBaoCao();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MoFormBaoCao();
        }

        private void MoFormBaoCao()
        {
            frmBaoCao formBaoCao = new frmBaoCao();
            formBaoCao.StartPosition = FormStartPosition.CenterScreen;
            formBaoCao.ShowDialog();
        }
    }
}