namespace QLBanHangLuuNiem
{
    partial class frmDMChatLieu
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
            this.lbmachatlieu = new System.Windows.Forms.Label();
            this.txtmachatlieu = new System.Windows.Forms.TextBox();
            this.txttenchatlieu = new System.Windows.Forms.TextBox();
            this.lbtenchatlieu = new System.Windows.Forms.Label();
            this.dgvchatlieu = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.lbdanhmucchatlieu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchatlieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmachatlieu
            // 
            this.lbmachatlieu.AutoSize = true;
            this.lbmachatlieu.Location = new System.Drawing.Point(53, 89);
            this.lbmachatlieu.Name = "lbmachatlieu";
            this.lbmachatlieu.Size = new System.Drawing.Size(70, 13);
            this.lbmachatlieu.TabIndex = 0;
            this.lbmachatlieu.Text = "Mã Chất Liệu";
            // 
            // txtmachatlieu
            // 
            this.txtmachatlieu.Location = new System.Drawing.Point(139, 86);
            this.txtmachatlieu.Name = "txtmachatlieu";
            this.txtmachatlieu.Size = new System.Drawing.Size(236, 20);
            this.txtmachatlieu.TabIndex = 1;
            // 
            // txttenchatlieu
            // 
            this.txttenchatlieu.Location = new System.Drawing.Point(139, 123);
            this.txttenchatlieu.Name = "txttenchatlieu";
            this.txttenchatlieu.Size = new System.Drawing.Size(236, 20);
            this.txttenchatlieu.TabIndex = 3;
            // 
            // lbtenchatlieu
            // 
            this.lbtenchatlieu.AutoSize = true;
            this.lbtenchatlieu.Location = new System.Drawing.Point(53, 126);
            this.lbtenchatlieu.Name = "lbtenchatlieu";
            this.lbtenchatlieu.Size = new System.Drawing.Size(74, 13);
            this.lbtenchatlieu.TabIndex = 2;
            this.lbtenchatlieu.Text = "Tên Chất Liệu";
            // 
            // dgvchatlieu
            // 
            this.dgvchatlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchatlieu.Location = new System.Drawing.Point(30, 160);
            this.dgvchatlieu.Name = "dgvchatlieu";
            this.dgvchatlieu.Size = new System.Drawing.Size(549, 150);
            this.dgvchatlieu.TabIndex = 4;
            this.dgvchatlieu.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(30, 326);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(123, 326);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(313, 326);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 8;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(220, 326);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 7;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(504, 326);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(75, 23);
            this.btndong.TabIndex = 10;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(411, 326);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 9;
            this.btnboqua.Text = "Bỏ Qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // lbdanhmucchatlieu
            // 
            this.lbdanhmucchatlieu.AutoSize = true;
            this.lbdanhmucchatlieu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdanhmucchatlieu.Location = new System.Drawing.Point(152, 24);
            this.lbdanhmucchatlieu.Name = "lbdanhmucchatlieu";
            this.lbdanhmucchatlieu.Size = new System.Drawing.Size(283, 26);
            this.lbdanhmucchatlieu.TabIndex = 11;
            this.lbdanhmucchatlieu.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // frmDMChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbdanhmucchatlieu);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvchatlieu);
            this.Controls.Add(this.txttenchatlieu);
            this.Controls.Add(this.lbtenchatlieu);
            this.Controls.Add(this.txtmachatlieu);
            this.Controls.Add(this.lbmachatlieu);
            this.Name = "frmDMChatLieu";
            this.Text = "Form Danh Mục Chất Liệu";
            this.Load += new System.EventHandler(this.frmDMChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvchatlieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmachatlieu;
        private System.Windows.Forms.TextBox txtmachatlieu;
        private System.Windows.Forms.TextBox txttenchatlieu;
        private System.Windows.Forms.Label lbtenchatlieu;
        private System.Windows.Forms.DataGridView dgvchatlieu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Label lbdanhmucchatlieu;
    }
}