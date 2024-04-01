
namespace BT19_TreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvwPhongKhoa = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNut = new System.Windows.Forms.TextBox();
            this.btnThemGoc = new System.Windows.Forms.Button();
            this.btnThemCon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoaNut = new System.Windows.Forms.Button();
            this.imgHinh = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvwPhongKhoa
            // 
            this.tvwPhongKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.tvwPhongKhoa.Location = new System.Drawing.Point(0, 0);
            this.tvwPhongKhoa.Name = "tvwPhongKhoa";
            this.tvwPhongKhoa.Size = new System.Drawing.Size(384, 278);
            this.tvwPhongKhoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nút";
            // 
            // txtNut
            // 
            this.txtNut.Location = new System.Drawing.Point(66, 297);
            this.txtNut.Name = "txtNut";
            this.txtNut.Size = new System.Drawing.Size(292, 27);
            this.txtNut.TabIndex = 2;
            // 
            // btnThemGoc
            // 
            this.btnThemGoc.Location = new System.Drawing.Point(28, 354);
            this.btnThemGoc.Name = "btnThemGoc";
            this.btnThemGoc.Size = new System.Drawing.Size(87, 31);
            this.btnThemGoc.TabIndex = 3;
            this.btnThemGoc.Text = "Thêm gốc";
            this.btnThemGoc.UseVisualStyleBackColor = true;
            this.btnThemGoc.Click += new System.EventHandler(this.btnThemGoc_Click);
            // 
            // btnThemCon
            // 
            this.btnThemCon.Location = new System.Drawing.Point(121, 354);
            this.btnThemCon.Name = "btnThemCon";
            this.btnThemCon.Size = new System.Drawing.Size(84, 31);
            this.btnThemCon.TabIndex = 4;
            this.btnThemCon.Text = "Thêm con";
            this.btnThemCon.UseVisualStyleBackColor = true;
            this.btnThemCon.Click += new System.EventHandler(this.btnThemCon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(290, 354);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(67, 31);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoaNut
            // 
            this.btnXoaNut.Location = new System.Drawing.Point(211, 354);
            this.btnXoaNut.Name = "btnXoaNut";
            this.btnXoaNut.Size = new System.Drawing.Size(73, 31);
            this.btnXoaNut.TabIndex = 5;
            this.btnXoaNut.Text = "Xoá nút";
            this.btnXoaNut.UseVisualStyleBackColor = true;
            this.btnXoaNut.Click += new System.EventHandler(this.btnXoaNut_Click);
            // 
            // imgHinh
            // 
            this.imgHinh.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgHinh.ImageStream")));
            this.imgHinh.TransparentColor = System.Drawing.Color.Transparent;
            this.imgHinh.Images.SetKeyName(0, "1.jpg");
            this.imgHinh.Images.SetKeyName(1, "2.jpg");
            this.imgHinh.Images.SetKeyName(2, "3.jpg");
            this.imgHinh.Images.SetKeyName(3, "4.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 410);
            this.Controls.Add(this.btnXoaNut);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemCon);
            this.Controls.Add(this.btnThemGoc);
            this.Controls.Add(this.txtNut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvwPhongKhoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết kế TreeView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwPhongKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNut;
        private System.Windows.Forms.Button btnThemGoc;
        private System.Windows.Forms.Button btnThemCon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoaNut;
        private System.Windows.Forms.ImageList imgHinh;
    }
}

