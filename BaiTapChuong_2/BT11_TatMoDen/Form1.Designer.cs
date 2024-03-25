
namespace BT11_TatMoDen
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.picLightOff = new System.Windows.Forms.PictureBox();
            this.picLightOn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLightOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightOn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(80, 54);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(156, 26);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.btnTen_TextChanged);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(46, 347);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(190, 35);
            this.btnOnOff.TabIndex = 3;
            this.btnOnOff.Text = "Tắt Mở đèn";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(155, 403);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 31);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // picLightOff
            // 
            this.picLightOff.Image = global::BT11_TatMoDen.Properties.Resources.LightOFF;
            this.picLightOff.Location = new System.Drawing.Point(46, 92);
            this.picLightOff.Name = "picLightOff";
            this.picLightOff.Size = new System.Drawing.Size(190, 244);
            this.picLightOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLightOff.TabIndex = 5;
            this.picLightOff.TabStop = false;
            this.picLightOff.Visible = false;
            // 
            // picLightOn
            // 
            this.picLightOn.Image = global::BT11_TatMoDen.Properties.Resources.LightON;
            this.picLightOn.Location = new System.Drawing.Point(46, 92);
            this.picLightOn.Name = "picLightOn";
            this.picLightOn.Size = new System.Drawing.Size(190, 244);
            this.picLightOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLightOn.TabIndex = 2;
            this.picLightOn.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(290, 477);
            this.Controls.Add(this.picLightOff);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.picLightOn);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng Tắt Mở đèn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLightOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.PictureBox picLightOn;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox picLightOff;
    }
}

