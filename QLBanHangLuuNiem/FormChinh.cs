using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBanHangLuuNiem
{
    public partial class frmMain : System.Windows.Forms.Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void tậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ketnoi.connect();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu formcl = new frmDMChatLieu();
            formcl.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien formnv = new frmDMNhanVien();
            formnv.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHang formhh = new frmDMHang();
            formhh.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang formkh = new frmDMKhachHang();
            formkh.Show();
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimHDBan formthdban = new frmTimHDBan();
            formthdban.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan formhdban = new frmHoaDonBan();
            formhdban.Show();
        }
    }
}
