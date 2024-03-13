using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaSinhVien.ReadOnly==false)
            {
                SinhVien sv = new SinhVien();
                sv.MaVS = txtMaSinhVien.Text;
                sv.HoTenSV = txtHoTen.Text;
                sv.HocBong = int.Parse(txtHocBong.Text.Replace(",", "").Replace("$", ""));
                lstSinhVien.Items.Add(sv);
                lstSinhVien.SelectedIndex = lstSinhVien.Items.IndexOf(sv);
                txtMaSinhVien.ReadOnly = true;
            }
            else
            {
                SinhVien sv = lstSinhVien.SelectedItem as SinhVien;
                sv.HoTenSV = txtHoTen.Text;
                sv.HocBong= int.Parse(txtHocBong.Text.Replace(",", "").Replace("$", ""));
                lstSinhVien.Items[lstSinhVien.SelectedIndex] = sv;
                txtMaSinhVien.ReadOnly = true;

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
            SinhVien sv = lstSinhVien.SelectedItem as SinhVien;
            txtMaSinhVien.Text = sv.MaVS;
            txtHoTen.Text = sv.HoTenSV;
            txtHocBong.Text = sv.HocBong.ToString("#,##0$");
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            //txtMaSinhVien.Clear();
            //txtHoTen.Clear();
            //txtHocBong.Clear();
            //txtMaSinhVien.Focus();
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
            txtMaSinhVien.Focus();
            txtMaSinhVien.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sv1 = new SinhVien();
            sv1.MaVS = "A01";
            sv1.HoTenSV = "Nguyễn Thanh Tú";
            sv1.HocBong = 2500000;
            lstSinhVien.Items.Add(sv1);
            SinhVien sv2 = new SinhVien();
            sv2.MaVS = "A02";
            sv2.HoTenSV = "Trần Thanh Tuấn";
            sv2.HocBong = 2000000;
            lstSinhVien.Items.Add(sv2);
            SinhVien sv3 = new SinhVien();
            sv3.MaVS = "A03";
            sv3.HoTenSV = "Lê Văn Thành Đạt";
            sv3.HocBong = 1500000;
            lstSinhVien.Items.Add(sv3);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedIndex == -1)
                return;
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá sinh viên: " + txtHoTen.Text, "Xoá sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tl==DialogResult.Yes)
            {
                lstSinhVien.Items.Remove(lstSinhVien.SelectedItem);
                lstSinhVien.SelectedIndex = 0;
            }    
        }
    }
}
