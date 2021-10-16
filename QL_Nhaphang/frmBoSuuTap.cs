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
    public partial class frmBoSuuTap : Form
    {
        public frmBoSuuTap()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void frmBoSuuTap_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["QL_Nhaphang"].ConnectionString.ToString();
            con = new SqlConnection(conString);
            con.Open();
            HienThi();
        }

        private void frmBoSuuTap_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
        public void HienThi()
        {
            string sqlSELECT = "SELECT * FROM Tbl_BoSuuTap";
            SqlCommand cmd = new SqlCommand(sqlSELECT, con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DSBst.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlINSET = "INSERT INTO Tbl_BoSuuTap VALUES(@MaBST, @TenBST)";
            SqlCommand cmd = new SqlCommand(sqlINSET, con);
            cmd.Parameters.AddWithValue("MaBST", txtMa.Text);
            cmd.Parameters.AddWithValue("TenBST", txtTen.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlEDIT = "UPDATE Tbl_BoSuuTap SET TenBST = @TenBST WHERE MaBST = @MaBST";
            SqlCommand cmd = new SqlCommand(sqlEDIT, con);
            cmd.Parameters.AddWithValue("MaBST", txtMa.Text);
            cmd.Parameters.AddWithValue("TenBST", txtTen.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlDELETE = "DELETE FROM Tbl_BoSuuTap WHERE MaBST = @MaBST";
            SqlCommand cmd = new SqlCommand(sqlDELETE, con);
            cmd.Parameters.AddWithValue("MaBST", txtMa.Text);
            cmd.Parameters.AddWithValue("TenBST", txtTen.Text);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlTimkiem = "SELECT* FROM Tbl_BoSuuTap WHERE MaBST = @MaBST";
            SqlCommand cmd = new SqlCommand(sqlTimkiem, con);
            cmd.Parameters.AddWithValue("MaBST", txtMaCanTim.Text);
            cmd.Parameters.AddWithValue("TenBST", txtTen.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DSBst.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
