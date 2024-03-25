using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT11_TatMoDen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTen_TextChanged(object sender, EventArgs e)
        {
            btnOnOff.Text = txtTen.Text + " " + (picLightOn.Visible ? "Tắt" : "Bật" + " đèn");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if(picLightOn.Visible)
            {
                picLightOn.Visible = false;
                picLightOff.Visible = true;
                btnOnOff.Text = btnOnOff.Text.Replace("Tắt", "Bật");
            } 
            else
            {
                picLightOn.Visible = true;
                picLightOff.Visible = false;
                btnOnOff.Text = btnOnOff.Text.Replace("Bật", "Tắt");
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnOnOff.Text = txtTen.Text + " " + (picLightOn.Visible ? "Tắt" : "Bật" +" đèn");
        }
    }
}
