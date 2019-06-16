using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLBanHangLuuNiem
{
    public partial class frmDMHang : Form
    {
        public frmDMHang()
        {
            InitializeComponent();
        }

        DataTable tbhanghoa;

        private void loaddgv()
        {
            string sql = "select * from HANG where TenHang LIKE '%" + txttenhang.Text.Trim() + "%'";

            dgvhanghoa.DataSource = ketnoi.getdata(sql);

            dgvhanghoa.Columns[0].HeaderText = "Mã Hàng";

            dgvhanghoa.Columns[1].HeaderText = "Tên Hàng";

            dgvhanghoa.Columns[2].HeaderText = "Mã Chất Liệu";

            dgvhanghoa.Columns[3].HeaderText = "Số Lượng";

            dgvhanghoa.Columns[4].HeaderText = "Đơn Giá Nhập";

            dgvhanghoa.Columns[5].HeaderText = "Đơn Giá Bán";

            dgvhanghoa.Columns[6].HeaderText = "Ảnh";

            dgvhanghoa.Columns[7].HeaderText = "Ghi Chú";

            dgvhanghoa.Columns[0].Width = 80;

            dgvhanghoa.Columns[1].Width = 120;

            dgvhanghoa.Columns[2].Width = 100;

            dgvhanghoa.Columns[3].Width = 80;

            dgvhanghoa.Columns[4].Width = 100;
        }

        private void loadcmbmachatlieu()
        {
            string sql = "select * from CHATLIEU";

            cmbmachatlieu.DataSource = ketnoi.getdata(sql);

            cmbmachatlieu.DisplayMember = "TenChatLieu";

            cmbmachatlieu.ValueMember = "MaChatLieu";
        }

        private void FormDanhMucHangHoa_Load(object sender, EventArgs e)
        {

            loadcmbmachatlieu();

            txtmahang.Enabled = false;

            txtdongianhap.Enabled = false;

            txtdongiaban.Enabled = false;

            btnluu.Enabled = false;

            cmbmachatlieu.Text = "Select";

            btnxoa.Enabled = false;

            btnsua.Enabled = false;

            btnboqua.Enabled = false;

            txtmahang.Clear();

            txttenhang.Clear();

            txtsoluong.Clear();

            txtghichu.Clear();

            txtanh.Clear();

            picanh.Image = null;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string sql = "select * from HANG";

            tbhanghoa = ketnoi.getdata(sql);

            dgvhanghoa.DataSource = tbhanghoa;

            dgvhanghoa.Columns[0].HeaderText = "Mã Hàng";

            dgvhanghoa.Columns[1].HeaderText = "Tên Hàng";

            dgvhanghoa.Columns[2].HeaderText = "Mã Chất Liệu";

            dgvhanghoa.Columns[3].HeaderText = "Số Lượng";

            dgvhanghoa.Columns[4].HeaderText = "Đơn Giá Nhập";

            dgvhanghoa.Columns[5].HeaderText = "Đơn Giá Bán";

            dgvhanghoa.Columns[6].HeaderText = "Ảnh";

            dgvhanghoa.Columns[7].HeaderText = "Ghi Chú";

            dgvhanghoa.Columns[0].Width = 80;

            dgvhanghoa.Columns[1].Width = 120;

            dgvhanghoa.Columns[2].Width = 100;

            dgvhanghoa.Columns[3].Width = 80;

            dgvhanghoa.Columns[4].Width = 100;

            dgvhanghoa.Columns[6].Width = 300;
        }

        private void dgvhanghoa_Click(object sender, EventArgs e)
        {
            txtmahang.Text = dgvhanghoa.CurrentRow.Cells[0].Value.ToString();

            txttenhang.Text = dgvhanghoa.CurrentRow.Cells[1].Value.ToString();

            cmbmachatlieu.SelectedValue = dgvhanghoa.CurrentRow.Cells[2].Value.ToString();

            txtsoluong.Text = dgvhanghoa.CurrentRow.Cells[3].Value.ToString();

            txtdongianhap.Text = dgvhanghoa.CurrentRow.Cells[4].Value.ToString();

            txtdongiaban.Text = dgvhanghoa.CurrentRow.Cells[5].Value.ToString();

            txtanh.Text = dgvhanghoa.CurrentRow.Cells[6].Value.ToString();

            if(txtanh.Text != null)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Chọn file(*.jpg;*.png)|*.jpg;*.png";

                openFileDialog.FileName = txtanh.Text;

                picanh.ImageLocation = openFileDialog.FileName;

            }
            txtghichu.Text = dgvhanghoa.CurrentRow.Cells[7].Value.ToString();

            btnsua.Enabled = true;

            btnxoa.Enabled = true;

            btnthem.Enabled = false;

            btnluu.Enabled = false;

            btnboqua.Enabled = true;

            txtdongianhap.Enabled = true;

            txtdongiaban.Enabled = true;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Chọn file(*.jpg;*.png)|*.jpg;*.png";

            //openFileDialog.FilterIndex = 1;

            //openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picanh.ImageLocation = openFileDialog.FileName;

                txtanh.Text = openFileDialog.FileName;

            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmahang.Enabled = true;

            txtdongiaban.Enabled = true;

            txtdongianhap.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnluu.Enabled = true;

            btnthem.Enabled = false;

            btnboqua.Enabled = true;

            txtmahang.Clear();

            txttenhang.Clear();

            cmbmachatlieu.Text="Select";

            txtsoluong.Clear();

            txtdongiaban.Clear();

            txtdongianhap.Clear();

            txtanh.Clear();

            txtghichu.Clear();

            picanh.Image = null;

            dgvhanghoa.Enabled = false;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string mahh = txtmahang.Text;

            string sql1 = "SELECT *FROM HANG WHERE HANG.MaHang='" + mahh + "'";

            string sql = "INSERT INTO HANG (MaHang,TenHang,MaChatLieu,SoLuong,DonGiaNhap,DonGiaBan,Anh,GhiChu) VALUES('" + txtmahang.Text + "','" + txttenhang.Text + "','" + cmbmachatlieu.SelectedValue.ToString() + "','" + txtsoluong.Text + "','" + txtdongianhap.Text + "','" + txtdongiaban.Text + "','" + txtanh.Text + "','" + txtghichu.Text + "')";

            if (txtmahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã hàng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtmahang.Focus();

                return;
            }
            else if (txttenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên hàng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txttenhang.Focus();

                return;
            }
            else if (cmbmachatlieu.Text == "" || cmbmachatlieu.Text == "Select")
            {
                MessageBox.Show("Bạn chưa nhập mã chất liệu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số lượng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtsoluong.Focus();

                return;
            }
            else if (txtdongianhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đơn giá nhập.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtdongianhap.Focus();

                return;
            }
            else if (txtdongiaban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đơn giá bán.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtdongiaban.Focus();

                return;
            }
            else if (ketnoi.ktratrung(sql1))
            {
                MessageBox.Show("Mã [ " + txtmahang.Text + " ] đã có", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtmahang.Clear();

                txtmahang.Focus();
            }
            else
            {
                DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn thêm [ Tên Hàng: " + txttenhang.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (thanhcong == DialogResult.OK)
                {
                    ketnoi.runsql(sql);

                    MessageBox.Show("Thêm [ Tên Hàng : " + txttenhang.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnluu.Enabled = false;

                btnthem.Enabled = true;

                btnboqua.Enabled = false;

                txtmahang.Enabled = false;

                txtdongiaban.Enabled = false;

                txtdongianhap.Enabled = false;

                txtmahang.Clear();

                txttenhang.Clear();

                cmbmachatlieu.Text = "Select";

                txtsoluong.Clear();

                txtdongiaban.Clear();

                txtdongianhap.Clear();

                txtanh.Clear();

                txtghichu.Clear();

                picanh.Image = null;

                dgvhanghoa.Enabled = true;

                loaddgv();
            } 
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            txtmahang.Enabled = false;

            txtdongiaban.Enabled = false;

            txtdongianhap.Enabled = false;

            txtmahang.Clear();

            txttenhang.Clear();

            cmbmachatlieu.Text = "Select";

            txtsoluong.Clear();

            txtdongiaban.Clear();

            txtdongianhap.Clear();

            txtanh.Clear();

            txtghichu.Clear();

            picanh.Image = null;

            btnboqua.Enabled = false;

            btnthem.Enabled = true;

            btnluu.Enabled = false;

            btnxoa.Enabled = false;

            btnsua.Enabled = false;

            dgvhanghoa.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM HANG WHERE HANG.MaHang='" + txtmahang.Text + "'";

            DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn xóa [ Tên Hàng : " + txttenhang.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (thanhcong == DialogResult.OK)
            {
                ketnoi.runsql(sql);

                MessageBox.Show("Xóa [ Tên Hàng : " + txttenhang.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnthem.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnboqua.Enabled = false;

            txtmahang.Clear();

            txttenhang.Clear();

            cmbmachatlieu.Text = "Select";

            txtsoluong.Clear();

            txtdongiaban.Clear();

            txtdongianhap.Clear();

            txtanh.Clear();

            txtghichu.Clear();

            picanh.Image = null;

            loaddgv();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE HANG SET TenHang= '" + txttenhang.Text + "', MaChatLieu='" + cmbmachatlieu.SelectedValue.ToString() + "', SoLuong='" + txtsoluong.Text + "', DonGiaNhap='" + txtdongianhap.Text + "', DonGiaBan='" + txtdongiaban.Text + "', Anh='" + txtanh.Text + "', GhiChu='" + txtghichu.Text + "' WHERE MaHang= '" + txtmahang.Text + "'";

            DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn sửa [ Tên Hàng : " + txttenhang.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (thanhcong == DialogResult.OK)
            {
                ketnoi.runsql(sql);

                MessageBox.Show("Sửa [ Tên Hàng : " + txttenhang.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnthem.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnboqua.Enabled = false;

            txtmahang.Clear();

            txttenhang.Clear();

            cmbmachatlieu.Text = "Select";

            txtsoluong.Clear();

            txtdongiaban.Clear();

            txtdongianhap.Clear();

            txtanh.Clear();

            txtghichu.Clear();

            picanh.Image = null;

            loaddgv();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            txtmahang.Clear();

            cmbmachatlieu.Text = "Select";

            txtsoluong.Clear();

            txtdongianhap.Clear();

            txtdongiaban.Clear();

            txtanh.Clear();

            txtghichu.Clear();

            picanh.Image = null;

            loaddgv();
        }
    }
}
