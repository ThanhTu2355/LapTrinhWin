using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT18
{
    public partial class Form1 : Form
    {
        List<Khoa> Khoas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoDuLieu();
            KhoiTaoCombo();
        }

        private void KhoiTaoCombo()
        {
            cboKhoa.DisplayMember = "TenKH";
            cboKhoa.ValueMember = "MaKH";
            cboKhoa.DataSource = Khoas;
        }

        private void KhoiTaoDuLieu()
        {
            Khoas = new List<Khoa>
            {
               new Khoa
               {
                   MaKH="TH",TenKH="Công nghệ thông tin",SinhViens=new List<SinhVien>
                   {
                       new SinhVien {MaSV="A01",HoTen="Nguyễn Văn Nam",MaLH="L01"},
                       new SinhVien {MaSV="A02",HoTen="Nguyễn Văn Thanh",MaLH="L01"},
                       new SinhVien {MaSV="A03",HoTen="Nguyễn Thị Hiền",MaLH="L01"},
                   },
               },
               new Khoa
               {
                   MaKH="OT",TenKH="Sữa chữa Ô tô",SinhViens=new List<SinhVien>
                   {
                       new SinhVien {MaSV="A04",HoTen="Trần Văn Dực",MaLH="L02"},
                       new SinhVien {MaSV="A05",HoTen="Trần Thị Em",MaLH="L02"},
                       new SinhVien {MaSV="A06",HoTen="Bùi Thị Tuyết",MaLH="L02"},
                   },
               },
               new Khoa
               {
                   MaKH="KT",TenKH="Kinh tế",SinhViens=new List<SinhVien>
                   {
                       new SinhVien {MaSV="A07",HoTen="Nguyễn Thanh Phúc",MaLH="L03"},
                       new SinhVien {MaSV="A08",HoTen="Trần Thanh Vinh",MaLH="L03"},
                   },
               },
               new Khoa
               {
                   MaKH="XD",TenKH="Xây dựng",SinhViens=new List<SinhVien>
                   {
                       new SinhVien {MaSV="A09",HoTen="Nguyễn Thanh Kim",MaLH="L04"},
                       new SinhVien {MaSV="A10",HoTen="Nguyễn Văn Phải",MaLH="L04"}
                   },
               },
            };
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoa.SelectedIndex == -1) return;
            Khoa kh = cboKhoa.SelectedItem as Khoa;
            NapDuLieu(kh);
            if (lswSinhVien.Items.Count == 0) return;
            lswSinhVien.Select();
            lswSinhVien.Items[0].Selected = true;
        }

        private void NapDuLieu(Khoa kh)
        {
            lswSinhVien.Items.Clear();

            foreach(SinhVien sv in kh.SinhViens)
            {
                ListViewItem lvThem = new ListViewItem(sv.MaSV);
                lvThem.SubItems.Add(sv.HoTen);
                lvThem.SubItems.Add(sv.MaLH);
                lswSinhVien.Items.Add(lvThem);
            }
        }
    }
}
