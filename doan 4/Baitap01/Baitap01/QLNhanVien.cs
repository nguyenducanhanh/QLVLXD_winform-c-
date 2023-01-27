﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Baitap01
{
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {

            SqlConnection conn = new SqlConnection
         (@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True");

            string sql = "SELECT *"
                            + "FROM QLNV";

            SqlDataAdapter adapt = new SqlDataAdapter(sql, conn);  // adapter : chuyển đổi
            DataSet ds = new DataSet();                 // bộ
            adapt.Fill(ds);                          // fill lấp đầy
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button6_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
(@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True");

            string sql = ("SELECT * "
                           + "FROM QLNV" + " WHERE TenNV  LIKE '%"
                       + txtTim.Text + "%'");

            SqlDataAdapter adapt = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "xyz");
            dataGridView1.DataSource = ds.Tables["xyz"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(" insert into QLNV (MaNV, TenNV,GT,SDT,MaCV) values ( @ma, @ten, @gioitinh, @sdt,@mcv)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ma", textBox1.Text);
                cmd.Parameters.AddWithValue("@ten", textBox2.Text);
                cmd.Parameters.AddWithValue("@gioitinh", textBox3.Text);
                cmd.Parameters.AddWithValue("@sdt", textBox4.Text);
                cmd.Parameters.AddWithValue("@mcv", textBox5.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("thêm nhân viên thành công");
                LoadData();
            }catch(Exception ex)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM QLNV WHERE MaNV=@manv", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@manv", textBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("xoá thành công ");
            LoadData();
        }

        private void Reset()
        {
            textBox1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            txtTim.Text = "";
        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            Reset();
            LoadData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(" UPDATE QLNV set TenNV=@ten, GT=@gt,SDT=@sdt , MaCV=@mcv WHERE  MaNV=@ma", conn);
            cmd.Parameters.AddWithValue("@ma", textBox1.Text);
            cmd.Parameters.AddWithValue("@ten", textBox2.Text);
            cmd.Parameters.AddWithValue("@gt", textBox3.Text);
            cmd.Parameters.AddWithValue("@sdt", textBox4.Text);
            cmd.Parameters.AddWithValue("@mcv", textBox5.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("đã sửa thông tin nhân viên thành công");
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            textBox1.Enabled = false;

            textBox1.Text = dataGridView1.Rows[r].Cells["MaNV"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[r].Cells["TenNV"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[r].Cells["GT"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[r].Cells["SDT"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[r].Cells["MaCV"].Value.ToString();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chvlxdDBDataSet.QLCV' table. You can move, or remove it, as needed.
             this.qLCVTableAdapter.Fill(this.chvlxdDBDataSet.QLCV);
        
        }

        private void textBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
    }
}
