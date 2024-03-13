
namespace BT04
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
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnNhapSo = new System.Windows.Forms.Button();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTongSo = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnXoaPhanTuChon = new System.Windows.Forms.Button();
            this.btnChonSoChan = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapSo.Location = new System.Drawing.Point(23, 50);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(59, 16);
            this.lblNhapSo.TabIndex = 0;
            this.lblNhapSo.Text = "Nhập số";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(83, 46);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(154, 20);
            this.txtNhapSo.TabIndex = 1;
            // 
            // btnNhapSo
            // 
            this.btnNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapSo.Location = new System.Drawing.Point(243, 41);
            this.btnNhapSo.Name = "btnNhapSo";
            this.btnNhapSo.Size = new System.Drawing.Size(89, 30);
            this.btnNhapSo.TabIndex = 2;
            this.btnNhapSo.Text = "Nhập số";
            this.btnNhapSo.UseVisualStyleBackColor = true;
            this.btnNhapSo.Click += new System.EventHandler(this.btnNhapSo_Click);
            // 
            // lstSo
            // 
            this.lstSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 16;
            this.lstSo.Location = new System.Drawing.Point(26, 86);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSo.Size = new System.Drawing.Size(186, 244);
            this.lstSo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChonSoChan);
            this.groupBox1.Controls.Add(this.btnTangLen2);
            this.groupBox1.Controls.Add(this.btnBinhPhuong);
            this.groupBox1.Controls.Add(this.btnXoaPhanTuChon);
            this.groupBox1.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox1.Controls.Add(this.btnTongSo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(233, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng";
            // 
            // btnTongSo
            // 
            this.btnTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongSo.Location = new System.Drawing.Point(6, 19);
            this.btnTongSo.Name = "btnTongSo";
            this.btnTongSo.Size = new System.Drawing.Size(216, 29);
            this.btnTongSo.TabIndex = 0;
            this.btnTongSo.Text = "Tổng các số";
            this.btnTongSo.UseVisualStyleBackColor = true;
            this.btnTongSo.Click += new System.EventHandler(this.btnTongSo_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(6, 57);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(216, 29);
            this.btnXoaDauCuoi.TabIndex = 1;
            this.btnXoaDauCuoi.Text = "Xoá PT đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinhPhuong.Location = new System.Drawing.Point(6, 133);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(216, 29);
            this.btnBinhPhuong.TabIndex = 3;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnXoaPhanTuChon
            // 
            this.btnXoaPhanTuChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhanTuChon.Location = new System.Drawing.Point(6, 95);
            this.btnXoaPhanTuChon.Name = "btnXoaPhanTuChon";
            this.btnXoaPhanTuChon.Size = new System.Drawing.Size(216, 29);
            this.btnXoaPhanTuChon.TabIndex = 2;
            this.btnXoaPhanTuChon.Text = "Xoá PT chọn";
            this.btnXoaPhanTuChon.UseVisualStyleBackColor = true;
            this.btnXoaPhanTuChon.Click += new System.EventHandler(this.btnXoaPhanTuChon_Click);
            // 
            // btnChonSoChan
            // 
            this.btnChonSoChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonSoChan.Location = new System.Drawing.Point(6, 209);
            this.btnChonSoChan.Name = "btnChonSoChan";
            this.btnChonSoChan.Size = new System.Drawing.Size(216, 29);
            this.btnChonSoChan.TabIndex = 5;
            this.btnChonSoChan.Text = "Chọn các số chẵn";
            this.btnChonSoChan.UseVisualStyleBackColor = true;
            this.btnChonSoChan.Click += new System.EventHandler(this.btnChonSoChan_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTangLen2.Location = new System.Drawing.Point(6, 171);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(216, 29);
            this.btnTangLen2.TabIndex = 4;
            this.btnTangLen2.Text = "Tăng phần tử lên 2";
            this.btnTangLen2.UseVisualStyleBackColor = true;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nhập tự động";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(568, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSo);
            this.Controls.Add(this.btnNhapSo);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lblNhapSo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnNhapSo;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChonSoChan;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnXoaPhanTuChon;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTongSo;
        private System.Windows.Forms.Button button1;
    }
}

