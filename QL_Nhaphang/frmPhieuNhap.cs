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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private object txtMaPhieu;

        public object Functions { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSET = "INSERT INTO tbl_PhieuNhap VALUES (@MaPhieu, @MaNV, @NgayLap) ";
            SqlCommand cmd = new SqlCommand(sqlINSET, con);
            cmd.Parameters.AddWithValue("MaPhieu", txtMa.Text);
            cmd.Parameters.AddWithValue("MaNV", cbxMaNV.SelectedValue);
            cmd.Parameters.AddWithValue("NgayLap", dateTimePicker1.MinDate);
            cmd.ExecuteNonQuery();
            HienThi(); 
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QL_Nhaphang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            LoadComboboxMaNV();
            HienThi();
        }

        private void frmPhieuNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM Tbl_PhieuNhap";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DSPhieunhap.DataSource = dt;
            dr.Close();
        }
        public void LoadComboboxMaNV()
        {
            string sqlSELECT = "SELECT * FROM Tbl_NhanVien";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbxMaNV.DisplayMember = "MaNV";
            cbxMaNV.ValueMember = "MaNV";
            cbxMaNV.DataSource = dt;
            dr.Close();
        }
        /*public void LoadComboboxMaSP()
        {
            string sqlSELECT = "SELECT * FROM Tbl_SanPham";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbxMaSP.DisplayMember = "MaSP";
            cbxMaSP.ValueMember = "MaSP";
            cbxMaSP.DataSource = dt;
            dr.Close();
        }
        */
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlTimKiem = "SELECT * FROM tbl_PhieuNhap WHERE MaPhieu = @MaPhieu ";

            SqlCommand cmd = new SqlCommand(sqlTimKiem, con);
            cmd.Parameters.AddWithValue("MaPhieu", txtMa.Text);
            cmd.Parameters.AddWithValue("MaNV", cbxMaNV.SelectedValue);
            cmd.Parameters.AddWithValue("NgayLap", dateTimePicker1.MinDate);
            cmd.ExecuteNonQuery();
            HienThi();
        }
    }
}
