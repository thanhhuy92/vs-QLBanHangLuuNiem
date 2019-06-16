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
    public partial class frmDMNhanVien : Form
    {
        public frmDMNhanVien()
        {
            InitializeComponent();
        }

        String gioitinh;

        DataTable tbNhanVien;

        private void loadgridview()
        {
            string sql = "Select* from NHANVIEN";

            tbNhanVien = ketnoi.getdata(sql);

            dgvnhanvien.DataSource = tbNhanVien;

            dgvnhanvien.Columns[0].HeaderText = "Mã NV";

            dgvnhanvien.Columns[1].HeaderText = "Tên NV";

            dgvnhanvien.Columns[2].HeaderText = "Giới Tính";

            dgvnhanvien.Columns[3].HeaderText = "Địa Chỉ";

            dgvnhanvien.Columns[4].HeaderText = "Điện Thoại";

            dgvnhanvien.Columns[5].HeaderText = "Ngày Sinh";

            dgvnhanvien.Columns[0].Width = 70;

            dgvnhanvien.Columns[1].Width = 100;

            dgvnhanvien.Columns[2].Width = 75;

            dgvnhanvien.Columns[3].Width = 120;

            dgvnhanvien.Columns[4].Width = 90;

            dgvnhanvien.Columns[5].Width = 90;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDMNhanVien_Load(object sender, EventArgs e)
        {
            loadgridview();

            txtmanhanvien.Enabled = false;

            btnluu.Enabled = false;

            btnboqua.Enabled = false;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

        }

        
        private void dgvnhanvien_Click(object sender, EventArgs e)
        {
            if(tbNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu!!!");

                return;
            }

            txtmanhanvien.Text = dgvnhanvien.CurrentRow.Cells[0].Value.ToString();

            txttennhanvien.Text = dgvnhanvien.CurrentRow.Cells[1].Value.ToString();

            if (dgvnhanvien.CurrentRow.Cells[2].Value.ToString() == "Nam")
            {
                chkgioitinh.Checked = true;
            }
            else
            {
                chkgioitinh.Checked = false;
            }

            txtdiachi.Text = dgvnhanvien.CurrentRow.Cells[3].Value.ToString();

            mskdienthoai.Text = dgvnhanvien.CurrentRow.Cells[4].Value.ToString();

            dtpngaysinh.Text = dgvnhanvien.CurrentRow.Cells[5].Value.ToString();

            btnthem.Enabled = false;

            btnluu.Enabled = false;

            btnsua.Enabled = true;

            btnxoa.Enabled = true;

            btnboqua.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            txtmanhanvien.Enabled = true;

            txtmanhanvien.Focus();

            txtmanhanvien.Clear();

            txttennhanvien.Clear();

            txtdiachi.Clear();

            mskdienthoai.Clear();

            dgvnhanvien.Enabled = false;

            btnboqua.Enabled = true;

            btnthem.Enabled = false;
        }


        private void btnluu_Click_1(object sender, EventArgs e)
        {
            if (chkgioitinh.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }


            string sql = "INSERT INTO NHANVIEN (MaNhanVien,TenNhanVien,GioiTinh,DiaChi,DienThoai,NgaySinh) VALUES('" + txtmanhanvien.Text + "','" + txttennhanvien.Text + "','" + gioitinh + "','" + txtdiachi.Text + "','" + mskdienthoai.Text + "','" + dtpngaysinh.Value.ToString("yyyy/MM/dd") + "')";

            string sql1 = "SELECT MaNhanVien FROM NHANVIEN WHERE NHANVIEN.MaNhanVien='" + txtmanhanvien.Text.Trim() + "'";

            if (txtmanhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!!!");
                return;
            }
            else if (txttennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên!!!");
                return;
            }
            else if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ!!!");
                return;
            }
            else if (mskdienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại!!!");
                return;
            }
            else if (ketnoi.ktratrung(sql1) == true)
            {
                MessageBox.Show("Mã [ " + txtmanhanvien.Text + " ] đã có", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtmanhanvien.Clear();

                txtmanhanvien.Focus();
            }
            else
            {
                DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn thêm [ Nhân Viên: " + txttennhanvien.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (thanhcong == DialogResult.OK)
                {
                    ketnoi.runsql(sql);

                    MessageBox.Show("Thêm [ Nhân Viên : " + txttennhanvien.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            btnluu.Enabled = false;

            btnboqua.Enabled = false;

            btnthem.Enabled = true;

            dgvnhanvien.Enabled = true;

            txtmanhanvien.Enabled = false;

            txtmanhanvien.Clear();

            txttennhanvien.Clear();

            txtdiachi.Clear();

            mskdienthoai.Clear();

            loadgridview();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM NHANVIEN WHERE MaNhanVien='" + txtmanhanvien.Text + "'";

            if(tbNhanVien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa");
                return;
            }
            else
            {
                DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn xóa [ Nhân Viên : " + txttennhanvien.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (thanhcong == DialogResult.OK)
                {
                    ketnoi.runsql(sql);

                    MessageBox.Show("Xóa [ Nhân Viên : " + txttennhanvien.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            txtmanhanvien.Enabled = false;

            txtmanhanvien.Clear();

            txttennhanvien.Clear();

            txtdiachi.Clear();

            mskdienthoai.Clear();

            btnthem.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnboqua.Enabled = false;

            loadgridview();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (chkgioitinh.Checked == true)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nu";
            }
            string sql = "UPDATE NHANVIEN SET TenNhanVien= '" + txttennhanvien.Text + "',GioiTinh='" + gioitinh + "',DiaChi='" + txtdiachi.Text + "',DienThoai='" + mskdienthoai.Text + "',NgaySinh='" + dtpngaysinh.Value.ToString("yyyy/MM/dd") + "' WHERE MaNhanVien= '" + txtmanhanvien.Text + "'";

            DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn sửa [ Nhân Viên : " + txttennhanvien.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (thanhcong == DialogResult.OK)
            {
                ketnoi.runsql(sql);

                MessageBox.Show("Sửa [ Nhân Viên : " + txttennhanvien.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtmanhanvien.Enabled = false;

            txtmanhanvien.Clear();

            txttennhanvien.Clear();

            txtdiachi.Clear();

            mskdienthoai.Clear();

            btnthem.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnboqua.Enabled = false;

            loadgridview();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            txtmanhanvien.Enabled =false;

            txtmanhanvien.Clear();

            txttennhanvien.Clear();

            txtdiachi.Clear();

            mskdienthoai.Clear();

            btnthem.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnluu.Enabled = false;

            btnboqua.Enabled = false;

            dgvnhanvien.Enabled = true;
        }
    }

}
