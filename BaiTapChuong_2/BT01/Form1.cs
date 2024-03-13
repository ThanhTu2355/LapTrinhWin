using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Close();
        }

        private void butHo_Click(object sender, EventArgs e)
        {
            if (txtHoDem.Text == "")
                MessageBox.Show("Họ không được bỏ trống!", "Thông báo lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            else
                lblKetQua.Text = txtHoDem.Text;
        }

        private void butTen_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
                MessageBox.Show("Họ không được bỏ trống!", "Thông báo lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            else
                lblKetQua.Text = txtTen.Text;
        }
        private void butHoTen_Click(object sender, EventArgs e)
        {
            if (txtHoDem.Text == "")
            {
                MessageBox.Show("Họ không được bỏ trống!", "Thông báo lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtHoDem.Focus();
            }
            else if(txtTen.Text=="")
            {
                if (txtTen.Text == "")
                    MessageBox.Show("Tên không được bỏ trống!", "Thông báo lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtTen.Focus();
            }else
                lblKetQua.Text = txtHoDem.Text + txtTen.Text;
        }

        private void butTiep_Click(object sender, EventArgs e)
        {
            txtHoDem.Text = "";
            txtTen.Text = "";
            lblKetQua.Text = "";
            txtHoDem.Focus();
        }
    }
}
