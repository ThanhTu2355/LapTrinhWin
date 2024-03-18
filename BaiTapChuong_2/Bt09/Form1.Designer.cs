
namespace Bt09
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
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnThoát = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.labNS = new System.Windows.Forms.Label();
            this.lbaPhai = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbaHoTen = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.lstHocVien = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLaSinhVien = new System.Windows.Forms.CheckBox();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(129, 232);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(72, 28);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnThoát
            // 
            this.btnThoát.Location = new System.Drawing.Point(224, 232);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(72, 28);
            this.btnThoát.TabIndex = 6;
            this.btnThoát.Text = "Xoá";
            this.btnThoát.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(13, 232);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(93, 28);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(89, 188);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(73, 19);
            this.lblThanhTien.TabIndex = 8;
            this.lblThanhTien.Text = "1,000,000";
            this.lblThanhTien.Click += new System.EventHandler(this.lblThanhTien_Click);
            // 
            // labNS
            // 
            this.labNS.AutoSize = true;
            this.labNS.Location = new System.Drawing.Point(6, 188);
            this.labNS.Name = "labNS";
            this.labNS.Size = new System.Drawing.Size(71, 19);
            this.labNS.TabIndex = 6;
            this.labNS.Text = "Thành tiền";
            // 
            // lbaPhai
            // 
            this.lbaPhai.AutoSize = true;
            this.lbaPhai.Location = new System.Drawing.Point(6, 151);
            this.lbaPhai.Name = "lbaPhai";
            this.lbaPhai.Size = new System.Drawing.Size(86, 19);
            this.lbaPhai.TabIndex = 4;
            this.lbaPhai.Text = "Lớp đăng ký";
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
            this.lbaHoTen.Size = new System.Drawing.Size(55, 19);
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
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã HV";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.chkLaSinhVien);
            this.grbThongTin.Controls.Add(this.btnTiep);
            this.grbThongTin.Controls.Add(this.btnThoát);
            this.grbThongTin.Controls.Add(this.cboLopHoc);
            this.grbThongTin.Controls.Add(this.btnDangKy);
            this.grbThongTin.Controls.Add(this.lblThanhTien);
            this.grbThongTin.Controls.Add(this.labNS);
            this.grbThongTin.Controls.Add(this.lbaPhai);
            this.grbThongTin.Controls.Add(this.txtHoTen);
            this.grbThongTin.Controls.Add(this.lbaHoTen);
            this.grbThongTin.Controls.Add(this.txtMaHV);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(302, 68);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(315, 274);
            this.grbThongTin.TabIndex = 12;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin học viên";
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(93, 147);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(204, 27);
            this.cboLopHoc.TabIndex = 5;
            this.cboLopHoc.SelectedIndexChanged += new System.EventHandler(this.cboLopHoc_SelectedIndexChanged);
            // 
            // lstHocVien
            // 
            this.lstHocVien.ForeColor = System.Drawing.Color.Blue;
            this.lstHocVien.FormattingEnabled = true;
            this.lstHocVien.ItemHeight = 19;
            this.lstHocVien.Location = new System.Drawing.Point(17, 68);
            this.lstHocVien.Name = "lstHocVien";
            this.lstHocVien.Size = new System.Drawing.Size(266, 270);
            this.lstHocVien.TabIndex = 11;
            this.lstHocVien.SelectedIndexChanged += new System.EventHandler(this.lstHocVien_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 65);
            this.label1.TabIndex = 10;
            this.label1.Text = "DANH SÁCH HỌC VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkLaSinhVien
            // 
            this.chkLaSinhVien.AutoSize = true;
            this.chkLaSinhVien.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLaSinhVien.Location = new System.Drawing.Point(5, 114);
            this.chkLaSinhVien.Name = "chkLaSinhVien";
            this.chkLaSinhVien.Size = new System.Drawing.Size(99, 23);
            this.chkLaSinhVien.TabIndex = 9;
            this.chkLaSinhVien.Text = "Là sinh viên";
            this.chkLaSinhVien.UseVisualStyleBackColor = true;
            this.chkLaSinhVien.CheckedChanged += new System.EventHandler(this.chkLaSinhVien_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 375);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lstHocVien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label labNS;
        private System.Windows.Forms.Label lbaPhai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbaHoTen;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.CheckBox chkLaSinhVien;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.ListBox lstHocVien;
        private System.Windows.Forms.Label label1;
    }
}

