using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangLuuNiem
{
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        DataTable tbhoadon;

        private void loadhd()
        {
            string sql = "select * from HDBAN where HDBAN.MaHDBan='" + txtmahoadon.Text + "'";

            tbhoadon = ketnoi.getdata(sql);

            //txtngayban.DataBindings.Add("Text","MaHDBan");
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            cmbmakhachhang.SelectedItem = frmTimHDBan.makhach.MaKhach;

            txtmahoadon.Text = frmTimHDBan.mahd.MaHDBan;

            loadhd();
        }
    }
}
