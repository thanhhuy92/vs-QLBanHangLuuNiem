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
    public partial class frmDMKhachHang : Form
    {
        public frmDMKhachHang()
        {
            InitializeComponent();
        }

        DataTable tbkhachhang;

        private void loaddgv()
        {
            string sql = "select * from KHACH";

            tbkhachhang = ketnoi.getdata(sql);

            dgvkhachhang.DataSource = tbkhachhang;

            dgvkhachhang.Columns[0].HeaderText = "Mã KH";

            dgvkhachhang.Columns[1].HeaderText = "Tên Khách Hàng";

            dgvkhachhang.Columns[2].HeaderText = "Địa Chỉ";

            dgvkhachhang.Columns[3].HeaderText = "Điện Thoại";

            dgvkhachhang.Columns[0].Width = 80;

            dgvkhachhang.Columns[1].Width = 150;

            dgvkhachhang.Columns[2].Width = 180;

            dgvkhachhang.Columns[3].Width = 100;
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvkhachhang_Click(object sender, EventArgs e)
        {
            txtmakhach.Text = dgvkhachhang.CurrentRow.Cells[0].Value.ToString();

            txttenkhach.Text = dgvkhachhang.CurrentRow.Cells[1].Value.ToString();

            txtdiachi.Text = dgvkhachhang.CurrentRow.Cells[2].Value.ToString();

            mskdienthoai.Text = dgvkhachhang.CurrentRow.Cells[3].Value.ToString();

            btnxoa.Enabled = true;

            btnsua.Enabled = true;

            btnthem.Enabled = false;

            btnluu.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmakhach.Clear();

            txttenkhach.Clear();

            txtdiachi.Clear();

            mskdienthoai.Clear();

            txtmakhach.Enabled = true;

            btnxoa.Enabled = false;

            btnsua.Enabled = false;

            btnluu.Enabled = true;

            btnthem.Enabled = false;

            btnboqua.Enabled = true;

            dgvkhachhang.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string makh = txtmakhach.Text;

            string sql1 = "SELECT * FROM KHACH WHERE KHACH.MaKhach='" + makh + "'";

            string sql = "INSERT INTO KHACH (MaKhach,TenKhach,DiaChi,DienThoai) VALUES('" + txtmakhach.Text + "','" + txttenkhach.Text + "','" + txtdiachi.Text + "','" + mskdienthoai.Text + "')";

            if (txtmakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã khách.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtmakhach.Focus();

                return;
            }
            else if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên khách.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txttenkhach.Focus();

                return;
            }
            else if(txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtdiachi.Focus();

                return;
            }
            else if (mskdienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mskdienthoai.Focus();

                return;
            }
            else if (ketnoi.ktratrung(sql1))
            {
                MessageBox.Show("Mã [ " + txtmakhach.Text + " ] đã có", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtmakhach.Clear();

                txtmakhach.Focus();
            }
            else
            {
                DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn thêm [ Khách Hàng: " + txttenkhach.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (thanhcong == DialogResult.OK)
                {
                    ketnoi.runsql(sql);

                    MessageBox.Show("Thêm [ Khách Hàng : " + txttenkhach.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvkhachhang.Enabled = true;

                txtmakhach.Enabled = false;

                txtmakhach.Clear();

                txttenkhach.Clear();

                txtdiachi.Clear();

                mskdienthoai.Clear();

                btnthem.Enabled = true;

                btnluu.Enabled = false;

                btnboqua.Enabled = false;

                loaddgv();
            } 
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM KHACH WHERE MaKhach='" + txtmakhach.Text + "'";

            DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn xóa [ Khách Hàng : " + txttenkhach.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (thanhcong == DialogResult.OK)
            {
                ketnoi.runsql(sql);

                MessageBox.Show("Xóa [ Khách Hàng : " + txttenkhach.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtmakhach.Clear();

            txttenkhach.Clear();

            txtdiachi.Clear();

            mskdienthoai.Clear();

            btnthem.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnboqua.Enabled = false;

            loaddgv();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE KHACH SET TenKhach= '" + txttenkhach.Text + "',DiaChi='" + txtdiachi.Text + "',DienThoai='" + mskdienthoai.Text + "' WHERE MaKhach= '" + txtmakhach.Text + "'";

            DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn sửa [ Khách Hàng : " + txttenkhach.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (thanhcong == DialogResult.OK)
            {
                ketnoi.runsql(sql);

                MessageBox.Show("Sửa [ Khách Hàng : " + txttenkhach.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtmakhach.Clear();

            txttenkhach.Clear();

            txtdiachi.Clear();

            mskdienthoai.Clear();

            btnboqua.Enabled = false;

            btnthem.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            loaddgv();
        }

        private void frmDMKhachhang_Load(object sender, EventArgs e)
        {
            loaddgv();

            txtmakhach.Enabled = false;

            txtmakhach.Clear();

            txttenkhach.Clear();

            txtdiachi.Clear();

            mskdienthoai.Clear();

            btnluu.Enabled = false;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnboqua.Enabled = false;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            dgvkhachhang.Enabled = true;

            txtmakhach.Enabled = false;

            txtmakhach.Clear();

            txttenkhach.Clear();

            txtdiachi.Clear();

            mskdienthoai.Clear();

            btnluu.Enabled = false;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnthem.Enabled = true;

            btnboqua.Enabled = true;
        }
    }
}
