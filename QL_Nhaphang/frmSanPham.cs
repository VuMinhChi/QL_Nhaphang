using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QL_Nhaphang
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private object txtMaLoai;

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QL_Nhaphang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            LoadComboboxBoSuaTap();
            LoadComboboxLoaiSp();
            HienThi();
        }
        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM Tbl_SanPham";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DSSanPham.DataSource = dt;
            dr.Close();
        }
        public void LoadComboboxBoSuaTap()
        {
            string sqlSELECT = "SELECT * FROM Tbl_BoSuuTap";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbxMaBST.DisplayMember = "TenBST";
            cbxMaBST.ValueMember = "MaBST";
            cbxMaBST.DataSource = dt;
            dr.Close();
        }
        public void LoadComboboxLoaiSp()
        {
            string sqlSELECT = "SELECT * FROM Tbl_LoaiSanPham";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbxMaLoai.DisplayMember = "TenLoai";
            cbxMaLoai.ValueMember = "MaLoai";
            cbxMaLoai.DataSource = dt;
            dr.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string sqlINSET = "INSERT INTO Tbl_SanPham VALUES(@MaSP, @TenSP, @SoLuong, @MaLoai, @MaBST, @HinhAnh, @KichThuoc, @DonGia)";
            
            SqlCommand cmd = new SqlCommand(sqlINSET, con);
            cmd.Parameters.AddWithValue("MaSP", txtMa.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTen.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("MaLoai", cbxMaLoai.SelectedValue);
            cmd.Parameters.AddWithValue("MaBST", cbxMaBST.SelectedValue);
            byte[] byteImg = ImageToByteArray(picAnh.Image, picAnh);

            cmd.Parameters.AddWithValue("HinhAnh", byteImg);
            cmd.Parameters.AddWithValue("KichThuoc", txtKichthuoc.Text);
            cmd.Parameters.AddWithValue("DonGia", txtDonGia.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE Tbl_SanPham SET TenSP = @TenSP, SoLuong = @SoLuong, MaLoai = @MaLoai, MaBST = @MaBST, HinhAnh = @HinhAnh, KichThuoc = @KichThuoc, DonGia = @DonGia WHERE MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("MaSP", txtMa.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTen.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("MaLoai", cbxMaLoai.SelectedValue);
            cmd.Parameters.AddWithValue("MaBST", cbxMaBST.SelectedValue);
            byte[] byteImg = ImageToByteArray(picAnh.Image, picAnh);

            cmd.Parameters.AddWithValue("HinhAnh", byteImg);
            cmd.Parameters.AddWithValue("KichThuoc", txtKichthuoc.Text);
            cmd.Parameters.AddWithValue("DonGia", txtDonGia.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM Tbl_SanPham WHERE MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MaSP", txtMa.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTen.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("MaLoai", cbxMaLoai.SelectedValue);
            cmd.Parameters.AddWithValue("MaBST", cbxMaBST.SelectedValue);
            byte[] byteImg = ImageToByteArray(picAnh.Image, picAnh);

            cmd.Parameters.AddWithValue("HinhAnh", byteImg);
            cmd.Parameters.AddWithValue("KichThuoc", txtKichthuoc.Text);
            cmd.Parameters.AddWithValue("DonGia", txtDonGia.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "SELECT * FROM Tbl_SanPham WHERE MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("MaSP", txtMa.Text);
            cmd.Parameters.AddWithValue("TenSP", txtTen.Text);
            cmd.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
            cmd.Parameters.AddWithValue("MaLoai", cbxMaLoai.SelectedValue);
            cmd.Parameters.AddWithValue("MaBST", cbxMaBST.SelectedValue);
            byte[] byteImg = ImageToByteArray(picAnh.Image, picAnh);
            cmd.Parameters.AddWithValue("HinhAnh", byteImg);
            cmd.Parameters.AddWithValue("KichThuoc", txtKichthuoc.Text);
            cmd.Parameters.AddWithValue("DonGia", txtDonGia.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DSSanPham.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Choose Image";
            openFileDialog1.Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog1.FileName);
                picAnh.Image = img;// resizeImage(img);

            }
        }
        public byte[] ImageToByteArray(Image img, PictureBox pictureBoxCompanyLogo)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if (pictureBoxCompanyLogo.Image != null)
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            return ms.ToArray();
        }
    }
}
