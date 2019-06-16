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
    public partial class frmTimHDBan : Form
    {
        public frmTimHDBan()
        {
            InitializeComponent();
        }

        DataTable tbHoaDonBan;

        public class makhach
        {
            static public string MaKhach;
        }

        public class mahd
        {
            static public string MaHDBan;
        }

        private void loaddgv()
        {
            string sql = "select * from HDBAN where MaNhanVien LIKE '%" + txtmanhanvien.Text.Trim() + "%'";

            tbHoaDonBan = ketnoi.getdata(sql);

            dgvhoadon.DataSource = tbHoaDonBan;

            dgvhoadon.Columns[0].HeaderText = "Mã HD Bán";

            dgvhoadon.Columns[1].HeaderText = "Mã NV";

            dgvhoadon.Columns[2].HeaderText = "Ngày Bán";

            dgvhoadon.Columns[3].HeaderText = "Mã Khách";

            dgvhoadon.Columns[4].HeaderText = "Tổng Tiền";
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimHDBan_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dgvhoadon_Click(object sender, EventArgs e)
        {
            


            txtmahoadon.Text = dgvhoadon.CurrentRow.Cells[0].Value.ToString();

            txtmanhanvien.Text = dgvhoadon.CurrentRow.Cells[1].Value.ToString();

            string date = dgvhoadon.CurrentRow.Cells[2].Value.ToString();

            DateTime dtdate = DateTime.Parse(date);

            string strthang = dtdate.Month.ToString();

            txtthang.Text = strthang;

            string strnam = dtdate.Year.ToString();

            txtnam.Text = strnam;


            txtmakhachhang.Text = dgvhoadon.CurrentRow.Cells[3].Value.ToString();

            txttongtien.Text = dgvhoadon.CurrentRow.Cells[4].Value.ToString();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            txtmahoadon.Clear();

            txtnam.Clear();

            txtthang.Clear();

            txtmakhachhang.Clear();

            txttongtien.Clear();

            loaddgv();
        }

        private void dgvhoadon_DoubleClick(object sender, EventArgs e)
        {
            makhach.MaKhach = dgvhoadon.CurrentRow.Cells[1].Value.ToString();

            mahd.MaHDBan = dgvhoadon.CurrentRow.Cells[0].Value.ToString();

            frmHoaDonBan formhdb = new frmHoaDonBan();

            formhdb.Show();
        }
    }
}
