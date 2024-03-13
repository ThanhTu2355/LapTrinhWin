using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT07
{
    public partial class Form1 : Form
    {
        List<LopHoc> LopHocs;
        List<HocVien> hocViens;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoCombobox();
        }
        private void KhoiTaoCombobox()
        {
            cboLopHoc.DisplayMember = "TenLH";
            cboLopHoc.ValueMember = "MaLH";
            cboLopHoc.DataSource = LopHocs;
        }

        private void KhoiTaoDuLieu()
        {
            LopHocs = new List<LopHoc>
            {
                new LopHoc {MaLH="L01",TenLH="Lập Trình Windowns"},
                new LopHoc {MaLH="L02",TenLH="Cơ sở dữ liệu"},
                new LopHoc {MaLH="L03",TenLH="Lập trình hướng đối tượng"},
                new LopHoc {MaLH="L04",TenLH="Tin học"},

            };
            hocViens = new List<HocVien>
            {
                new HocVien {MaHV="1",HoTen="Nguyễn Văn Nam",Phai=true,NgaySinh=new DateTime(2005,1,1),DiaChi="Đồng Tháp",MaLH="L01"},
                new HocVien {MaHV="2",HoTen="Nguyễn Văn Thanh",Phai=true,NgaySinh=new DateTime(2005,1,2),DiaChi="An Giang",MaLH="L01"},
                new HocVien {MaHV="3",HoTen="Nguyễn Thị Hiền",Phai=false,NgaySinh=new DateTime(2005,1,3),DiaChi="Tiền Giang",MaLH="L01"},
                new HocVien {MaHV="4",HoTen="Trần Văn Dực",Phai=true,NgaySinh=new DateTime(2005,1,4),DiaChi="Hậu Giang",MaLH="L02"},
                new HocVien {MaHV="5",HoTen="Trần Thị Em",Phai=false,NgaySinh=new DateTime(2005,1,5),DiaChi="Vĩnh Long",MaLH="L02"},
                new HocVien {MaHV="6",HoTen="Bùi Thị Tuyết",Phai=false,NgaySinh=new DateTime(2005,1,6),DiaChi="Đồng Tháp",MaLH="L02"},
                new HocVien {MaHV="7",HoTen="Nguyễn Thanh Phúc",Phai=true,NgaySinh=new DateTime(2005,1,7),DiaChi="Bến Tre",MaLH="L03"},
                new HocVien {MaHV="8",HoTen="Trần Thanh Vinh",Phai=true,NgaySinh=new DateTime(2005,1,8),DiaChi="Trà Vinh",MaLH="L03"},
                new HocVien {MaHV="9",HoTen="Nguyễn Thanh Kim",Phai=false,NgaySinh=new DateTime(2005,1,9),DiaChi="Cà Mau",MaLH="L04"},
                new HocVien {MaHV="10",HoTen="Nguyễn Văn Phải",Phai=true,NgaySinh=new DateTime(2005,1,10),DiaChi="Sóc Trăng",MaLH="L04"},
            };
        }

        private void lstHocVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopHoc.SelectedIndex == -1) return;
            string ml = cboLopHoc.SelectedValue.ToString();
            List<HocVien> dsHocVienTheoLop = new List<HocVien>();
            foreach (HocVien hv in hocViens)
                if (hv.MaLH == ml)
                    dsHocVienTheoLop.Add(hv);
            lstHocVien.DisplayMember = "HoTen";
            lstHocVien.ValueMember = "MaHV";
            lstHocVien.DataSource = dsHocVienTheoLop;
        }
    }
}
