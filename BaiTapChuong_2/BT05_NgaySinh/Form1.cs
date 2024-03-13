using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT05_NgaySinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
            txtMaSinhVien.Focus();
            txtMaSinhVien.ReadOnly = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSinhVien.ReadOnly == false)
            {
                NgaySinh sv = new NgaySinh();
                sv.MaVS = txtMaSinhVien.Text;
                sv.HoTenSV = txtHoTen.Text;
                sv.NgaySinhSV = DateTime.Parse(txtNgaySinh.Text);
                lstSinhVien.Items.Add(sv);
                lstSinhVien.SelectedIndex = lstSinhVien.Items.IndexOf(sv);
                txtMaSinhVien.ReadOnly = true;
            }
            else
            {
                NgaySinh sv = lstSinhVien.SelectedItem as NgaySinh;
                sv.HoTenSV = txtHoTen.Text;
                sv.NgaySinhSV = DateTime.Parse(txtNgaySinh.Text);
                lstSinhVien.Items[lstSinhVien.SelectedIndex] = sv;
                txtMaSinhVien.ReadOnly = true;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex == -1)
                return;
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá sinh viên: " + txtHoTen.Text, "Xoá sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                lstSinhVien.Items.Remove(lstSinhVien.SelectedItem);
                lstSinhVien.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstSinhVien.DisplayMember = "HoTenSV";
        }

        private void lstSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex == -1)
                return;
            NgaySinh sv = lstSinhVien.SelectedItem as NgaySinh;
            txtMaSinhVien.Text = sv.MaVS;
            txtHoTen.Text = sv.HoTenSV;
            txtNgaySinh.Text = sv.NgaySinhSV.ToString("d");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NgaySinh sv1 = new NgaySinh();
            sv1.MaVS = "A01";
            sv1.HoTenSV = "Nguyễn Thanh Tú";
            sv1.NgaySinhSV = DateTime.Parse("01/01/2005");
            lstSinhVien.Items.Add(sv1);
            NgaySinh sv2 = new NgaySinh();
            sv2.MaVS = "A02";
            sv2.HoTenSV = "Trần Thanh Tuấn";
            sv2.NgaySinhSV = DateTime.Parse("02/02/2005");
            lstSinhVien.Items.Add(sv2);
            NgaySinh sv3 = new NgaySinh();
            sv3.MaVS = "A03";
            sv3.HoTenSV = "Lê Văn Thành Đạt";
            sv3.NgaySinhSV = DateTime.Parse("03/03/2005");
            lstSinhVien.Items.Add(sv3);
        }
    }
}
