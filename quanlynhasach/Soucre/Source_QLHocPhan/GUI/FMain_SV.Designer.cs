
namespace GUI
{
    partial class FMain_SV
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
            this.btndkhp = new System.Windows.Forms.Button();
            this.btndkcd = new System.Windows.Forms.Button();
            this.btndkcc = new System.Windows.Forms.Button();
            this.btnqlht = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txthienthitendn = new System.Windows.Forms.TextBox();
            this.btnthongtincanhan = new System.Windows.Forms.Button();
            this.panelhienthi = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btndkhp
            // 
            this.btndkhp.Location = new System.Drawing.Point(167, 12);
            this.btndkhp.Name = "btndkhp";
            this.btndkhp.Size = new System.Drawing.Size(128, 66);
            this.btndkhp.TabIndex = 0;
            this.btndkhp.Text = "Đăng kí học phần";
            this.btndkhp.UseVisualStyleBackColor = true;
            this.btndkhp.Click += new System.EventHandler(this.btndkhp_Click);
            // 
            // btndkcd
            // 
            this.btndkcd.Location = new System.Drawing.Point(329, 12);
            this.btndkcd.Name = "btndkcd";
            this.btndkcd.Size = new System.Drawing.Size(128, 66);
            this.btndkcd.TabIndex = 1;
            this.btndkcd.Text = "Đăng kí chuyên đề";
            this.btndkcd.UseVisualStyleBackColor = true;
            this.btndkcd.Click += new System.EventHandler(this.btndkcd_Click);
            // 
            // btndkcc
            // 
            this.btndkcc.Location = new System.Drawing.Point(485, 12);
            this.btndkcc.Name = "btndkcc";
            this.btndkcc.Size = new System.Drawing.Size(128, 66);
            this.btndkcc.TabIndex = 2;
            this.btndkcc.Text = "Đăng kí chứng chỉ";
            this.btndkcc.UseVisualStyleBackColor = true;
            this.btndkcc.Click += new System.EventHandler(this.btndkcc_Click);
            // 
            // btnqlht
            // 
            this.btnqlht.Location = new System.Drawing.Point(644, 12);
            this.btnqlht.Name = "btnqlht";
            this.btnqlht.Size = new System.Drawing.Size(128, 66);
            this.btnqlht.TabIndex = 3;
            this.btnqlht.Text = "Quản lý học tập";
            this.btnqlht.UseVisualStyleBackColor = true;
            this.btnqlht.Click += new System.EventHandler(this.btnqlht_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1247, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 40);
            this.button7.TabIndex = 6;
            this.button7.Text = "Đăng xuất";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txthienthitendn
            // 
            this.txthienthitendn.Location = new System.Drawing.Point(1247, 0);
            this.txthienthitendn.Name = "txthienthitendn";
            this.txthienthitendn.Size = new System.Drawing.Size(110, 22);
            this.txthienthitendn.TabIndex = 7;
            // 
            // btnthongtincanhan
            // 
            this.btnthongtincanhan.Location = new System.Drawing.Point(12, 12);
            this.btnthongtincanhan.Name = "btnthongtincanhan";
            this.btnthongtincanhan.Size = new System.Drawing.Size(128, 66);
            this.btnthongtincanhan.TabIndex = 8;
            this.btnthongtincanhan.Text = "Thông tin cá nhân";
            this.btnthongtincanhan.UseVisualStyleBackColor = true;
            this.btnthongtincanhan.Click += new System.EventHandler(this.button8_Click);
            // 
            // panelhienthi
            // 
            this.panelhienthi.Location = new System.Drawing.Point(6, 104);
            this.panelhienthi.Name = "panelhienthi";
            this.panelhienthi.Size = new System.Drawing.Size(1355, 688);
            this.panelhienthi.TabIndex = 9;
            // 
            // FMain_SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 798);
            this.Controls.Add(this.panelhienthi);
            this.Controls.Add(this.btnthongtincanhan);
            this.Controls.Add(this.txthienthitendn);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnqlht);
            this.Controls.Add(this.btndkcc);
            this.Controls.Add(this.btndkcd);
            this.Controls.Add(this.btndkhp);
            this.Name = "FMain_SV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FMain_SV";
            this.Load += new System.EventHandler(this.FMain_SV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndkhp;
        private System.Windows.Forms.Button btndkcd;
        private System.Windows.Forms.Button btndkcc;
        private System.Windows.Forms.Button btnqlht;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txthienthitendn;
        private System.Windows.Forms.Button btnthongtincanhan;
        private System.Windows.Forms.Panel panelhienthi;
    }
}