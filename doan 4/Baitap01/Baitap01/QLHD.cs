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
    public partial class QLHD : Form
    {
        string strcon = @"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True";
        SqlConnection sqlcon = null;
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void LoadData()
        {
            sqlcon = new SqlConnection(strcon);
            string sql = "SELECT * FROM QLHD";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, sqlcon);  
            DataSet ds = new DataSet();                 
            adapt.Fill(ds);                          
            dataGridView2.DataSource = ds.Tables[0];
        }
        public QLHD()
        {
            InitializeComponent();
            LoadData();
        }
        
        int taomahd()
        {
            int ma;
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = "select count(*) from QLHD";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            ma = table.Rows[0].Field<int>(0);
            sqlcon.Close();
            return ma + 1;
        }
        private void btnlhd_Click(object sender, EventArgs e)
        {
            laymahd ="HD"+ taomahd();
            sqlcon.Open();
            string qr = "insert into QLHD(MaHD) values('" + laymahd + "')";
            cmd = new SqlCommand(qr, sqlcon);
            cmd.ExecuteNonQuery();
            LoadData();
            sqlcon.Close();
            LapHD lhd = new LapHD();
            lhd.Show();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Close();
        }
        private void btnLM_Click(object sender, EventArgs e)
        {
            txttim.Text = "";
            LoadData();
        }

        private void btnxemchitiet_Click(object sender, EventArgs e)
        {
            CTHD ct = new CTHD();
            ct.Show();
        }
        public static string laymahd;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView2.CurrentRow.Index;
            laymahd = dataGridView2.Rows[i].Cells[0].Value.ToString();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            sqlcon = new SqlConnection(strcon);
            string sql = "SELECT * FROM QLHD WHERE MAHD='"+txttim.Text+"' OR MAKH='"+txttim.Text+"'";
            SqlDataAdapter adapt = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void QLHD_Load(object sender, EventArgs e)
        {

        }
    }
}
