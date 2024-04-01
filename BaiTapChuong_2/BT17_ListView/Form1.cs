using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT17_ListView
{
    public partial class Form1 : Form
    {
        List<SinhVien> SinhViens;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoListView();
            lswSinhVien.Select();
            lswSinhVien.Items[0].Selected = true;
        }

        private void KhoiTaoDuLieu()
        {
            SinhViens = new List<SinhVien>
            {
                new SinhVien {MaSV="A01",HoTen="Nguyễn Văn Nam",MaLH="L01"},
                new SinhVien {MaSV="A02",HoTen="Nguyễn Văn Thanh",MaLH="L01"},
                new SinhVien {MaSV="A03",HoTen="Nguyễn Thị Hiền",MaLH="L01"},
                new SinhVien {MaSV="A04",HoTen="Trần Văn Dực",MaLH="L02"},
                new SinhVien {MaSV="A05",HoTen="Trần Thị Em",MaLH="L02"},
                new SinhVien {MaSV="A06",HoTen="Bùi Thị Tuyết",MaLH="L02"},
                new SinhVien {MaSV="A07",HoTen="Nguyễn Thanh Phúc",MaLH="L03"},
                new SinhVien {MaSV="A08",HoTen="Trần Thanh Vinh",MaLH="L03"},
                new SinhVien {MaSV="A09",HoTen="Nguyễn Thanh Kim",MaLH="L04"},
                new SinhVien {MaSV="A10",HoTen="Nguyễn Văn Phải",MaLH="L04"}

            };
        }

        private void KhoiTaoListView()
        {
            foreach(SinhVien sv in SinhViens)
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = sv.MaSV;
                lv.SubItems.Add(sv.HoTen);
                lv.SubItems.Add(sv.MaLH);
                lswSinhVien.Items.Add(lv);
            }
        }

        private void lswSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lswSinhVien.SelectedItems.Count == 0) return;
            ListViewItem lv = lswSinhVien.SelectedItems[0];
            txtMaSV.Text = lv.Text;
            txtHoTen.Text = lv.SubItems[1].Text;
            txtLopHoc.Text = lv.SubItems[2].Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSV.ReadOnly = false;
            foreach (Control ctl in Controls)
                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
            txtMaSV.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if(txtMaSV.ReadOnly==false)
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = txtMaSV.Text;
                sv.HoTen = txtHoTen.Text;
                sv.MaLH = txtLopHoc.Text;
                SinhViens.Add(sv);

                ListViewItem lv = new ListViewItem(sv.MaSV);
                lv.SubItems.Add(sv.HoTen);
                lv.SubItems.Add(sv.MaLH);
                lswSinhVien.Items.Add(lv);

                lv.Selected = true;
                lswSinhVien.Select();
                txtMaSV.ReadOnly = true;
            }
            else
            {
                SinhVien sv = TimSinhVien(txtMaSV.Text);
                sv.HoTen = txtHoTen.Text;
                sv.MaLH = txtLopHoc.Text;

                ListViewItem lv = lswSinhVien.SelectedItems[0];
                lv.SubItems[1].Text = txtHoTen.Text;
                lv.SubItems[2].Text = txtLopHoc.Text;
                lswSinhVien.Select();
            }    
        }

        private SinhVien TimSinhVien(string MaSV)
        {
            SinhVien kq = null;
            foreach (SinhVien sv in SinhViens)
                if (sv.MaSV == MaSV)
                    return sv;
            return kq;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lswSinhVien.SelectedItems.Count == 0) return;
            DialogResult tl = MessageBox.Show("Bạn có muốn xoá sinh viên này không", "Thông báo xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(tl==DialogResult.Yes)
            {
                SinhVien svXoa = TimSinhVien(txtMaSV.Text);
                SinhViens.Remove(svXoa);
                ListViewItem lvXoa = lswSinhVien.SelectedItems[0];
                lswSinhVien.Items.Remove(lvXoa);
                lswSinhVien.Select();
                lswSinhVien.Items[0].Selected = true;
            }    
        }
    }
}
