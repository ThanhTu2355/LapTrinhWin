using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT08_HocVien
{
    public partial class Form1 : Form
    {
        List<LopHoc> LopHocs;
        List<HocVien> HocViens;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoComboBox();
            KhoiTaoListBox();
        }

        private void KhoiTaoListBox()
        {
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
                new HocVien {MaHV=1,HoTen="Nguyễn Văn Nam",MaLH="L01"},
                new HocVien {MaHV=2,HoTen="Nguyễn Văn Thanh",MaLH="L01"},
                new HocVien {MaHV=3,HoTen="Nguyễn Thị Hiền",MaLH="L01"},
                new HocVien {MaHV=4,HoTen="Trần Văn Dực",MaLH="L02"},
                new HocVien {MaHV=5,HoTen="Trần Thị Em",MaLH="L02"},
                new HocVien {MaHV=6,HoTen="Bùi Thị Tuyết",MaLH="L02"},
                new HocVien {MaHV=7,HoTen="Nguyễn Thanh Phúc",MaLH="L03"},
                new HocVien {MaHV=8,HoTen="Trần Thanh Vinh",MaLH="L03"},
                new HocVien {MaHV=9,HoTen="Nguyễn Thanh Kim",MaLH="L04"},
                new HocVien {MaHV=10,HoTen="Nguyễn Văn Phải",MaLH="L04"},
            };
        }
    }
}
