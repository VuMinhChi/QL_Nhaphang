using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QL_Nhaphang
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QL_Nhaphang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM Tbl_NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DSNhanVien.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSET = "INSERT INTO Tbl_NhanVien VALUES(@MaNV, @TenNV, @GioiTinh, @NgaySinh, @DiaChi)";
            SqlCommand cmd = new SqlCommand(sqlINSET, con);
            cmd.Parameters.AddWithValue("MaNV", txtMa.Text);
            cmd.Parameters.AddWithValue("TenNV", txtTen.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txtGioiTinh.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimePicker1.MinDate);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE Tbl_NhanVien SET TenNV = @TenNV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("MaNV", txtMa.Text);
            cmd.Parameters.AddWithValue("TenNV", txtTen.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txtGioiTinh.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimePicker1.MinDate);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM Tbl_SanPham WHERE MaSP = @MaSP";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MaNV", txtMa.Text);
            cmd.Parameters.AddWithValue("TenNV", txtTen.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txtGioiTinh.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimePicker1.MinDate);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "SELECT * FROM Tbl_NhanVien WHERE MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("MaNV", txtMaCanTim.Text);
            cmd.Parameters.AddWithValue("TenNV", txtTen.Text);
            cmd.Parameters.AddWithValue("GioiTinh", txtGioiTinh.Text);
            cmd.Parameters.AddWithValue("NgaySinh", dateTimePicker1.MinDate);
            cmd.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DSNhanVien.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
