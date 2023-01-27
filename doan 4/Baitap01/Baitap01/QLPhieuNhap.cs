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
    public partial class QLPhieuNhap : Form
    {
         string strcon = @"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True";
        SqlConnection sqlcon = null;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        //string setvt;
        void loaddata()
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select * from QLPN";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlcon.Close();
        }
        public QLPhieuNhap()
        {
            InitializeComponent();
            loaddata();
            ngay();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect.updateData("insert into QLPN values('" + mpn.Text + "','" + nn.Text + "','" + mnv.SelectedValue.ToString() + "','" + tt.Text + "')");                
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ngay()
        {
            DateTime dt = DateTime.Now;
            nn.Text = dt.Day + "/" + dt.Month + "/" + dt.Year;
            nn.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect.updateData(" update QLPN set NgayNhap ='" + nn.Text + "',MaNV='" + mnv.SelectedValue.ToString() + "',TongTien='" + tt.Text + "' where MaPn='" + mpn.Text + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect.updateData("delete from QLPN where MaPN='" + mpn.Text + "'");
               
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select * from QLPN where MaPN ='"+timkiem.Text+"'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlcon.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mpn.ResetText();
            mpn.Enabled = true;
            ngay();
            mnv.ResetText();
            tt.ResetText();

            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select * from QLPN" ;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlcon.Close();
        }
        public static string mapn;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            mpn.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            mapn = mpn.Text;
            mpn.Enabled = false;
            nn.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mnv.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Close();
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            ChiTietPN ct = new ChiTietPN();
            ct.Show();
        }

        private void QLPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chvlxdDBDataSet.QLNV' table. You can move, or remove it, as needed.
            this.qLNVTableAdapter.Fill(this.chvlxdDBDataSet.QLNV);

        }
    }
}
