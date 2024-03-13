using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhapSo_Click(object sender, EventArgs e)
        {
            if(txtNhapSo.Text==null)
            {
                MessageBox.Show("Bạn cần phải nhập Số!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNhapSo.Focus();
                return;
            }   
            if(int.TryParse(txtNhapSo.Text,out int kq)==false)
            {
                MessageBox.Show("Bạn cần phải nhập Số!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                KhoiTaoTextbox();
                return;
            }
            lstSo.Items.Add(txtNhapSo.Text);
            KhoiTaoTextbox();
        }

        private void KhoiTaoTextbox()
        {
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        private void btnTongSo_Click(object sender, EventArgs e)
        {
            int sum=0;
            for(int i=0;i<lstSo.Items.Count;i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                sum += x;
            }
            MessageBox.Show("Tổng các số là : " + sum, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            lstSo.Items.Clear();
            txtNhapSo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstSo.Items.Clear();
            lstSo.Items.Add(4);
            lstSo.Items.Add(6);
            lstSo.Items.Add(3);
            lstSo.Items.Add(7);
            lstSo.Items.Add(9);
            lstSo.Items.Add(1);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnXoaPhanTuChon_Click(object sender, EventArgs e)
        {
            if(lstSo.SelectedIndex==-1)
            {
                MessageBox.Show("Bạn chưa chọn phần tử", "Thông báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            lstSo.Items.Remove(lstSo.SelectedIndex);
            lstSo.Items.Remove(lstSo.SelectedItem);
        }

        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            if(lstSo.Items.Count==0)
            {
                MessageBox.Show("Bạn phải tạo danh sách", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                lstSo.Items[i] = x + 2;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Bạn phải tạo danh sách", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                lstSo.Items[i] = x *x;
            }
        }

        private void btnChonSoChan_Click(object sender, EventArgs e)
        {
            if (lstSo.Items.Count == 0)
            {
                MessageBox.Show("Bạn phải tạo danh sách", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = Convert.ToInt32(lstSo.Items[i]);
                if(x%2==0)
                lstSo.SelectedIndex = i;
            }
        }
    }
}
