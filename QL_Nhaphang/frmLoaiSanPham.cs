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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void frmLoaiSanPham_Load_1(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QL_Nhaphang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }
        private void frmLoaiSanPham_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM Tbl_LoaiSanPham";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DSLoaiSP.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSET = "INSERT INTO Tbl_LoaiSanPham VALUES(@MaLoai, @TenLoai)";
            SqlCommand cmd = new SqlCommand(sqlINSET, con);
            cmd.Parameters.AddWithValue("MaLoai", txtMaL.Text);
            cmd.Parameters.AddWithValue("TenLoai", txtTenL.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE Tbl_LoaiSanPham SET TenLoai = @TenLoai WHERE MaLoai = @MaLoai";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("MaLoai", txtMaL.Text);
            cmd.Parameters.AddWithValue("TenLoai", txtTenL.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM Tbl_LoaiSanPham WHERE MaLoai = @MaLoai";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MaLoai", txtMaL.Text);
            cmd.Parameters.AddWithValue("TenLoai", txtTenL.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlTimkiem = "SELECT* FROM Tbl_LoaiSanPham WHERE MaLoai = @MaLoai";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, con);
            cmd.Parameters.AddWithValue("MaLoai", txtMaCanTim.Text);
            cmd.Parameters.AddWithValue("TenLoai", txtTenL.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DSLoaiSP.DataSource = dt;
        }
    }
}
