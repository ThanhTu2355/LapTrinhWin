
namespace BT15
{
    partial class Form1
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
            this.grbQLVe = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmuSoLuong = new System.Windows.Forms.NumericUpDown();
            this.dmuLoaiVe = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.chkLaSinhVien = new System.Windows.Forms.CheckBox();
            this.grbQLVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ ĐẶT VÉ XEM PHIM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbQLVe
            // 
            this.grbQLVe.Controls.Add(this.chkLaSinhVien);
            this.grbQLVe.Controls.Add(this.dtpNgayDat);
            this.grbQLVe.Controls.Add(this.label7);
            this.grbQLVe.Controls.Add(this.btnThoat);
            this.grbQLVe.Controls.Add(this.btnTiep);
            this.grbQLVe.Controls.Add(this.btnDatVe);
            this.grbQLVe.Controls.Add(this.label6);
            this.grbQLVe.Controls.Add(this.label5);
            this.grbQLVe.Controls.Add(this.dmuLoaiVe);
            this.grbQLVe.Controls.Add(this.nmuSoLuong);
            this.grbQLVe.Controls.Add(this.txtThanhTien);
            this.grbQLVe.Controls.Add(this.label4);
            this.grbQLVe.Controls.Add(this.txtDiaChi);
            this.grbQLVe.Controls.Add(this.label3);
            this.grbQLVe.Controls.Add(this.txtTen);
            this.grbQLVe.Controls.Add(this.label2);
            this.grbQLVe.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQLVe.ForeColor = System.Drawing.Color.Blue;
            this.grbQLVe.Location = new System.Drawing.Point(14, 75);
            this.grbQLVe.Name = "grbQLVe";
            this.grbQLVe.Size = new System.Drawing.Size(456, 316);
            this.grbQLVe.TabIndex = 1;
            this.grbQLVe.TabStop = false;
            this.grbQLVe.Text = "Thông tin đặt vé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(112, 37);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(319, 27);
            this.txtTen.TabIndex = 1;
            this.txtTen.Text = "Trần Văn An";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(112, 80);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(319, 27);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.Text = "Thành Phố Hồ Chí Minh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(112, 211);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(319, 27);
            this.txtThanhTien.TabIndex = 5;
            this.txtThanhTien.Text = "800.000 VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thành tiền";
            // 
            // nmuSoLuong
            // 
            this.nmuSoLuong.Location = new System.Drawing.Point(112, 164);
            this.nmuSoLuong.Name = "nmuSoLuong";
            this.nmuSoLuong.Size = new System.Drawing.Size(120, 27);
            this.nmuSoLuong.TabIndex = 6;
            this.nmuSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dmuLoaiVe
            // 
            this.dmuLoaiVe.Location = new System.Drawing.Point(311, 164);
            this.dmuLoaiVe.Name = "dmuLoaiVe";
            this.dmuLoaiVe.Size = new System.Drawing.Size(120, 27);
            this.dmuLoaiVe.TabIndex = 7;
            this.dmuLoaiVe.Text = "VIP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số lượng vé";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Loại vé";
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(86, 265);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(83, 29);
            this.btnDatVe.TabIndex = 10;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(196, 265);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(83, 29);
            this.btnTiep.TabIndex = 11;
            this.btnTiep.Text = "TIếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(306, 265);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 29);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ngày đặt vé";
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDat.Location = new System.Drawing.Point(115, 123);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(145, 27);
            this.dtpNgayDat.TabIndex = 14;
            // 
            // chkLaSinhVien
            // 
            this.chkLaSinhVien.AutoSize = true;
            this.chkLaSinhVien.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLaSinhVien.Checked = true;
            this.chkLaSinhVien.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLaSinhVien.Location = new System.Drawing.Point(314, 125);
            this.chkLaSinhVien.Name = "chkLaSinhVien";
            this.chkLaSinhVien.Size = new System.Drawing.Size(117, 23);
            this.chkLaSinhVien.TabIndex = 15;
            this.chkLaSinhVien.Text = "Là sinh viên";
            this.chkLaSinhVien.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 403);
            this.Controls.Add(this.grbQLVe);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí đặt vé xem phim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbQLVe.ResumeLayout(false);
            this.grbQLVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmuSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbQLVe;
        private System.Windows.Forms.CheckBox chkLaSinhVien;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown dmuLoaiVe;
        private System.Windows.Forms.NumericUpDown nmuSoLuong;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
    }
}

