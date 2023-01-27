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
    public partial class LapHD : Form
    {
        string strcon = @"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True";
        SqlConnection sqlcon = null;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public LapHD()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            txtngay.Text = dt.Day + "/" + dt.Month + "/" + dt.Year;
            txtmahd.Text = mahd;
        }
        string mahd = QLHD.laymahd;
        private void LoadData()
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select CTHD.MaSP,QLSP.TenSP,CTHD.SoLuong,(CTHD.SoLuong*QLSP.Gia) as DonGia from CTHD, QLSP where CTHD.MaSP = QLSP.MaSP and MaHD = '" + mahd+"'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlcon.Close();
            double tt = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                tt = tt + Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            txttt.Text = tt.ToString();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DBConnect.updateData("delete from CTHD where MaHD='" + txtmahd.Text + "'");
            
            DBConnect.updateData("delete from QLHD where MaHD='" + txtmahd.Text + "'");
            
            this.Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            cbmsp.Text = dataGridView1.Rows[r].Cells["TenSP"].Value.ToString();
            cbmsp.Enabled = false;
            txtsl.Text = dataGridView1.Rows[r].Cells["SoLuong"].Value.ToString();
            txtdg.Text = dataGridView1.Rows[r].Cells["DonGia"].Value.ToString();
        }
        string tensp;
        float gia;
        void getTen()
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select TenSP from QLSP where MaSP='" + cbmsp.SelectedValue.ToString() + "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            tensp = table.Rows[0].Field<string>(0);
            //gia = table.Rows[0].Field<float>(1);
            //float dg = int.Parse(txtsl.Text)*gia;
            //txtdg.Text = dg.ToString();
            sqlcon.Close();
        }
        void tinh()
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            SqlCommand command = sqlcon.CreateCommand();
            command.CommandText = "select TenSP,Gia from QLSP where MaSP='" + cbmsp.SelectedValue.ToString() + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            tensp = table.Rows[0].Field<string>(0);
            gia = table.Rows[0].Field<float>(1);
            sqlcon.Close();
        }
        void tinhtien()
        {
            sqlcon = new SqlConnection(strcon);
            DataTable tb = new DataTable();
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select sum(CTHD.SoLuong*QLSP.Gia) as TongTien from CTHD,QLSP where CTHD.MaSP = QLSP.MaSP and MaHD='" + mahd + "'";
            adapter.SelectCommand = cmd;
            tb.Clear();
            adapter.Fill(tb);
            //txttt.Text = table.Rows[0].Field<float>(0).ToString();
            sqlcon.Close();
            double tt = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                tt = tt + Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);

            }
            txttt.Text = tt.ToString();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (cbmsp.Text == "")
                MessageBox.Show("Chưa chọn sản phẩm cần thêm!");
            else if (txtsl.Text == "")
                MessageBox.Show("Chưa có số lượng!");
            else if (Convert.ToInt32(txtsl.Text) <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0!");
            else
            {
                bool c = checksp(cbmsp.SelectedValue.ToString());
                if (c == true)
                    MessageBox.Show("Sản phẩm này đã được thêm rồi!");
                else
                {
                    DBConnect.updateData("insert into CTHD values('" + mahd + "','" + cbmsp.SelectedValue.ToString() + "','" + txtsl.Text + "')");
                    LoadData();
                    Reset();
                }
            }
        }
        Boolean checksp(string sp)
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            string qr = "select MaSP from CTHD where MaHD='" + txtmahd.Text + "' and MaSP='" + sp + "'";
            SqlCommand command = new SqlCommand(qr, sqlcon);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
            {
                sqlcon.Close();
                return true;
            }
            else
            {
                sqlcon.Close();
                return false;
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (cbmsp.Text == "")
                MessageBox.Show("Chưa chọn sản phẩm cần sửa!");
            else if(txtsl.Text == "")
                MessageBox.Show("Chưa có số lượng!");
            else if (Convert.ToInt32(txtsl.Text) <= 0)
                MessageBox.Show("Số lượng phải lớn hơn 0!");
            else
            {
                DBConnect.updateData("update CTHD set SoLuong='" + txtsl.Text + "' where MaHD='" + txtmahd.Text + "' and MaSP='" + cbmsp.SelectedValue.ToString() + "'");
                LoadData();
                Reset();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (cbmsp.Text == "")
                MessageBox.Show("Chưa chọn sản phẩm cần xoá!");
            else
            {
                DBConnect.updateData("delete from CTHD where MaHD='" + txtmahd.Text + "' and MaSP='" + cbmsp.SelectedValue.ToString() + "'");
                LoadData();
                Reset();
            }
        }
        private void Reset()
        {
            cbmsp.Enabled = true;
            cbmsp.Text = "";
            txtsl.Text = "";
            txtdg.Text = "";
        }
        private void btnLM_Click(object sender, EventArgs e)
        {
            Reset();
            LoadData();
        }

        private void btnlaphd_Click(object sender, EventArgs e)
        {
            DBConnect.updateData("update QLHD set MaKH='" + cbmakh.SelectedValue.ToString() + "',NgayLap='" + txtngay.Text + "',ThanhTien='" + txttt.Text + "' where MaHD='" + txtmahd.Text + "'");
            this.Close();
        }

        private void LapHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chvlxdDBDataSet.QLKH' table. You can move, or remove it, as needed.
            this.qLKHTableAdapter.Fill(this.chvlxdDBDataSet.QLKH);
            // TODO: This line of code loads data into the 'chvlxdDBDataSet.QLSP' table. You can move, or remove it, as needed.
            this.qLSPTableAdapter.Fill(this.chvlxdDBDataSet.QLSP);

        }
    }
}
