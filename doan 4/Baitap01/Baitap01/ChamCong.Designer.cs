
namespace Baitap01
{
    partial class ChamCong
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnctcc = new System.Windows.Forms.Button();
            this.btntao = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.txtnam = new System.Windows.Forms.TextBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnrs = new System.Windows.Forms.Button();
            this.cbthang = new System.Windows.Forms.ComboBox();
            this.btntl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(37, 155);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(468, 271);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "BẢNG CHẤM CÔNG";
            // 
            // btnctcc
            // 
            this.btnctcc.Location = new System.Drawing.Point(37, 452);
            this.btnctcc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnctcc.Name = "btnctcc";
            this.btnctcc.Size = new System.Drawing.Size(100, 28);
            this.btnctcc.TabIndex = 3;
            this.btnctcc.Text = "Xem chi tiết";
            this.btnctcc.UseVisualStyleBackColor = true;
            this.btnctcc.Click += new System.EventHandler(this.btnctcc_Click);
            // 
            // btntao
            // 
            this.btntao.Location = new System.Drawing.Point(144, 452);
            this.btntao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntao.Name = "btntao";
            this.btntao.Size = new System.Drawing.Size(107, 28);
            this.btntao.TabIndex = 4;
            this.btntao.Text = "Tạo bảng mới";
            this.btntao.UseVisualStyleBackColor = true;
            this.btntao.Click += new System.EventHandler(this.btntao_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(375, 94);
            this.btntim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(93, 33);
            this.btntim.TabIndex = 5;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txtnam
            // 
            this.txtnam.Location = new System.Drawing.Point(245, 98);
            this.txtnam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnam.Name = "txtnam";
            this.txtnam.Size = new System.Drawing.Size(87, 22);
            this.txtnam.TabIndex = 6;
            // 
            // btnquaylai
            // 
            this.btnquaylai.Location = new System.Drawing.Point(553, 452);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(100, 28);
            this.btnquaylai.TabIndex = 7;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Năm";
            // 
            // btnrs
            // 
            this.btnrs.Location = new System.Drawing.Point(405, 452);
            this.btnrs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrs.Name = "btnrs";
            this.btnrs.Size = new System.Drawing.Size(100, 28);
            this.btnrs.TabIndex = 11;
            this.btnrs.Text = "Làm mới";
            this.btnrs.UseVisualStyleBackColor = true;
            this.btnrs.Click += new System.EventHandler(this.btnrs_Click);
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
            this.cbthang.Location = new System.Drawing.Point(113, 98);
            this.cbthang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbthang.Name = "cbthang";
            this.cbthang.Size = new System.Drawing.Size(60, 24);
            this.cbthang.TabIndex = 12;
            // 
            // btntl
            // 
            this.btntl.Location = new System.Drawing.Point(259, 452);
            this.btntl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntl.Name = "btntl";
            this.btntl.Size = new System.Drawing.Size(100, 28);
            this.btntl.TabIndex = 13;
            this.btntl.Text = "Tính lương";
            this.btntl.UseVisualStyleBackColor = true;
            this.btntl.Click += new System.EventHandler(this.btntl_Click);
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 489);
            this.Controls.Add(this.btntl);
            this.Controls.Add(this.cbthang);
            this.Controls.Add(this.btnrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btntao);
            this.Controls.Add(this.btnctcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnctcc;
        private System.Windows.Forms.Button btntao;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtnam;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnrs;
        private System.Windows.Forms.ComboBox cbthang;
        private System.Windows.Forms.Button btntl;
    }
}