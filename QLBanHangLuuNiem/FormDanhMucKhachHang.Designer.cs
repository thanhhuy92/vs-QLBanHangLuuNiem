namespace QLBanHangLuuNiem
{
    partial class frmDMKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbmakhach = new System.Windows.Forms.Label();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.lbtenkhach = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.lbdienthoai = new System.Windows.Forms.Label();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmakhach
            // 
            this.lbmakhach.AutoSize = true;
            this.lbmakhach.Location = new System.Drawing.Point(53, 83);
            this.lbmakhach.Name = "lbmakhach";
            this.lbmakhach.Size = new System.Drawing.Size(56, 13);
            this.lbmakhach.TabIndex = 0;
            this.lbmakhach.Text = "Mã Khách";
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(124, 80);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(139, 20);
            this.txtmakhach.TabIndex = 1;
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(124, 121);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(139, 20);
            this.txttenkhach.TabIndex = 3;
            // 
            // lbtenkhach
            // 
            this.lbtenkhach.AutoSize = true;
            this.lbtenkhach.Location = new System.Drawing.Point(49, 128);
            this.lbtenkhach.Name = "lbtenkhach";
            this.lbtenkhach.Size = new System.Drawing.Size(60, 13);
            this.lbtenkhach.TabIndex = 2;
            this.lbtenkhach.Text = "Tên Khách";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(421, 80);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(145, 20);
            this.txtdiachi.TabIndex = 5;
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Location = new System.Drawing.Point(349, 83);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(41, 13);
            this.lbdiachi.TabIndex = 4;
            this.lbdiachi.Text = "Địa Chỉ";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Location = new System.Drawing.Point(12, 173);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.Size = new System.Drawing.Size(602, 150);
            this.dgvkhachhang.TabIndex = 6;
            this.dgvkhachhang.Click += new System.EventHandler(this.dgvkhachhang_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(28, 333);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(126, 333);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(227, 333);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(323, 333);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 10;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(422, 333);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 11;
            this.btnboqua.Text = "Bỏ Qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(525, 333);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 12;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // lbdienthoai
            // 
            this.lbdienthoai.AutoSize = true;
            this.lbdienthoai.Location = new System.Drawing.Point(349, 124);
            this.lbdienthoai.Name = "lbdienthoai";
            this.lbdienthoai.Size = new System.Drawing.Size(59, 13);
            this.lbdienthoai.TabIndex = 13;
            this.lbdienthoai.Text = "Điện Thoại";
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(421, 121);
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(145, 20);
            this.mskdienthoai.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // frmDMKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.lbdienthoai);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvkhachhang);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.lbdiachi);
            this.Controls.Add(this.txttenkhach);
            this.Controls.Add(this.lbtenkhach);
            this.Controls.Add(this.txtmakhach);
            this.Controls.Add(this.lbmakhach);
            this.Name = "frmDMKhachHang";
            this.Text = "FormDanhMucKhachHang";
            this.Load += new System.EventHandler(this.frmDMKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmakhach;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.Label lbtenkhach;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbdiachi;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Label lbdienthoai;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.Label label1;
    }
}