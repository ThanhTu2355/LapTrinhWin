
namespace BT07
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.lstHocVien = new System.Windows.Forms.ListBox();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lbsDC = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.labNS = new System.Windows.Forms.Label();
            this.txtPhai = new System.Windows.Forms.TextBox();
            this.lbaPhai = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbaHoTen = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(717, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HỌC VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn lớp";
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(99, 72);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(261, 28);
            this.cboLopHoc.TabIndex = 0;
            this.cboLopHoc.SelectedIndexChanged += new System.EventHandler(this.cboLopHoc_SelectedIndexChanged);
            // 
            // lstHocVien
            // 
            this.lstHocVien.ForeColor = System.Drawing.Color.Blue;
            this.lstHocVien.FormattingEnabled = true;
            this.lstHocVien.ItemHeight = 20;
            this.lstHocVien.Location = new System.Drawing.Point(12, 110);
            this.lstHocVien.Name = "lstHocVien";
            this.lstHocVien.Size = new System.Drawing.Size(347, 264);
            this.lstHocVien.TabIndex = 1;
            this.lstHocVien.SelectedIndexChanged += new System.EventHandler(this.lstHocVien_SelectedIndexChanged);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnTiep);
            this.grbThongTin.Controls.Add(this.btnXoa);
            this.grbThongTin.Controls.Add(this.btnCapNhat);
            this.grbThongTin.Controls.Add(this.txtDiaChi);
            this.grbThongTin.Controls.Add(this.lbsDC);
            this.grbThongTin.Controls.Add(this.txtNgaySinh);
            this.grbThongTin.Controls.Add(this.labNS);
            this.grbThongTin.Controls.Add(this.txtPhai);
            this.grbThongTin.Controls.Add(this.lbaPhai);
            this.grbThongTin.Controls.Add(this.txtHoTen);
            this.grbThongTin.Controls.Add(this.lbaHoTen);
            this.grbThongTin.Controls.Add(this.txtMaHV);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(383, 73);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(315, 307);
            this.grbThongTin.TabIndex = 4;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin học viên";
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(225, 262);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(72, 28);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(126, 262);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 28);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(6, 262);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(93, 28);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(93, 205);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(204, 26);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lbsDC
            // 
            this.lbsDC.AutoSize = true;
            this.lbsDC.Location = new System.Drawing.Point(6, 208);
            this.lbsDC.Name = "lbsDC";
            this.lbsDC.Size = new System.Drawing.Size(57, 20);
            this.lbsDC.TabIndex = 8;
            this.lbsDC.Text = "Địa chỉ";
            this.lbsDC.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(93, 164);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(204, 26);
            this.txtNgaySinh.TabIndex = 3;
            this.txtNgaySinh.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labNS
            // 
            this.labNS.AutoSize = true;
            this.labNS.Location = new System.Drawing.Point(6, 167);
            this.labNS.Name = "labNS";
            this.labNS.Size = new System.Drawing.Size(78, 20);
            this.labNS.TabIndex = 6;
            this.labNS.Text = "Ngày sinh";
            // 
            // txtPhai
            // 
            this.txtPhai.Location = new System.Drawing.Point(93, 123);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(204, 26);
            this.txtPhai.TabIndex = 2;
            // 
            // lbaPhai
            // 
            this.lbaPhai.AutoSize = true;
            this.lbaPhai.Location = new System.Drawing.Point(6, 126);
            this.lbaPhai.Name = "lbaPhai";
            this.lbaPhai.Size = new System.Drawing.Size(40, 20);
            this.lbaPhai.TabIndex = 4;
            this.lbaPhai.Text = "Phái";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(93, 82);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(204, 26);
            this.txtHoTen.TabIndex = 1;
            // 
            // lbaHoTen
            // 
            this.lbaHoTen.AutoSize = true;
            this.lbaHoTen.Location = new System.Drawing.Point(6, 85);
            this.lbaHoTen.Name = "lbaHoTen";
            this.lbaHoTen.Size = new System.Drawing.Size(61, 20);
            this.lbaHoTen.TabIndex = 2;
            this.lbaHoTen.Text = "Họ Tên";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(93, 46);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.ReadOnly = true;
            this.txtMaHV.Size = new System.Drawing.Size(204, 26);
            this.txtMaHV.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã HV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 398);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lstHocVien);
            this.Controls.Add(this.cboLopHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu sinh viên theo lớp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.ListBox lstHocVien;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lbsDC;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.Label labNS;
        private System.Windows.Forms.TextBox txtPhai;
        private System.Windows.Forms.Label lbaPhai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbaHoTen;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
    }
}

