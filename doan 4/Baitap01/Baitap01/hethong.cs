﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap01
{
    public partial class hethong : Form
    {
        public hethong()
        {
            InitializeComponent();
            if (q != 1)
            {
                itemQLTK.Enabled = false;
                itemQLNS.Enabled = false;
                itemQLMH.Enabled = false;
                itemNCC.Enabled = false;
                itemthongke.Enabled = false;
            }
        }
        int q = Login.pq;
        string nv = Login.nv;
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login dn = new Login();
            dn.Show();
            this.Close();
        }

        private void quảnLýHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHD hd = new QLHD();
            hd.Show();
            this.Hide();
        }

        private void itemCC_Click(object sender, EventArgs e)
        {
            ChamCong cc = new ChamCong();
            cc.Show();
            this.Hide();
        }

        private void itemQLTK_Click(object sender, EventArgs e)
        {
            QLTK tk = new QLTK();
            tk.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMK dmk = new DoiMK();
            dmk.Show();
        }

        private void itemSP_Click(object sender, EventArgs e)
        {
            QLSP sp = new QLSP();
            sp.Show();
            this.Hide();
        }

        private void itemLSP_Click(object sender, EventArgs e)
        {
            QLLSP lsp = new QLLSP();
            lsp.Show();
            this.Hide();
        }

        private void itemKH_Click(object sender, EventArgs e)
        {
            QuanLyKH kh = new QuanLyKH();
            kh.Show();
            this.Hide();
        }

        private void itemNV_Click(object sender, EventArgs e)
        {
            QLNhanVien nv = new QLNhanVien();
            nv.Show();
            this.Hide();
        }

        private void itemCV_Click(object sender, EventArgs e)
        {
            ChucVu cv = new ChucVu();
            cv.Show();
            this.Hide();
        }

        private void itemNCC_Click(object sender, EventArgs e)
        {
            QLNCC ncc = new QLNCC();
            ncc.Show();
            this.Hide();
        }

        private void itemPN_Click(object sender, EventArgs e)
        {
            QLPhieuNhap pn = new QLPhieuNhap();
            pn.Show();
            this.Hide();
        }

        private void itemthongke_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.Show();
            this.Hide();
        }
    }
}
