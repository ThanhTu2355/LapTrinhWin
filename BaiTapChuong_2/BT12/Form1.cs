using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT12
{
    public partial class Form1 : Form
    {
        int stt = 0;
        string duongDan = @"..\..\..\DanhSachHinh\";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stt = 1;
            picHinhAnh.Image = Image.FromFile(duongDan + stt + ".jpg");
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            lblStt.Text = stt.ToString();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            stt --;
            picHinhAnh.Image = Image.FromFile(duongDan + stt + ".jpg");
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            lblStt.Text = stt.ToString();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (stt == 5)
                stt = (stt == 5) ? 5 : 1;
            else
                stt++;
            picHinhAnh.Image = Image.FromFile(duongDan + stt + ".jpg");
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            lblStt.Text = stt.ToString();
        }
    }
}
