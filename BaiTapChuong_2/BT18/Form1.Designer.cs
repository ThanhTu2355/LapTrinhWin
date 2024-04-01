
namespace BT18
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
            this.lswSinhVien = new System.Windows.Forms.ListView();
            this.MaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LopHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lswSinhVien
            // 
            this.lswSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSV,
            this.HoTen,
            this.LopHoc});
            this.lswSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lswSinhVien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lswSinhVien.FullRowSelect = true;
            this.lswSinhVien.GridLines = true;
            this.lswSinhVien.HideSelection = false;
            this.lswSinhVien.Location = new System.Drawing.Point(0, 70);
            this.lswSinhVien.MultiSelect = false;
            this.lswSinhVien.Name = "lswSinhVien";
            this.lswSinhVien.Size = new System.Drawing.Size(611, 296);
            this.lswSinhVien.TabIndex = 1;
            this.lswSinhVien.UseCompatibleStateImageBehavior = false;
            this.lswSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // MaSV
            // 
            this.MaSV.Text = "MaSV";
            this.MaSV.Width = 120;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ Tên SV";
            this.HoTen.Width = 370;
            // 
            // LopHoc
            // 
            this.LopHoc.Text = "Lớp học";
            this.LopHoc.Width = 120;
            // 
            // cboKhoa
            // 
            this.cboKhoa.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(253, 26);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(217, 27);
            this.cboKhoa.TabIndex = 2;
            this.cboKhoa.SelectedIndexChanged += new System.EventHandler(this.cboKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn Khoa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.lswSinhVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinh viên theo Khoa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lswSinhVien;
        private System.Windows.Forms.ColumnHeader MaSV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader LopHoc;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label1;
    }
}

