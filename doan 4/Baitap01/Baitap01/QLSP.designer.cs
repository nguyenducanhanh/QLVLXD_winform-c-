
namespace Baitap01
{
    partial class QLSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmsp = new System.Windows.Forms.TextBox();
            this.txttsp = new System.Windows.Forms.TextBox();
            this.txtg = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtlsp = new System.Windows.Forms.ComboBox();
            this.qLLoaiSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chvlxdDBDataSet = new Baitap01.chvlxdDBDataSet();
            this.qLLoaiSPTableAdapter = new Baitap01.chvlxdDBDataSetTableAdapters.QLLoaiSPTableAdapter();
            this.txtmncc = new System.Windows.Forms.ComboBox();
            this.qLNCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNCCTableAdapter = new Baitap01.chvlxdDBDataSetTableAdapters.QLNCCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLLoaiSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNCCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(558, 193);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(470, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Tìm Kiếm";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MÃ SP";
            // 
            // txtmsp
            // 
            this.txtmsp.Location = new System.Drawing.Point(76, 58);
            this.txtmsp.Name = "txtmsp";
            this.txtmsp.Size = new System.Drawing.Size(100, 20);
            this.txtmsp.TabIndex = 9;
            // 
            // txttsp
            // 
            this.txttsp.Location = new System.Drawing.Point(76, 110);
            this.txttsp.Name = "txttsp";
            this.txttsp.Size = new System.Drawing.Size(100, 20);
            this.txttsp.TabIndex = 10;
            // 
            // txtg
            // 
            this.txtg.Location = new System.Drawing.Point(247, 110);
            this.txtg.Name = "txtg";
            this.txtg.Size = new System.Drawing.Size(100, 20);
            this.txtg.TabIndex = 12;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(264, 205);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(193, 20);
            this.txttk.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã LSP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã NCC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Giá";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(367, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 116);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao Tác";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(495, 448);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 19;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtlsp
            // 
            this.txtlsp.DataSource = this.qLLoaiSPBindingSource;
            this.txtlsp.DisplayMember = "MaLSP";
            this.txtlsp.FormattingEnabled = true;
            this.txtlsp.Location = new System.Drawing.Point(76, 163);
            this.txtlsp.Name = "txtlsp";
            this.txtlsp.Size = new System.Drawing.Size(100, 21);
            this.txtlsp.TabIndex = 20;
            this.txtlsp.ValueMember = "MaLSP";
            // 
            // qLLoaiSPBindingSource
            // 
            this.qLLoaiSPBindingSource.DataMember = "QLLoaiSP";
            this.qLLoaiSPBindingSource.DataSource = this.chvlxdDBDataSet;
            // 
            // chvlxdDBDataSet
            // 
            this.chvlxdDBDataSet.DataSetName = "chvlxdDBDataSet";
            this.chvlxdDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLLoaiSPTableAdapter
            // 
            this.qLLoaiSPTableAdapter.ClearBeforeFill = true;
            // 
            // txtmncc
            // 
            this.txtmncc.DataSource = this.qLNCCBindingSource;
            this.txtmncc.DisplayMember = "MaNCC";
            this.txtmncc.FormattingEnabled = true;
            this.txtmncc.Location = new System.Drawing.Point(247, 61);
            this.txtmncc.Name = "txtmncc";
            this.txtmncc.Size = new System.Drawing.Size(100, 21);
            this.txtmncc.TabIndex = 21;
            this.txtmncc.ValueMember = "MaNCC";
            // 
            // qLNCCBindingSource
            // 
            this.qLNCCBindingSource.DataMember = "QLNCC";
            this.qLNCCBindingSource.DataSource = this.chvlxdDBDataSet;
            // 
            // qLNCCTableAdapter
            // 
            this.qLNCCTableAdapter.ClearBeforeFill = true;
            // 
            // QLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 483);
            this.Controls.Add(this.txtmncc);
            this.Controls.Add(this.txtlsp);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.txtg);
            this.Controls.Add(this.txttsp);
            this.Controls.Add(this.txtmsp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLSP";
            this.Load += new System.EventHandler(this.QLLSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qLLoaiSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNCCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmsp;
        private System.Windows.Forms.TextBox txttsp;
        private System.Windows.Forms.TextBox txtg;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ComboBox txtlsp;
        private chvlxdDBDataSet chvlxdDBDataSet;
        private System.Windows.Forms.BindingSource qLLoaiSPBindingSource;
        private chvlxdDBDataSetTableAdapters.QLLoaiSPTableAdapter qLLoaiSPTableAdapter;
        private System.Windows.Forms.ComboBox txtmncc;
        private System.Windows.Forms.BindingSource qLNCCBindingSource;
        private chvlxdDBDataSetTableAdapters.QLNCCTableAdapter qLNCCTableAdapter;
    }
}