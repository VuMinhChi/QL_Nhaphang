using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Nhaphang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNhanVien  Danhmucnhanvien = new frmNhanVien();
            Danhmucnhanvien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSanPham Danhmucsanpham = new frmSanPham();
            Danhmucsanpham.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham Danhmucloaisanpham = new frmLoaiSanPham();
            Danhmucloaisanpham.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBoSuuTap DanhmucBST = new frmBoSuuTap();
            DanhmucBST.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmPhieuNhap DanhmucPhieuNhap = new frmPhieuNhap();
            DanhmucPhieuNhap.Show();
        }
    }
}
