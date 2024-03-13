
namespace BT01
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
            this.lblTen = new System.Windows.Forms.Label();
            this.lblHoDem = new System.Windows.Forms.Label();
            this.txtHoDem = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.butHo = new System.Windows.Forms.Button();
            this.butTen = new System.Windows.Forms.Button();
            this.butHoTen = new System.Windows.Forms.Button();
            this.butTiep = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.butThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(29, 56);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(36, 20);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên";
            // 
            // lblHoDem
            // 
            this.lblHoDem.AutoSize = true;
            this.lblHoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoDem.Location = new System.Drawing.Point(29, 26);
            this.lblHoDem.Name = "lblHoDem";
            this.lblHoDem.Size = new System.Drawing.Size(65, 20);
            this.lblHoDem.TabIndex = 2;
            this.lblHoDem.Text = "Họ đệm";
            // 
            // txtHoDem
            // 
            this.txtHoDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoDem.ForeColor = System.Drawing.Color.Red;
            this.txtHoDem.Location = new System.Drawing.Point(103, 23);
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(320, 26);
            this.txtHoDem.TabIndex = 0;
            this.txtHoDem.Text = "Trần Thị Hồng";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.Red;
            this.txtTen.Location = new System.Drawing.Point(103, 56);
            this.txtTen.Name = "txtTen";
            this.txtTen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTen.Size = new System.Drawing.Size(320, 26);
            this.txtTen.TabIndex = 1;
            this.txtTen.Text = "Loan";
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.Blue;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.White;
            this.lblKetQua.Location = new System.Drawing.Point(35, 92);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(388, 73);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "Trần Thị Hồng Loan";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butHo
            // 
            this.butHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHo.Location = new System.Drawing.Point(32, 180);
            this.butHo.Name = "butHo";
            this.butHo.Size = new System.Drawing.Size(69, 44);
            this.butHo.TabIndex = 2;
            this.butHo.Text = "Họ";
            this.butHo.UseVisualStyleBackColor = true;
            this.butHo.Click += new System.EventHandler(this.butHo_Click);
            // 
            // butTen
            // 
            this.butTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTen.Location = new System.Drawing.Point(112, 180);
            this.butTen.Name = "butTen";
            this.butTen.Size = new System.Drawing.Size(69, 44);
            this.butTen.TabIndex = 3;
            this.butTen.Text = "Tên";
            this.butTen.UseVisualStyleBackColor = true;
            this.butTen.Click += new System.EventHandler(this.butTen_Click);
            // 
            // butHoTen
            // 
            this.butHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHoTen.Location = new System.Drawing.Point(192, 180);
            this.butHoTen.Name = "butHoTen";
            this.butHoTen.Size = new System.Drawing.Size(69, 44);
            this.butHoTen.TabIndex = 4;
            this.butHoTen.Text = "Họ Tên";
            this.butHoTen.UseVisualStyleBackColor = true;
            this.butHoTen.Click += new System.EventHandler(this.butHoTen_Click);
            // 
            // butTiep
            // 
            this.butTiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTiep.Location = new System.Drawing.Point(272, 180);
            this.butTiep.Name = "butTiep";
            this.butTiep.Size = new System.Drawing.Size(69, 44);
            this.butTiep.TabIndex = 5;
            this.butTiep.Text = "Tiếp";
            this.butTiep.UseVisualStyleBackColor = true;
            this.butTiep.Click += new System.EventHandler(this.butTiep_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(454, 188);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 44);
            this.button5.TabIndex = 10;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // butThoat
            // 
            this.butThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butThoat.Location = new System.Drawing.Point(352, 180);
            this.butThoat.Name = "butThoat";
            this.butThoat.Size = new System.Drawing.Size(69, 44);
            this.butThoat.TabIndex = 6;
            this.butThoat.Text = "Thoát";
            this.butThoat.UseVisualStyleBackColor = true;
            this.butThoat.Click += new System.EventHandler(this.butThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(450, 405);
            this.Controls.Add(this.butThoat);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.butTiep);
            this.Controls.Add(this.butHoTen);
            this.Controls.Add(this.butTen);
            this.Controls.Add(this.butHo);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoDem);
            this.Controls.Add(this.lblHoDem);
            this.Controls.Add(this.lblTen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình hiển thị Họ Tên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblHoDem;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button butHo;
        private System.Windows.Forms.Button butTen;
        private System.Windows.Forms.Button butHoTen;
        private System.Windows.Forms.Button butTiep;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button butThoat;
    }
}

