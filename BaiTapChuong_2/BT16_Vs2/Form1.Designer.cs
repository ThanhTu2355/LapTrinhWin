
namespace BT16_Vs2
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
            this.chkLaSinhVien = new System.Windows.Forms.CheckBox();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnThoát = new System.Windows.Forms.Button();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.labNS = new System.Windows.Forms.Label();
            this.lbaPhai = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbaHoTen = new System.Windows.Forms.Label();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstHocVien = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkLaSinhVien
            // 
            this.chkLaSinhVien.AutoSize = true;
            this.chkLaSinhVien.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLaSinhVien.Location = new System.Drawing.Point(23, 111);
            this.chkLaSinhVien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkLaSinhVien.Name = "chkLaSinhVien";
            this.chkLaSinhVien.Size = new System.Drawing.Size(109, 23);
            this.chkLaSinhVien.TabIndex = 9;
            this.chkLaSinhVien.Text = "Là sinh viên";
            this.chkLaSinhVien.UseVisualStyleBackColor = true;
            this.chkLaSinhVien.CheckedChanged += new System.EventHandler(this.chkLaSinhVien_CheckedChanged);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(200, 226);
            this.btnTiep.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(93, 34);
            this.btnTiep.TabIndex = 7;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnThoát
            // 
            this.btnThoát.Location = new System.Drawing.Point(293, 226);
            this.btnThoát.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnThoát.Name = "btnThoát";
            this.btnThoát.Size = new System.Drawing.Size(93, 34);
            this.btnThoát.TabIndex = 6;
            this.btnThoát.Text = "Thoát";
            this.btnThoát.UseVisualStyleBackColor = true;
            this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(119, 147);
            this.cboLopHoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(256, 27);
            this.cboLopHoc.TabIndex = 5;
            this.cboLopHoc.SelectedIndexChanged += new System.EventHandler(this.cboLopHoc_SelectedIndexChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(110, 226);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(91, 34);
            this.btnDangKy.TabIndex = 5;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(142, 187);
            this.lblThanhTien.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(80, 19);
            this.lblThanhTien.TabIndex = 8;
            this.lblThanhTien.Text = "1,000,000";
            // 
            // labNS
            // 
            this.labNS.AutoSize = true;
            this.labNS.Location = new System.Drawing.Point(23, 187);
            this.labNS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labNS.Name = "labNS";
            this.labNS.Size = new System.Drawing.Size(79, 19);
            this.labNS.TabIndex = 6;
            this.labNS.Text = "Thành tiền";
            // 
            // lbaPhai
            // 
            this.lbaPhai.AutoSize = true;
            this.lbaPhai.Location = new System.Drawing.Point(23, 151);
            this.lbaPhai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbaPhai.Name = "lbaPhai";
            this.lbaPhai.Size = new System.Drawing.Size(92, 19);
            this.lbaPhai.TabIndex = 4;
            this.lbaPhai.Text = "Lớp đăng ký";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(119, 71);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(256, 27);
            this.txtHoTen.TabIndex = 1;
            // 
            // lbaHoTen
            // 
            this.lbaHoTen.AutoSize = true;
            this.lbaHoTen.Location = new System.Drawing.Point(23, 75);
            this.lbaHoTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbaHoTen.Name = "lbaHoTen";
            this.lbaHoTen.Size = new System.Drawing.Size(59, 19);
            this.lbaHoTen.TabIndex = 2;
            this.lbaHoTen.Text = "Họ Tên";
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(119, 35);
            this.txtMaHV.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.ReadOnly = true;
            this.txtMaHV.Size = new System.Drawing.Size(256, 27);
            this.txtMaHV.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã HV";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstHocVien);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage1.Size = new System.Drawing.Size(598, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách học viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstHocVien
            // 
            this.lstHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstHocVien.ForeColor = System.Drawing.Color.Blue;
            this.lstHocVien.FormattingEnabled = true;
            this.lstHocVien.ItemHeight = 19;
            this.lstHocVien.Location = new System.Drawing.Point(5, 4);
            this.lstHocVien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstHocVien.Name = "lstHocVien";
            this.lstHocVien.Size = new System.Drawing.Size(588, 446);
            this.lstHocVien.TabIndex = 12;
            this.lstHocVien.SelectedIndexChanged += new System.EventHandler(this.lstHocVien_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grbThongTin);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabPage2.Size = new System.Drawing.Size(409, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin chi tiết";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnTruoc);
            this.grbThongTin.Controls.Add(this.btnSau);
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
            this.grbThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTin.ForeColor = System.Drawing.Color.Blue;
            this.grbThongTin.Location = new System.Drawing.Point(5, 4);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grbThongTin.Size = new System.Drawing.Size(399, 286);
            this.grbThongTin.TabIndex = 13;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin học viên";
            this.grbThongTin.Enter += new System.EventHandler(this.grbThongTin_Enter);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 91);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(417, 326);
            this.tabControl1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 91);
            this.label1.TabIndex = 13;
            this.label1.Text = "DANH SÁCH HỌC VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(57, 226);
            this.btnSau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(53, 34);
            this.btnSau.TabIndex = 10;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(6, 226);
            this.btnTruoc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(53, 34);
            this.btnTruoc.TabIndex = 11;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 417);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin học viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLaSinhVien;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnThoát;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label labNS;
        private System.Windows.Forms.Label lbaPhai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbaHoTen;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstHocVien;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnSau;
    }
}

