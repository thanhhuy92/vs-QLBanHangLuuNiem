namespace QLBanHangLuuNiem
{
    partial class frmTimHDBan
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
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.txtthang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmakhachhang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvhoadon = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(93, 84);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(221, 20);
            this.txtmahoadon.TabIndex = 1;
            // 
            // txtthang
            // 
            this.txtthang.Location = new System.Drawing.Point(93, 120);
            this.txtthang.Name = "txtthang";
            this.txtthang.Size = new System.Drawing.Size(80, 20);
            this.txtthang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tháng";
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(93, 155);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(221, 20);
            this.txtmanhanvien.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(247, 120);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(67, 20);
            this.txtnam.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Năm";
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.Location = new System.Drawing.Point(449, 84);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.Size = new System.Drawing.Size(221, 20);
            this.txtmakhachhang.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã Khách Hàng";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(449, 120);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(221, 20);
            this.txttongtien.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng Tiền";
            // 
            // dgvhoadon
            // 
            this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhoadon.Location = new System.Drawing.Point(12, 190);
            this.dgvhoadon.Name = "dgvhoadon";
            this.dgvhoadon.Size = new System.Drawing.Size(658, 150);
            this.dgvhoadon.TabIndex = 12;
            this.dgvhoadon.Click += new System.EventHandler(this.dgvhoadon_Click);
            this.dgvhoadon.DoubleClick += new System.EventHandler(this.dgvhoadon_DoubleClick);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(164, 375);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 13;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(295, 375);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(75, 23);
            this.btntimlai.TabIndex = 14;
            this.btntimlai.Text = "Tìm Lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(432, 375);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 15;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(22, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(312, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nhấp double vào hóa đơn để hiện thông tin chi tiết";
            // 
            // frmTimHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 410);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgvhoadon);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmakhachhang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtthang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmahoadon);
            this.Controls.Add(this.label1);
            this.Name = "frmTimHDBan";
            this.Text = "Tìm Kiếm Hóa Đơn";
            this.Load += new System.EventHandler(this.frmTimHDBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.TextBox txtthang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmakhachhang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvhoadon;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Label label7;
    }
}