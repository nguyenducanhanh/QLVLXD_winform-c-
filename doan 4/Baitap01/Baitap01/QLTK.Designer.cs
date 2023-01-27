
namespace Baitap01
{
    partial class QLTK
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
            this.btntao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrs = new System.Windows.Forms.Button();
            this.QNV = new System.Windows.Forms.RadioButton();
            this.QAdmin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.chvlxdDBDataSet = new Baitap01.chvlxdDBDataSet();
            this.chvlxdDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNVTableAdapter = new Baitap01.chvlxdDBDataSetTableAdapters.QLNVTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btntao
            // 
            this.btntao.Location = new System.Drawing.Point(0, 227);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(87, 23);
            this.btntao.TabIndex = 0;
            this.btntao.Text = "Tạo tài khoản";
            this.btntao.UseVisualStyleBackColor = true;
            this.btntao.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmanv);
            this.groupBox1.Controls.Add(this.btnrs);
            this.groupBox1.Controls.Add(this.QNV);
            this.groupBox1.Controls.Add(this.QAdmin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtmk);
            this.groupBox1.Controls.Add(this.txttk);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btntao);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thao tác";
            // 
            // btnrs
            // 
            this.btnrs.Location = new System.Drawing.Point(119, 294);
            this.btnrs.Name = "btnrs";
            this.btnrs.Size = new System.Drawing.Size(75, 23);
            this.btnrs.TabIndex = 17;
            this.btnrs.Text = "Làm mới";
            this.btnrs.UseVisualStyleBackColor = true;
            this.btnrs.Click += new System.EventHandler(this.btnrs_Click);
            // 
            // QNV
            // 
            this.QNV.AutoSize = true;
            this.QNV.Location = new System.Drawing.Point(118, 133);
            this.QNV.Name = "QNV";
            this.QNV.Size = new System.Drawing.Size(74, 17);
            this.QNV.TabIndex = 16;
            this.QNV.TabStop = true;
            this.QNV.Text = "Nhân viên";
            this.QNV.UseVisualStyleBackColor = true;
            // 
            // QAdmin
            // 
            this.QAdmin.AutoSize = true;
            this.QAdmin.Location = new System.Drawing.Point(65, 133);
            this.QAdmin.Name = "QAdmin";
            this.QAdmin.Size = new System.Drawing.Size(54, 17);
            this.QAdmin.TabIndex = 15;
            this.QAdmin.TabStop = true;
            this.QAdmin.Text = "Admin";
            this.QAdmin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã NV";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(80, 92);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(100, 20);
            this.txtmk.TabIndex = 7;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(80, 53);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(100, 20);
            this.txttk.TabIndex = 6;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(93, 227);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(48, 23);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(147, 227);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(47, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(369, 70);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 3;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(244, 73);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(100, 20);
            this.txttim.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 202);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(539, 319);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button5_Click);
            // 
            // cbmanv
            // 
            this.cbmanv.DataSource = this.qLNVBindingSource;
            this.cbmanv.DisplayMember = "MaNV";
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(80, 168);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(100, 21);
            this.cbmanv.TabIndex = 18;
            this.cbmanv.ValueMember = "MaNV";
            // 
            // chvlxdDBDataSet
            // 
            this.chvlxdDBDataSet.DataSetName = "chvlxdDBDataSet";
            this.chvlxdDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chvlxdDBDataSetBindingSource
            // 
            this.chvlxdDBDataSetBindingSource.DataSource = this.chvlxdDBDataSet;
            this.chvlxdDBDataSetBindingSource.Position = 0;
            // 
            // qLNVBindingSource
            // 
            this.qLNVBindingSource.DataMember = "QLNV";
            this.qLNVBindingSource.DataSource = this.chvlxdDBDataSetBindingSource;
            // 
            // qLNVTableAdapter
            // 
            this.qLNVTableAdapter.ClearBeforeFill = true;
            // 
            // QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 353);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntim);
            this.Name = "QLTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.QLTK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.RadioButton QNV;
        private System.Windows.Forms.RadioButton QAdmin;
        private System.Windows.Forms.Button btnrs;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.BindingSource chvlxdDBDataSetBindingSource;
        private chvlxdDBDataSet chvlxdDBDataSet;
        private System.Windows.Forms.BindingSource qLNVBindingSource;
        private chvlxdDBDataSetTableAdapters.QLNVTableAdapter qLNVTableAdapter;
    }
}