using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bt09
{
    public partial class Form1 : Form
    {
        List<LopHoc> LopHocs;
        List<HocVien> HocViens;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoComboBox();
            KhoiTaoListBox();
        }

        private void KhoiTaoListBox()
        {
            lstHocVien.DataSource = null;
            lstHocVien.DisplayMember = "HoTen";
            lstHocVien.ValueMember = "MaHV";
            lstHocVien.DataSource = HocViens;
        }

        private void KhoiTaoComboBox()
        {
            cboLopHoc.DisplayMember = "TenLH";
            cboLopHoc.ValueMember = "MaLH";
            cboLopHoc.DataSource = LopHocs;
        }

        private void KhoiTaoDuLieu()
        {
            LopHocs = new List<LopHoc>
            {
                new LopHoc {MaLH="L01",TenLH="Lập Trình Windowns",HocPhi=1000000},
                new LopHoc {MaLH="L02",TenLH="Cơ sở dữ liệu",HocPhi=2000000},
                new LopHoc {MaLH="L03",TenLH="Lập trình hướng đối tượng",HocPhi=3000000},
                new LopHoc {MaLH="L04",TenLH="Tin học",HocPhi=4000000},

            };
            HocViens = new List<HocVien>
            {
                new HocVien {MaHV=1,HoTen="Nguyễn Văn Nam",MaLH="L01",LaSV=true,ThanhTien=900000},
                new HocVien {MaHV=2,HoTen="Nguyễn Văn Thanh",MaLH="L01",LaSV=true,ThanhTien=900000},
                new HocVien {MaHV=3,HoTen="Nguyễn Thị Hiền",MaLH="L01",LaSV=false,ThanhTien=1000000},
                new HocVien {MaHV=4,HoTen="Trần Văn Dực",MaLH="L02",LaSV=true,ThanhTien=1800000},
                new HocVien {MaHV=5,HoTen="Trần Thị Em",MaLH="L02",LaSV=false,ThanhTien=2000000},
                new HocVien {MaHV=6,HoTen="Bùi Thị Tuyết",MaLH="L02",LaSV=true,ThanhTien=1800000},
                new HocVien {MaHV=7,HoTen="Nguyễn Thanh Phúc",MaLH="L03",LaSV=true,ThanhTien=2700000},
                new HocVien {MaHV=8,HoTen="Trần Thanh Vinh",MaLH="L03",LaSV=false,ThanhTien=3000000},
                new HocVien {MaHV=9,HoTen="Nguyễn Thanh Kim",MaLH="L04",LaSV=true,ThanhTien=3600000},
                new HocVien {MaHV=10,HoTen="Nguyễn Văn Phải",MaLH="L04",LaSV=false,ThanhTien=4000000},
            };
        }

        private void lstHocVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHocVien.SelectedIndex == -1) return;
            HocVien hv = lstHocVien.SelectedItem as HocVien;
            GanDuLieu(hv);
        }

        private void GanDuLieu(HocVien hv)
        {
            txtMaHV.Text = hv.MaHV.ToString();
            txtHoTen.Text = hv.HoTen;
            chkLaSinhVien.Checked = hv.LaSV;
            cboLopHoc.SelectedValue = hv.MaLH;
            lblThanhTien.Text = hv.ThanhTien.ToString("#,##0 VND");
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopHoc.SelectedIndex == -1) return;
            LopHoc lh = cboLopHoc.SelectedItem as LopHoc;
            double thanhtien = lh.HocPhi * (chkLaSinhVien.Checked == true ? 0.9 : 1);
            lblThanhTien.Text = thanhtien.ToString("#,##0 VND");
        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void chkLaSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            cboLopHoc_SelectedIndexChanged(sender, e);
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtMaHV.ReadOnly = false;

            foreach (Control ctl in grbThongTin.Controls)
            {
                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
            }
            txtMaHV.Focus();
            chkLaSinhVien.Checked = true;
            cboLopHoc_SelectedIndexChanged(sender, e);
        }
    }
}
