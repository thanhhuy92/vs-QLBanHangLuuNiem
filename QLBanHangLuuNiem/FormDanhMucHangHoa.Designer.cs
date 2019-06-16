namespace QLBanHangLuuNiem
{
    partial class frmDMHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdongianhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdongiaban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvhanghoa = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.cmbmachatlieu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picanh = new System.Windows.Forms.PictureBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.txtanh = new System.Windows.Forms.TextBox();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng";
            // 
            // txtmahang
            // 
            this.txtmahang.Location = new System.Drawing.Point(113, 86);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(144, 20);
            this.txtmahang.TabIndex = 1;
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(113, 122);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(144, 20);
            this.txttenhang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Chất Liệu";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(113, 195);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(144, 20);
            this.txtsoluong.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số Lượng";
            // 
            // txtdongianhap
            // 
            this.txtdongianhap.Location = new System.Drawing.Point(113, 233);
            this.txtdongianhap.Name = "txtdongianhap";
            this.txtdongianhap.Size = new System.Drawing.Size(144, 20);
            this.txtdongianhap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn Giá Nhập";
            // 
            // txtdongiaban
            // 
            this.txtdongiaban.Location = new System.Drawing.Point(113, 268);
            this.txtdongiaban.Name = "txtdongiaban";
            this.txtdongiaban.Size = new System.Drawing.Size(144, 20);
            this.txtdongiaban.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Đơn Giá Bán";
            // 
            // dgvhanghoa
            // 
            this.dgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanghoa.Location = new System.Drawing.Point(28, 307);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.Size = new System.Drawing.Size(803, 150);
            this.dgvhanghoa.TabIndex = 12;
            this.dgvhanghoa.Click += new System.EventHandler(this.dgvhanghoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(44, 476);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(141, 476);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(238, 476);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 15;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(336, 476);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 16;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(431, 476);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 17;
            this.btnboqua.Text = "Bỏ Qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(530, 476);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 18;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(626, 476);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(75, 23);
            this.btnhienthi.TabIndex = 19;
            this.btnhienthi.Text = "Hiển Thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(723, 476);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 20;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // cmbmachatlieu
            // 
            this.cmbmachatlieu.FormattingEnabled = true;
            this.cmbmachatlieu.Location = new System.Drawing.Point(113, 158);
            this.cmbmachatlieu.Name = "cmbmachatlieu";
            this.cmbmachatlieu.Size = new System.Drawing.Size(144, 21);
            this.cmbmachatlieu.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ảnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ghi Chú";
            // 
            // picanh
            // 
            this.picanh.Location = new System.Drawing.Point(647, 86);
            this.picanh.Name = "picanh";
            this.picanh.Size = new System.Drawing.Size(192, 159);
            this.picanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picanh.TabIndex = 24;
            this.picanh.TabStop = false;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(557, 140);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 25;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // txtanh
            // 
            this.txtanh.Location = new System.Drawing.Point(352, 122);
            this.txtanh.Multiline = true;
            this.txtanh.Name = "txtanh";
            this.txtanh.Size = new System.Drawing.Size(183, 52);
            this.txtanh.TabIndex = 26;
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(352, 195);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(183, 62);
            this.txtghichu.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(248, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(343, 32);
            this.label9.TabIndex = 28;
            this.label9.Text = "DANH MỤC HÀNG HÓA";
            // 
            // frmDMHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 515);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.txtanh);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.picanh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbmachatlieu);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvhanghoa);
            this.Controls.Add(this.txtdongiaban);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdongianhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttenhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmahang);
            this.Controls.Add(this.label1);
            this.Name = "frmDMHang";
            this.Text = "FormDanhMucHangHoa";
            this.Load += new System.EventHandler(this.FormDanhMucHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdongianhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdongiaban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvhanghoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.ComboBox cmbmachatlieu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picanh;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox txtanh;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label9;
    }
}