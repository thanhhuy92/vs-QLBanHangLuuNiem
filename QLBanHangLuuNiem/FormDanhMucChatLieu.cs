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
    public partial class frmDMChatLieu : System.Windows.Forms.Form
    {
        public frmDMChatLieu()
        {
            InitializeComponent();
        }

        DataTable tbchatieu;

        private void loadgridview()
        {
            string sql = "Select* from CHATLIEU";

            tbchatieu = ketnoi.getdata(sql);

            dgvchatlieu.DataSource = tbchatieu;

            dgvchatlieu.Columns[0].HeaderText = "Mã Chất Liệu";

            dgvchatlieu.Columns[1].HeaderText = "Tên Chất Liệu";

            dgvchatlieu.Columns[0].Width = 150;

            dgvchatlieu.Columns[1].Width = 250;
        }

        private void frmDMChatLieu_Load(object sender, EventArgs e)
        {
            
            loadgridview();

            btnluu.Enabled = false;

            txtmachatlieu.Enabled = false;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnboqua.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnboqua.Enabled = true;

            btnthem.Enabled = false;

            txtmachatlieu.Enabled = true;

            txtmachatlieu.Focus();

            txtmachatlieu.Clear();

            txttenchatlieu.Clear();

            dgvchatlieu.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string macl = txtmachatlieu.Text;

            string sql = "INSERT INTO CHATLIEU (MaChatLieu,TenChatLieu) VALUES('" + txtmachatlieu.Text + "','" + txttenchatlieu.Text + "')";

            string sql1 = "SELECT *FROM CHATLIEU WHERE CHATLIEU.MaChatLieu='" + macl + "'";
               
            if (txtmachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã chất liệu.", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                txtmachatlieu.Focus();

                return;
            }
            else if (txttenchatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu.", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                txttenchatlieu.Focus();

                return;
            }
            else if(ketnoi.ktratrung(sql1)==true)
            {
                MessageBox.Show("Mã [ " + txtmachatlieu.Text + " ] đã có", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                txtmachatlieu.Clear();

                txtmachatlieu.Focus();
            }
            else 
            {
                DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn thêm [ Chất Liêu: " + txttenchatlieu.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (thanhcong == DialogResult.OK)
                {
                    ketnoi.runsql(sql);

                    MessageBox.Show("Thêm [ Chất Liệu : " + txttenchatlieu.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }      
            }
            txtmachatlieu.Enabled = false;

            btnluu.Enabled = false;

            btnboqua.Enabled = false;

            btnthem.Enabled = true;

            txtmachatlieu.Clear();

            txttenchatlieu.Clear();

            dgvchatlieu.Enabled = true;

            loadgridview();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM CHATLIEU WHERE CHATLIEU.MaChatLieu='" + txtmachatlieu.Text + "'";

            if (txttenchatlieu.Text == "" || txttenchatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txttenchatlieu.Focus();

                return;
            }
            else if (tbchatieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa");
                return;
            }
            else
            {
                DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn xóa [ Mã Chất Liệu : " + txtmachatlieu.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (thanhcong == DialogResult.OK)
                {
                    ketnoi.runsql(sql);

                    MessageBox.Show("Xóa [ Mã Chất Liệu : " + txtmachatlieu.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            txtmachatlieu.Clear();

            txttenchatlieu.Clear();

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnthem.Enabled = true;

            loadgridview();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {

            if (tbchatieu.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu!!!");

                return;
            }

            txtmachatlieu.Text = dgvchatlieu.CurrentRow.Cells[0].Value.ToString();

            txttenchatlieu.Text = dgvchatlieu.CurrentRow.Cells[1].Value.ToString();

            btnthem.Enabled = false;

            btnsua.Enabled = true;

            btnxoa.Enabled = true;

            btnboqua.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE CHATLIEU SET TenChatLieu= '" + txttenchatlieu.Text + "' WHERE MaChatLieu= '" + txtmachatlieu.Text + "'";

            if (txttenchatlieu.Text == "" || txttenchatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txttenchatlieu.Focus();

                return;
            }
            else if(tbchatieu.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa");
                return;
            }
            else
            {
                DialogResult thanhcong = MessageBox.Show("Bạn có chắc chắn sửa [ Mã Chất Liệu : " + txtmachatlieu.Text + " ] không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (thanhcong == DialogResult.OK)
                {
                    ketnoi.runsql(sql);

                    MessageBox.Show("Sửa [ Mã Chất Liệu : " + txtmachatlieu.Text + " ] thành công!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            txtmachatlieu.Clear();

            txttenchatlieu.Clear();

            btnthem.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            loadgridview();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            txtmachatlieu.Enabled = false;

            txtmachatlieu.Clear();

            txttenchatlieu.Clear();

            btnthem.Enabled = true;

            btnsua.Enabled = false;

            btnxoa.Enabled = false;

            btnboqua.Enabled = false;

            btnluu.Enabled = false;

            dgvchatlieu.Enabled = true;
        }
    }
}
