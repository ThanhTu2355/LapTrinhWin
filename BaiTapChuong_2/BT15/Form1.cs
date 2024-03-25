using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT15
{
    public partial class Form1 : Form
    {
        public const int DonGia = 1000;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpNgayDat.Format = DateTimePickerFormat.Custom;
            dtpNgayDat.CustomFormat = "dd/MM/yyyy";
            dtpNgayDat.MinDate = DateTime.Today;
            dtpNgayDat.MaxDate = new DateTime(DateTime.Today.Year, 12, 31);
            dtpNgayDat.Value = DateTime.Today;

            nmuSoLuong.Maximum = 10;
            nmuSoLuong.Minimum = 1;
            nmuSoLuong.Increment = 1;

            dmuLoaiVe.Items.Add("NOR");
            dmuLoaiVe.Items.Add("ECO");
            dmuLoaiVe.Items.Add("VIP");
            dmuLoaiVe.SelectedIndex = 0;

            txtThanhTien.Enabled = false;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in grbQLVe.Controls)
                if (ctl is TextBox)
                    (ctl as TextBox).Clear();
                else if (ctl is DateTimePicker)
                    (ctl as DateTimePicker).Value = DateTime.Today;
                else if (ctl is CheckBox)
                    (ctl as CheckBox).Checked = true;
                else if (ctl is NumericUpDown)
                    (ctl as NumericUpDown).Value = 1;
                else if (ctl is DomainUpDown)
                    (ctl as DomainUpDown).SelectedIndex = 0;
            txtTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            double thanhTien;
            thanhTien = (double)nmuSoLuong.Value * DonGia *
                      (dmuLoaiVe.Text == "VIP" ? 1.5 : (dmuLoaiVe.Text == "ECO" ? 1.2 : 1)) *
                      (chkLaSinhVien.Checked == true ? 0.9 : 1);
            txtThanhTien.Text = thanhTien.ToString("#,##0 VND");
        }
    }
}
