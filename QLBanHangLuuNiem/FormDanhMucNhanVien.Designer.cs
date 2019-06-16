namespace QLBanHangLuuNiem
{
    partial class frmDMNhanVien
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
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkgioitinh = new System.Windows.Forms.CheckBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Location = new System.Drawing.Point(43, 182);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.Size = new System.Drawing.Size(592, 150);
            this.dgvnhanvien.TabIndex = 0;
            this.dgvnhanvien.Click += new System.EventHandler(this.dgvnhanvien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(126, 67);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(168, 20);
            this.txtmanhanvien.TabIndex = 2;
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(126, 103);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(168, 20);
            this.txttennhanvien.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Điện Thoại";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(452, 67);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(183, 20);
            this.txtdiachi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Giới Tính";
            // 
            // chkgioitinh
            // 
            this.chkgioitinh.AutoSize = true;
            this.chkgioitinh.Location = new System.Drawing.Point(126, 141);
            this.chkgioitinh.Name = "chkgioitinh";
            this.chkgioitinh.Size = new System.Drawing.Size(48, 17);
            this.chkgioitinh.TabIndex = 12;
            this.chkgioitinh.Text = "Nam";
            this.chkgioitinh.UseVisualStyleBackColor = true;
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(452, 103);
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(183, 20);
            this.mskdienthoai.TabIndex = 13;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(14, 355);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(128, 355);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(362, 355);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 18;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(246, 355);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(598, 355);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 20;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(480, 355);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 19;
            this.btnboqua.Text = "Bỏ Qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(452, 136);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(183, 20);
            this.dtpngaysinh.TabIndex = 22;
            // 
            // frmDMNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 392);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.chkgioitinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvnhanvien);
            this.Name = "frmDMNhanVien";
            this.Text = "FormDanhMucNhanVien";
            this.Load += new System.EventHandler(this.frmDMNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkgioitinh;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
    }
}