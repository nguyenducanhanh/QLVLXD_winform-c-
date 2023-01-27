using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap01
{
    public partial class CTHD : Form
    {
        string strcon = @"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True";
        SqlConnection sqlcon = null;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        public CTHD()
        {
            InitializeComponent();
            loaddata();
        }
        string mahd = QLHD.laymahd;
        void loaddata()
        {
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select CTHD.MaSP,QLSP.TenSP,CTHD.SoLuong,(CTHD.SoLuong*QLSP.Gia) as DonGia from CTHD, QLSP where CTHD.MaSP = QLSP.MaSP and MaHD = '" + mahd + "'";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlcon.Close();
            
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CTHD_Load(object sender, EventArgs e)
        {

        }
    }
}
