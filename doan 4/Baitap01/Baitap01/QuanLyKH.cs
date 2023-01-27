using System;
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
    public partial class QuanLyKH : Form
    {
        public QuanLyKH()
        {
            InitializeComponent();
            LoadData();
          
        }

        private void LoadData()
        {

            SqlConnection conn = new SqlConnection
         (@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True");

            string sql = "SELECT *"
                            + "FROM QLKH";

            SqlDataAdapter adapt = new SqlDataAdapter(sql, conn);  // adapter : chuyển đổi
            DataSet ds = new DataSet();                 // bộ
            adapt.Fill(ds);                          // fill lấp đầy
          dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection
          (@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(" insert into QLKH (MaKH, TenKH,GT,SDT,DC) values ( @ma, @ten, @gioitinh, @sdt,@dc)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@ma", textBox1.Text);
                cmd.Parameters.AddWithValue("@ten", textBox2.Text);
                cmd.Parameters.AddWithValue("@gioitinh", textBox9.Text);
                cmd.Parameters.AddWithValue("@sdt", textBox3.Text);
                cmd.Parameters.AddWithValue("@dc", textBox4.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("thêm khách hàng thành công");
                LoadData();
                Reset();
            }catch(Exception ex)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
    (@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True");

            conn.Open();
            SqlCommand cmd = new SqlCommand(" UPDATE QLKH set TenKH=@ten, GT=@gt,SDT=@sdt,DC=@dc WHERE  MaKH=@ma", conn);
            cmd.Parameters.AddWithValue("@ma", textBox1.Text);
            cmd.Parameters.AddWithValue("@ten", textBox2.Text);
            cmd.Parameters.AddWithValue("@gt", textBox9.Text);
            cmd.Parameters.AddWithValue("@sdt", textBox3.Text);
            cmd.Parameters.AddWithValue("@dc", textBox4.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("đã sửa thông tin khách hàng thành công");
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
   (@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True");

            string sql = ("SELECT * "
                           + "FROM QLKH" + " WHERE TenKH  LIKE '%"
                       + textBox5.Text + "%'");

            SqlDataAdapter adapt = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "xyz");
                       dataGridView1.DataSource = ds.Tables["xyz"];

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[r].Cells["MaKH"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[r].Cells["TenKH"].Value.ToString();
            textBox9.Text = dataGridView1.Rows[r].Cells["GT"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[r].Cells["SDT"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[r].Cells["DC"].Value.ToString();
            textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
    (@"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM QLKH WHERE MaKH=@manv", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@manv", textBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("xoá thành công ");
            LoadData();
            Reset();
        }

        private void Reset()
        {

            textBox1.Text = "";
            textBox2.Text ="";
            textBox9.Text = "";
            textBox3.Text ="";
            textBox4.Text = "";
            textBox1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reset();
            textBox5.Text = "";
            LoadData();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Close();
        }

        private void QuanLyKH_Load(object sender, EventArgs e)
        {

        }
    }
}
