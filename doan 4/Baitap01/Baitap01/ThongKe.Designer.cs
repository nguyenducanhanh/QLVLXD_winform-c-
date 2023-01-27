
namespace Baitap01
{
    partial class ThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbthang = new System.Windows.Forms.ComboBox();
            this.txtnamt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnamn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnamq = new System.Windows.Forms.TextBox();
            this.cbquy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btntk = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbtimkiem = new System.Windows.Forms.ComboBox();
            this.qLSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chvlxdDBDataSet = new Baitap01.chvlxdDBDataSet();
            this.chvlxdDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSPTableAdapter = new Baitap01.chvlxdDBDataSetTableAdapters.QLSPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ";
            // 
            // cbthang
            // 
            this.cbthang.FormattingEnabled = true;
            this.cbthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbthang.Location = new System.Drawing.Point(53, 61);
            this.cbthang.Name = "cbthang";
            this.cbthang.Size = new System.Drawing.Size(43, 21);
            this.cbthang.TabIndex = 2;
            // 
            // txtnamt
            // 
            this.txtnamt.Location = new System.Drawing.Point(143, 62);
            this.txtnamt.Name = "txtnamt";
            this.txtnamt.Size = new System.Drawing.Size(56, 20);
            this.txtnamt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Năm";
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(101, 78);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 7;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnamn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtnamq);
            this.groupBox1.Controls.Add(this.cbquy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtnamt);
            this.groupBox1.Controls.Add(this.cbthang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(401, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 204);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // txtnamn
            // 
            this.txtnamn.Location = new System.Drawing.Point(53, 161);
            this.txtnamn.Name = "txtnamn";
            this.txtnamn.Size = new System.Drawing.Size(56, 20);
            this.txtnamn.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Năm";
            // 
            // txtnamq
            // 
            this.txtnamq.Location = new System.Drawing.Point(143, 112);
            this.txtnamq.Name = "txtnamq";
            this.txtnamq.Size = new System.Drawing.Size(56, 20);
            this.txtnamq.TabIndex = 10;
            // 
            // cbquy
            // 
            this.cbquy.FormattingEnabled = true;
            this.cbquy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbquy.Location = new System.Drawing.Point(53, 111);
            this.cbquy.Name = "cbquy";
            this.cbquy.Size = new System.Drawing.Size(43, 21);
            this.cbquy.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quý";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Năm";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 138);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(118, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Thống kê theo năm";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 88);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Thống kê theo quý";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 38);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Thống kê theo tháng";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Thống kê hàng nhập",
            "Thống kê doanh thu"});
            this.comboBox1.Location = new System.Drawing.Point(195, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(401, 325);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 10;
            this.btntk.Text = "Thống kê";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(536, 325);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Quay lại";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttt
            // 
            this.txttt.Enabled = false;
            this.txttt.Location = new System.Drawing.Point(265, 327);
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(116, 20);
            this.txttt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tổng tiền";
            // 
            // cbtimkiem
            // 
            this.cbtimkiem.DataSource = this.qLSPBindingSource;
            this.cbtimkiem.DisplayMember = "MaSP";
            this.cbtimkiem.FormattingEnabled = true;
            this.cbtimkiem.Location = new System.Drawing.Point(12, 78);
            this.cbtimkiem.Name = "cbtimkiem";
            this.cbtimkiem.Size = new System.Drawing.Size(77, 21);
            this.cbtimkiem.TabIndex = 14;
            this.cbtimkiem.ValueMember = "MaSP";
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
            // chvlxdDBDataSetBindingSource
            // 
            this.chvlxdDBDataSetBindingSource.DataSource = this.chvlxdDBDataSet;
            this.chvlxdDBDataSetBindingSource.Position = 0;
            // 
            // qLSPTableAdapter
            // 
            this.qLSPTableAdapter.ClearBeforeFill = true;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 354);
            this.Controls.Add(this.cbtimkiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttt);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chvlxdDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbthang;
        private System.Windows.Forms.TextBox txtnamt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtnamq;
        private System.Windows.Forms.ComboBox cbquy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnamn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbtimkiem;
        private System.Windows.Forms.BindingSource chvlxdDBDataSetBindingSource;
        private chvlxdDBDataSet chvlxdDBDataSet;
        private System.Windows.Forms.BindingSource qLSPBindingSource;
        private chvlxdDBDataSetTableAdapters.QLSPTableAdapter qLSPTableAdapter;
    }
}