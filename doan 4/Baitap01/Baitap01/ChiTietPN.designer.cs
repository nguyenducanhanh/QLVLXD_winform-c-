
namespace Baitap01
{
    partial class ChiTietPN
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msp = new System.Windows.Forms.ComboBox();
            this.qLSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chvlxdDBDataSet = new Baitap01.chvlxdDBDataSet();
            this.mncc = new System.Windows.Forms.ComboBox();
            this.qLNCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.sl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mpn = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.TextBox();
            this.qLNCCTableAdapter = new Baitap01.chvlxdDBDataSetTableAdapters.QLNCCTableAdapter();
            this.qLSPTableAdapter = new Baitap01.chvlxdDBDataSetTableAdapters.QLSPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNCCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 41);
            this.label6.TabIndex = 32;
            this.label6.Text = "Chi Tiết Phiếu Nhập";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 233);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msp);
            this.groupBox1.Controls.Add(this.mncc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.sl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mpn);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(585, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(242, 256);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // msp
            // 
            this.msp.DataSource = this.qLSPBindingSource;
            this.msp.DisplayMember = "TenSP";
            this.msp.FormattingEnabled = true;
            this.msp.Location = new System.Drawing.Point(144, 44);
            this.msp.Name = "msp";
            this.msp.Size = new System.Drawing.Size(76, 21);
            this.msp.TabIndex = 35;
            this.msp.ValueMember = "MaSP";
            // 
            // qLSPBindingSource
            // 
            this.qLSPBindingSource.DataMember = "QLSP";
            this.qLSPBindingSource.DataSource = this.chvlxdDBDataSet;
            // 
            // chvlxdDBDataSet
            // 
            this.chvlxdDBDataSet.DataSetName = "chvlxdDBDataSet";
            this.chvlxdDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mncc
            // 
            this.mncc.DataSource = this.qLNCCBindingSource;
            this.mncc.DisplayMember = "TenNCC";
            this.mncc.FormattingEnabled = true;
            this.mncc.Location = new System.Drawing.Point(144, 71);
            this.mncc.Name = "mncc";
            this.mncc.Size = new System.Drawing.Size(76, 21);
            this.mncc.TabIndex = 34;
            this.mncc.ValueMember = "MaNCC";
            // 
            // qLNCCBindingSource
            // 
            this.qLNCCBindingSource.DataMember = "QLNCC";
            this.qLNCCBindingSource.DataSource = this.chvlxdDBDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đơn Giá";
            // 
            // dg
            // 
            this.dg.Enabled = false;
            this.dg.Location = new System.Drawing.Point(144, 124);
            this.dg.Margin = new System.Windows.Forms.Padding(2);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(76, 20);
            this.dg.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số Lượng";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(164, 212);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 19);
            this.button6.TabIndex = 29;
            this.button6.Text = "Thoát";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // sl
            // 
            this.sl.Location = new System.Drawing.Point(144, 97);
            this.sl.Margin = new System.Windows.Forms.Padding(2);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(76, 20);
            this.sl.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Phiếu Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sản Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhà cung cấp";
            // 
            // mpn
            // 
            this.mpn.Enabled = false;
            this.mpn.Location = new System.Drawing.Point(144, 19);
            this.mpn.Margin = new System.Windows.Forms.Padding(2);
            this.mpn.Name = "mpn";
            this.mpn.Size = new System.Drawing.Size(76, 20);
            this.mpn.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 212);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(509, 114);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 19);
            this.button4.TabIndex = 3;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(411, 113);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 19);
            this.button5.TabIndex = 28;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(216, 112);
            this.timkiem.Margin = new System.Windows.Forms.Padding(2);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(156, 20);
            this.timkiem.TabIndex = 27;
            // 
            // qLNCCTableAdapter
            // 
            this.qLNCCTableAdapter.ClearBeforeFill = true;
            // 
            // qLSPTableAdapter
            // 
            this.qLSPTableAdapter.ClearBeforeFill = true;
            // 
            // ChiTietPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 383);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.button4);
            this.Name = "ChiTietPN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChiTietPN";
            this.Load += new System.EventHandler(this.ChiTietPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNCCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mpn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox timkiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dg;
        private System.Windows.Forms.ComboBox mncc;
        private chvlxdDBDataSet chvlxdDBDataSet;
        private System.Windows.Forms.BindingSource qLNCCBindingSource;
        private chvlxdDBDataSetTableAdapters.QLNCCTableAdapter qLNCCTableAdapter;
        private System.Windows.Forms.ComboBox msp;
        private System.Windows.Forms.BindingSource qLSPBindingSource;
        private chvlxdDBDataSetTableAdapters.QLSPTableAdapter qLSPTableAdapter;
    }
}