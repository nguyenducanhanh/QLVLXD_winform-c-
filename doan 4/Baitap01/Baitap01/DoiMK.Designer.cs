
namespace Baitap01
{
    partial class DoiMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmkc = new System.Windows.Forms.TextBox();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btndmk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // txtmkc
            // 
            this.txtmkc.Location = new System.Drawing.Point(180, 64);
            this.txtmkc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmkc.Name = "txtmkc";
            this.txtmkc.Size = new System.Drawing.Size(180, 22);
            this.txtmkc.TabIndex = 2;
            // 
            // txtmkm
            // 
            this.txtmkm.Location = new System.Drawing.Point(180, 96);
            this.txtmkm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.Size = new System.Drawing.Size(180, 22);
            this.txtmkm.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu mới";
            // 
            // txtxn
            // 
            this.txtxn.Location = new System.Drawing.Point(180, 128);
            this.txtxn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtxn.Name = "txtxn";
            this.txtxn.Size = new System.Drawing.Size(180, 22);
            this.txtxn.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Xác nhận mật khẩu mới";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(291, 187);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(91, 28);
            this.btnhuy.TabIndex = 8;
            this.btnhuy.Text = "Huỷ";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btndmk
            // 
            this.btndmk.Location = new System.Drawing.Point(164, 187);
            this.btndmk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndmk.Name = "btndmk";
            this.btndmk.Size = new System.Drawing.Size(109, 28);
            this.btndmk.TabIndex = 9;
            this.btndmk.Text = "Đổi mật khẩu";
            this.btndmk.UseVisualStyleBackColor = true;
            this.btndmk.Click += new System.EventHandler(this.btndmk_Click);
            // 
            // DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 234);
            this.Controls.Add(this.btndmk);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.txtxn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmkm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmkc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiMK";
            this.Load += new System.EventHandler(this.DoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmkc;
        private System.Windows.Forms.TextBox txtmkm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btndmk;
    }
}