using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT19_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tvwPhongKhoa.ImageList = imgHinh;
            TreeNode NutGocKhoa = new TreeNode();
            NutGocKhoa.Text = "Danh Sách Khoa";
            NutGocKhoa.ImageIndex = 0;
            NutGocKhoa.SelectedImageIndex = 1;
            tvwPhongKhoa.Nodes.Add(NutGocKhoa);

            TreeNode NutCon_CNTT = new TreeNode("Khoa Công nghệ thông tin", 2, 3);
            NutGocKhoa.Nodes.Add(NutCon_CNTT);
            TreeNode NutCon_Dien = new TreeNode("Khoa Công nghệ điện & Điện tử", 2, 3);
            NutGocKhoa.Nodes.Add(NutCon_Dien);
            TreeNode NutCon_KT = new TreeNode("Khoa Kinh tế", 2, 3);
            NutGocKhoa.Nodes.Add(NutCon_KT);

            tvwPhongKhoa.ImageList = imgHinh;
            TreeNode NutGocPhong = new TreeNode();
            NutGocPhong.Text = "Danh Sách Phòng";
            NutGocPhong.ImageIndex = 0;
            NutGocPhong.SelectedImageIndex = 1;
            tvwPhongKhoa.Nodes.Add(NutGocPhong);

            TreeNode NutCon_PDD = new TreeNode("Phòng đào tạo", 2, 3);
            NutGocPhong.Nodes.Add(NutCon_PDD);
            TreeNode NutCon_TCKT = new TreeNode("Phòng Tài chính kế toán", 2, 3);
            NutGocPhong.Nodes.Add(NutCon_TCKT);
        }

        private void btnThemGoc_Click(object sender, EventArgs e)
        {
            if (txtNut.Text == "") return;
            TreeNode NutThem = new TreeNode(txtNut.Text, 0, 1);
            tvwPhongKhoa.Nodes.Add(NutThem);
        }

        private void btnThemCon_Click(object sender, EventArgs e)
        {
            if (txtNut.Text == "") return;
            TreeNode NutChon = tvwPhongKhoa.SelectedNode;
            TreeNode NutThem = new TreeNode(txtNut.Text, 2, 3);
            NutChon.Nodes.Add(NutThem);
        }

        private void btnXoaNut_Click(object sender, EventArgs e)
        {
            TreeNode NutXoa = tvwPhongKhoa.SelectedNode;
            if (NutXoa.Level == 0)
                tvwPhongKhoa.Nodes.Remove(NutXoa);
            else if (NutXoa.Level > 0)
            {
                TreeNode NutCha = NutXoa.Parent;
                NutCha.Nodes.Remove(NutXoa);
            }
        }
    }
}
