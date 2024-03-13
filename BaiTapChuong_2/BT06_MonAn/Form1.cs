using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT06_MonAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtMonAn.Text == "")
            {
                MessageBox.Show("Bạn phải nhập món ăn!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lstThucDon.Items.Add(txtMonAn.Text);
            txtMonAn.Clear();
            txtMonAn.Focus();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            lstThucDon.Items.Add("Cơm tấm");
            lstThucDon.Items.Add("Hủ tiếu");
            lstThucDon.Items.Add("Phở bò");
            lstThucDon.Items.Add("Bún bò");
            lstThucDon.Items.Add("Cháo lòng");
            lstThucDon.Items.Add("Bánh mì");
            lstThucDon.Items.Add("Gà rán");
            txtMonAn.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lstThucDon.SelectedIndex==-1)
                MessageBox.Show("Bạn phải chọn món ăn!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            for (int i = 0; i < lstThucDon.SelectedItems.Count; i++)
                LstMonAn.Items.Add(lstThucDon.SelectedItems[i]);

            while (lstThucDon.SelectedItems.Count > 0)
                lstThucDon.Items.Remove(lstThucDon.SelectedItems[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LstMonAn.SelectedIndex == -1)
                MessageBox.Show("Bạn phải chọn món ăn!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            for (int i = 0; i < LstMonAn.SelectedItems.Count; i++)
                lstThucDon.Items.Add(LstMonAn.SelectedItems[i]);

            while (LstMonAn.SelectedItems.Count > 0)
                LstMonAn.Items.Remove(LstMonAn.SelectedItems[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstThucDon.Items.Count; i++)
                LstMonAn.Items.Add(lstThucDon.Items[i]);
            lstThucDon.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LstMonAn.Items.Count; i++)
                lstThucDon.Items.Add(LstMonAn.Items[i]);
            LstMonAn.Items.Clear();
        }
    }
}
