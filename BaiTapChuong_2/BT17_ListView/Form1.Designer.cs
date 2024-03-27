
namespace BT17_ListView
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
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtLopHoc = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lswSinhVien
            // 
            this.lswSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaSV,
            this.HoTen,
            this.LopHoc});
            this.lswSinhVien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lswSinhVien.FullRowSelect = true;
            this.lswSinhVien.GridLines = true;
            this.lswSinhVien.HideSelection = false;
            this.lswSinhVien.Location = new System.Drawing.Point(12, 90);
            this.lswSinhVien.MultiSelect = false;
            this.lswSinhVien.Name = "lswSinhVien";
            this.lswSinhVien.Size = new System.Drawing.Size(612, 296);
            this.lswSinhVien.TabIndex = 0;
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
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Vinhan", 8.25F);
            this.txtMaSV.Location = new System.Drawing.Point(12, 61);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(121, 23);
            this.txtMaSV.TabIndex = 1;
            // 
            // txtLopHoc
            // 
            this.txtLopHoc.Font = new System.Drawing.Font("Vinhan", 8.25F);
            this.txtLopHoc.Location = new System.Drawing.Point(503, 61);
            this.txtLopHoc.Name = "txtLopHoc";
            this.txtLopHoc.Size = new System.Drawing.Size(121, 23);
            this.txtLopHoc.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Vinhan", 8.25F);
            this.txtHoTen.Location = new System.Drawing.Point(139, 61);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(358, 23);
            this.txtHoTen.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 414);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtLopHoc);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lswSinhVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lswSinhVien;
        private System.Windows.Forms.ColumnHeader MaSV;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader LopHoc;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtLopHoc;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}

