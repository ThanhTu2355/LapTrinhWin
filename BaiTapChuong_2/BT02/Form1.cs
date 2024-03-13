using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtHeSoA.Clear();
            txtHeSoB.Clear();
            txtKetQua.Clear();
            txtHeSoA.Focus();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int hesoa, hesob;
            string nghiem;

            if (int.TryParse(txtHeSoA.Text, out hesoa)==false)
            {
                MessageBox.Show("Hệ số A không phải kiểu số. Nhập lại", "Báo lỗi kiểu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeSoA.Clear();
                txtHeSoA.Focus();
                return;
            }
            if (int.TryParse(txtHeSoB.Text, out hesob) == false)
            {
                MessageBox.Show("Hệ số B không phải kiểu số. Nhập lại", "Báo lỗi kiểu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeSoB.Clear();
                txtHeSoB.Focus();
                return;
            }

            if (hesoa == 0)
                if (hesob == 0)
                    nghiem = "Phương trình vô số nghiệm";
                else nghiem = "Phương trình vô nghiệm";
            else nghiem = "Phương trình có nghiệm X = " + (float)(-hesob) / hesoa;
            txtKetQua.Text = nghiem;
        }
    }
}
