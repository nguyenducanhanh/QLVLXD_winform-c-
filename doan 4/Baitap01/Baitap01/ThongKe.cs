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
    public partial class ThongKe : Form
    {
        string strcon = @"Data Source=MACBOOK\SQLEXPRESS;Initial Catalog=chvlxdDataBase;Integrated Security=True";
        SqlConnection sqlcon = null;
        public ThongKe()
        {
            InitializeComponent();
            txtnamt.Enabled = false;
            cbthang.Enabled = false;
            txtnamq.Enabled = false;
            cbquy.Enabled = false;
            txtnamn.Enabled = false;
        }
        void loaddata(string sql)
        {
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            cmd = sqlcon.CreateCommand();
            cmd.CommandText = sql;
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            sqlcon.Close();
            double tt = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                tt = tt + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            txttt.Text = tt.ToString();
        }
        int ktrb=0;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked.Equals(true))
            {
                txtnamt.Enabled = true;
                cbthang.Enabled = true;
                ktrb = 1;
            }
            else
            {
                txtnamt.Enabled = false;
                cbthang.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked.Equals(true))
            {
                txtnamq.Enabled = true;
                cbquy.Enabled = true;
                ktrb = 2;
            }
            else
            {
                txtnamq.Enabled = false;
                cbquy.Enabled = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked.Equals(true))
            {
                txtnamn.Enabled = true;
                ktrb = 3;
            }
            else
            {
                txtnamn.Enabled = false;
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if (kt==0)
            {
                if (ktrb==1)
                {
                    loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and NgayNhap like '%/"+cbthang.Text+"/"+txtnamt.Text+"%' group by ctpn.MaSP");
                }
                else if (ktrb==2)
                {
                    if (cbquy.SelectedIndex.Equals(0))
                    {
                        loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and(NgayNhap like '%/1/" + txtnamq.Text + "%' or NgayNhap like '%2/" + txtnamq.Text + "%' or NgayNhap like '%3/" + txtnamq.Text + "%') group by ctpn.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(1))
                    {
                        loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and(NgayNhap like '%/4/" + txtnamq.Text + "%' or NgayNhap like '%5/" + txtnamq.Text + "%' or NgayNhap like '%6/" + txtnamq.Text + "%') group by ctpn.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(2))
                    {
                        loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and(NgayNhap like '%/7/" + txtnamq.Text + "%' or NgayNhap like '%8/" + txtnamq.Text + "%' or NgayNhap like '%9/" + txtnamq.Text + "%') group by ctpn.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(3))
                    {
                        loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and(NgayNhap like '%/10/" + txtnamq.Text + "%' or NgayNhap like '%11/" + txtnamq.Text + "%' or NgayNhap like '%12/" + txtnamq.Text + "%') group by ctpn.MaSP");
                    }
                }
                else if (ktrb==3)
                {
                    loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and NgayNhap like '%"+txtnamn.Text+"%' group by ctpn.MaSP");
                }
                else
                {
                    MessageBox.Show("Yêu cầu chọn kiểu thống kê!");
                }
            }
            else if (kt==1)
            {
                if (ktrb == 1)
                {
                    loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá' from CTHD,QLSP,QLHD where CTHD.MaSP = QLSP.MaSP and CTHD.MaHD = QLHD.MaHD and NgayLap like '%/" + cbthang.Text + "/" + txtnamt.Text + "%' group by CTHD.MaSP");
                }
                else if (ktrb == 2)
                {
                    if (cbquy.SelectedIndex.Equals(0))
                    {
                        loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá'  from CTHD,QLSP,QLHD where CTHD.MaSP=QLSP.MaSP and CTHD.MaHD=QLHD.MaHD and (NgayLap like '%1/" + txtnamq.Text + "%' or NgayLap like '%2/" + txtnamq.Text + "%' or NgayLap like '%3/" + txtnamq.Text + "%') group by CTHD.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(1))
                    {
                        loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá'  from CTHD,QLSP,QLHD where CTHD.MaSP=QLSP.MaSP and CTHD.MaHD=QLHD.MaHD and (NgayLap like '%4/" + txtnamq.Text + "%' or NgayLap like '%5/" + txtnamq.Text + "%' or NgayLap like '%6/" + txtnamq.Text + "%') group by CTHD.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(2))
                    {
                        loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá'  from CTHD,QLSP,QLHD where CTHD.MaSP=QLSP.MaSP and CTHD.MaHD=QLHD.MaHD and (NgayLap like '%7/" + txtnamq.Text + "%' or NgayLap like '%8/" + txtnamq.Text + "%' or NgayLap like '%9/" + txtnamq.Text + "%') group by CTHD.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(3))
                    {
                        loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá'  from CTHD,QLSP,QLHD where CTHD.MaSP=QLSP.MaSP and CTHD.MaHD=QLHD.MaHD and (NgayLap like '%10/" + txtnamq.Text + "%' or NgayLap like '%11/" + txtnamq.Text + "%' or NgayLap like '%12/" + txtnamq.Text + "%') group by CTHD.MaSP");
                    }
                }
                else if (ktrb == 3)
                {
                    loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá' from CTHD,QLSP,QLHD where CTHD.MaSP=QLSP.MaSP and CTHD.MaHD=QLHD.MaHD and NgayLap like '%/" + txtnamn.Text + "%' group by CTHD.MaSP");
                }
                else
                {
                    MessageBox.Show("Yêu cầu chọn kiểu thống kê!");
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu chọn loại thống kê!");
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (kt == 0)
            {
                if (ktrb == 1)
                {
                    loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and NgayNhap like '%/" + cbthang.Text + "/" + txtnamt.Text + "%' and CTPN.MaSP ='" + cbtimkiem.Text + "' group by ctpn.MaSP");
                }
                else if (ktrb == 2)
                {
                    if (cbquy.SelectedIndex.Equals(0))
                    {
                        loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and(NgayNhap like '%/1/" + txtnamq.Text + "%' or NgayNhap like '%2/" + txtnamq.Text + "%' or NgayNhap like '%3/" + txtnamq.Text + "%') and CTPN.MaSP ='" + cbtimkiem.Text + "' group by ctpn.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(1))
                    {
                        loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and(NgayNhap like '%/4/" + txtnamq.Text + "%' or NgayNhap like '%5/" + txtnamq.Text + "%' or NgayNhap like '%6/" + txtnamq.Text + "%') and CTPN.MaSP ='" + cbtimkiem.Text + "' group by ctpn.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(2))
                    {
                        loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and(NgayNhap like '%/7/" + txtnamq.Text + "%' or NgayNhap like '%8/" + txtnamq.Text + "%' or NgayNhap like '%9/" + txtnamq.Text + "%') and CTPN.MaSP ='" + cbtimkiem.Text + "' group by ctpn.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(3))
                    {
                        loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and(NgayNhap like '%/10/" + txtnamq.Text + "%' or NgayNhap like '%11/" + txtnamq.Text + "%' or NgayNhap like '%12/" + txtnamq.Text + "%') and CTPN.MaSP ='" + cbtimkiem.Text + "' group by ctpn.MaSP");
                    }
                }
                else if (ktrb == 3)
                {
                    loaddata("select ctpn.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(DonGia) as 'Đơn giá' from CTPN, QLSP,QLPN where CTPN.MaPN = QLPN.MaPN and CTPN.MaSP = QLSP.MaSP and NgayNhap like '%" + txtnamn.Text + "%' and CTPN.MaSP ='" + cbtimkiem.Text + "' group by ctpn.MaSP");
                }
                else
                {
                    MessageBox.Show("Yêu cầu chọn kiểu thống kê!");
                }
            }
            else if (kt == 1)
            {
                if (ktrb == 1)
                {
                    loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá' from CTHD,QLSP,QLHD where CTHD.MaSP = QLSP.MaSP and CTHD.MaHD = QLHD.MaHD and NgayLap like '%/" + cbthang.Text + "/" + txtnamt.Text + "%' and CTPN.MaSP ='" + cbtimkiem.Text + "' group by CTHD.MaSP");
                }
                else if (ktrb == 2)
                {
                    if (cbquy.SelectedIndex.Equals(0))
                    {
                        loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá'  from CTHD,QLSP,QLHD where CTHD.MaSP=QLSP.MaSP and CTHD.MaHD=QLHD.MaHD and (NgayLap like '%1/" + txtnamq.Text + "%' or NgayLap like '%2/" + txtnamq.Text + "%' or NgayLap like '%3/" + txtnamq.Text + "%') and CTPN.MaSP ='" + cbtimkiem.Text + "' group by CTHD.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(1))
                    {
                        loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá'  from CTHD,QLSP,QLHD where CTHD.MaSP=QLSP.MaSP and CTHD.MaHD=QLHD.MaHD and (NgayLap like '%4/" + txtnamq.Text + "%' or NgayLap like '%5/" + txtnamq.Text + "%' or NgayLap like '%6/" + txtnamq.Text + "%') and CTPN.MaSP ='" + cbtimkiem.Text + "' group by CTHD.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(2))
                    {
                        loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá'  from CTHD,QLSP,QLHD where CTHD.MaSP=QLSP.MaSP and CTHD.MaHD=QLHD.MaHD and (NgayLap like '%7/" + txtnamq.Text + "%' or NgayLap like '%8/" + txtnamq.Text + "%' or NgayLap like '%9/" + txtnamq.Text + "%') and CTPN.MaSP ='" + cbtimkiem.Text + "' group by CTHD.MaSP");
                    }
                    else if (cbquy.SelectedIndex.Equals(3))
                    {
                        loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá'  from CTHD,QLSP,QLHD where CTHD.MaSP=QLSP.MaSP and CTHD.MaHD=QLHD.MaHD and (NgayLap like '%10/" + txtnamq.Text + "%' or NgayLap like '%11/" + txtnamq.Text + "%' or NgayLap like '%12/" + txtnamq.Text + "%') and CTPN.MaSP ='" + cbtimkiem.Text + "' group by CTHD.MaSP");
                    }
                }
                else if (ktrb == 3)
                {
                    loaddata("select CTHD.MaSP as 'Mã sản phẩm',sum(soluong) as 'Số lượng',sum(CTHD.SoLuong*QLSP.Gia) as 'Đơn giá' from CTHD,QLSP,QLHD where CTHD.MaSP=QLSP.MaSP and CTHD.MaHD=QLHD.MaHD and NgayLap like '%/" + txtnamn.Text + "%' and CTPN.MaSP ='" + cbtimkiem.Text + "' group by CTHD.MaSP");
                }
                else
                {
                    MessageBox.Show("Yêu cầu chọn kiểu thống kê!");
                }
            }
            else
            {
                MessageBox.Show("Yêu cầu chọn loại thống kê!");
            }
        }
        int kt = 2;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(0))
            {
                kt = 0;
            }
            else if (comboBox1.SelectedIndex.Equals(1))
            {
                kt = 1;
            }
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chvlxdDBDataSet.QLSP' table. You can move, or remove it, as needed.
            this.qLSPTableAdapter.Fill(this.chvlxdDBDataSet.QLSP);

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            hethong ht = new hethong();
            ht.Show();
            this.Close();
        }
    }
}
