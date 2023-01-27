
namespace Baitap01
{
    partial class QLHD
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
            this.btnlhd = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btnLM = new System.Windows.Forms.Button();
            this.btnxemchitiet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 123);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(761, 284);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnlhd
            // 
            this.btnlhd.Location = new System.Drawing.Point(515, 415);
            this.btnlhd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlhd.Name = "btnlhd";
            this.btnlhd.Size = new System.Drawing.Size(120, 28);
            this.btnlhd.TabIndex = 1;
            this.btnlhd.Text = "Lập hoá đơn";
            this.btnlhd.UseVisualStyleBackColor = true;
            this.btnlhd.Click += new System.EventHandler(this.btnlhd_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.Location = new System.Drawing.Point(692, 415);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(85, 28);
            this.btnquaylai.TabIndex = 2;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = true;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btnLM
            // 
            this.btnLM.Location = new System.Drawing.Point(16, 414);
            this.btnLM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLM.Name = "btnLM";
            this.btnLM.Size = new System.Drawing.Size(105, 26);
            this.btnLM.TabIndex = 3;
            this.btnLM.Text = "Làm mới";
            this.btnLM.UseVisualStyleBackColor = true;
            this.btnLM.Click += new System.EventHandler(this.btnLM_Click);
            // 
            // btnxemchitiet
            // 
            this.btnxemchitiet.Location = new System.Drawing.Point(128, 414);
            this.btnxemchitiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxemchitiet.Name = "btnxemchitiet";
            this.btnxemchitiet.Size = new System.Drawing.Size(99, 26);
            this.btnxemchitiet.TabIndex = 4;
            this.btnxemchitiet.Text = "Xem chi tiết";
            this.btnxemchitiet.UseVisualStyleBackColor = true;
            this.btnxemchitiet.Click += new System.EventHandler(this.btnxemchitiet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý hoá đơn";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(16, 91);
            this.txttim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(132, 22);
            this.txttim.TabIndex = 6;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(157, 89);
            this.btntim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(100, 28);
            this.btntim.TabIndex = 7;
            this.btntim.Text = "Tìm kiếm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 449);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnxemchitiet);
            this.Controls.Add(this.btnLM);
            this.Controls.Add(this.btnquaylai);
            this.Controls.Add(this.btnlhd);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QLHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLHD";
            this.Load += new System.EventHandler(this.QLHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnlhd;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btnLM;
        private System.Windows.Forms.Button btnxemchitiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button btntim;
    }
}