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
    public partial class QLSP : Form
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
            cmd.CommandText = "select * from QLSP";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlcon.Close();
        }
        public QLSP()
        {
            InitializeComponent();
            loaddata();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLLSP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chvlxdDBDataSet.QLNCC' table. You can move, or remove it, as needed.
            this.qLNCCTableAdapter.Fill(this.chvlxdDBDataSet.QLNCC);
            // TODO: This line of code loads data into the 'chvlxdDBDataSet.QLLoaiSP' table. You can move, or remove it, as needed.
            this.qLLoaiSPTableAdapter.Fill(this.chvlxdDBDataSet.QLLoaiSP);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                try
                {
                    sqlcon = new SqlConnection(strcon);
                    sqlcon.Open();
                    string qr = "insert into QLSP values('" + txtmsp.Text + "','" + txttsp.Text + "','" + txtlsp.SelectedValue.ToString() + "','" + txtmncc.SelectedValue.ToString() + "','" + txtg.Text + "')";
                    SqlCommand qrcmd = new SqlCommand(qr, sqlcon);
                    qrcmd.ExecuteNonQuery();
                    loaddata();
                    sqlcon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select * from QLSP where MaSP= '"+ txttk.Text+ "' or TenSP like '%"+txttk.Text+"%'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlcon.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon = new SqlConnection(strcon);
                sqlcon.Open();
                string sua = " update QLSP set TenSP ='" + txttsp.Text + "',MaLSP='" + txtlsp.SelectedValue.ToString() + "',MaNCC='" + txtmncc.SelectedValue.ToString() + "',Gia='" + txtg.Text + "'where MaSp = '" +txtmsp.Text + "'";
                SqlCommand cmdsua = new SqlCommand(sua, sqlcon);
                cmdsua.ExecuteNonQuery();
                loaddata();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon = new SqlConnection(strcon);
                sqlcon.Open();
                string xoa = "delete from QLSP where MaSP='" + txtmsp.Text + "'";
                SqlCommand cmdxoa = new SqlCommand(xoa, sqlcon);
                cmdxoa.ExecuteNonQuery();
                loaddata();
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtmncc.ResetText();
                txtlsp.ResetText();
                txttsp.ResetText();
                txtg.ResetText();
                txtmsp.ResetText();
                txttk.ResetText();
                txtmsp.Enabled = true;
                sqlcon = new SqlConnection(strcon);
                sqlcon.Open();
                cmd = sqlcon.CreateCommand();
                cmd.CommandText = "select * from QLSP";
                adapter.SelectCommand = cmd;
                table.Clear();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                sqlcon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtmsp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtmsp.Enabled = false;
            txttsp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtlsp.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmncc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtg.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Close();
        }
    }
}
