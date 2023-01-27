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
    public partial class ChiTietPN : Form
    {
        string strcon = @"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True";
        SqlConnection sqlcon = null;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string mapn = QLPhieuNhap.mapn;
        //string setvt;
        void loaddata()
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select CTPN.MaSP,TenSP,CTPN.MaNCC,TenNCC,SoLuong,(SoLuong*QLSP.Gia) as DonGia " +
                "from CTPN, QLSP, QLNCC where QLSP.MaSP = CTPN.MaSP and CTPN.MaNCC = QLNCC.MaNCC and MaPN='"+mapn+ "' ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlcon.Close();
            tt = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                tt = tt + Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }
        }
        double tt;
        
        void uptt()
        {
            try
            {
                DBConnect.updateData(" update QLPN set TongTien='" + tt + "' where MaPN='" + mpn.Text + "'");
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ChiTietPN()
        {
            InitializeComponent();
            loaddata();
            mpn.Text = mapn;
            mpn.Enabled = false;
        }
        double tinh()
        {
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select (Gia*"+sl.Text+") as TTien from QLSP where MaSP='"+msp.SelectedValue.ToString() + "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            double t= table.Rows[0].Field<double>(0);
            return t;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double t = tinh();
                DBConnect.updateData("insert into CTPN values('" + mpn.Text + "','" + msp.SelectedValue.ToString() + "','" + mncc.SelectedValue.ToString()  + "','" + sl.Text + "','" + t + "')");
                loaddata();
                uptt();
                dg.Text = t.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double t = tinh();
                DBConnect.updateData(" update CTPN set masp ='" + msp.SelectedValue.ToString() + "',mancc='" + mncc.SelectedValue.ToString() + "',soluong='" + sl.Text + "',dongia='" + t + "' where MaPN='" + mpn.Text + "' and MaSP='"+msp.SelectedValue.ToString() + "' ");
                loaddata();
                uptt();
                dg.Text = t.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            msp.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            msp.Enabled = false;
            mncc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            sl.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dg.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnect.updateData("delete from CTPN where Mapn='" + mpn.Text + "' and MaSP='" + msp.SelectedValue.ToString() + "'");
                loaddata();
                uptt();
                rst();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void rst()
        {
            msp.ResetText();
            msp.Enabled = true;
            sl.ResetText();
            mncc.ResetText();
            dg.ResetText();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            rst();
            loaddata();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select CTPN.MaSP,CTPN.MaNCC,TenSP,TenNCC,SoLuong,(SoLuong*QLSP.Gia) as DonGia " +
                "from CTPN, QLSP, QLNCC where QLSP.MaSP = CTPN.MaSP and QLSP.MaNCC = QLNCC.MaNCC and MaPN='" + mapn + "' and CTPN.MaSP='" + timkiem.Text + "' ";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlcon.Close();
        }

        private void ChiTietPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chvlxdDBDataSet.QLSP' table. You can move, or remove it, as needed.
            this.qLSPTableAdapter.Fill(this.chvlxdDBDataSet.QLSP);
            // TODO: This line of code loads data into the 'chvlxdDBDataSet.QLNCC' table. You can move, or remove it, as needed.
            this.qLNCCTableAdapter.Fill(this.chvlxdDBDataSet.QLNCC);

        }
    }
}
