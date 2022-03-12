
namespace GUI
{
    partial class FQuanLyHocTap
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
            this.btnxemlichthi = new System.Windows.Forms.Button();
            this.btntracukqht = new System.Windows.Forms.Button();
            this.btntchocphi = new System.Windows.Forms.Button();
            this.txthienthi = new System.Windows.Forms.TextBox();
            this.panelhtqlht = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnxemlichthi
            // 
            this.btnxemlichthi.Location = new System.Drawing.Point(12, 79);
            this.btnxemlichthi.Name = "btnxemlichthi";
            this.btnxemlichthi.Size = new System.Drawing.Size(142, 57);
            this.btnxemlichthi.TabIndex = 0;
            this.btnxemlichthi.Text = "Xem lịch thi";
            this.btnxemlichthi.UseVisualStyleBackColor = true;
            this.btnxemlichthi.Click += new System.EventHandler(this.btnxemlichthi_Click);
            // 
            // btntracukqht
            // 
            this.btntracukqht.Location = new System.Drawing.Point(12, 175);
            this.btntracukqht.Name = "btntracukqht";
            this.btntracukqht.Size = new System.Drawing.Size(142, 52);
            this.btntracukqht.TabIndex = 1;
            this.btntracukqht.Text = "Tra cứu kết quả học tập";
            this.btntracukqht.UseVisualStyleBackColor = true;
            this.btntracukqht.Click += new System.EventHandler(this.btntracukqht_Click);
            // 
            // btntchocphi
            // 
            this.btntchocphi.Location = new System.Drawing.Point(12, 265);
            this.btntchocphi.Name = "btntchocphi";
            this.btntchocphi.Size = new System.Drawing.Size(142, 52);
            this.btntchocphi.TabIndex = 2;
            this.btntchocphi.Text = "Tra cứu học phí";
            this.btntchocphi.UseVisualStyleBackColor = true;
            // 
            // txthienthi
            // 
            this.txthienthi.Location = new System.Drawing.Point(1163, 12);
            this.txthienthi.Name = "txthienthi";
            this.txthienthi.Size = new System.Drawing.Size(100, 22);
            this.txthienthi.TabIndex = 4;
            // 
            // panelhtqlht
            // 
            this.panelhtqlht.Location = new System.Drawing.Point(179, 49);
            this.panelhtqlht.Name = "panelhtqlht";
            this.panelhtqlht.Size = new System.Drawing.Size(1084, 540);
            this.panelhtqlht.TabIndex = 5;
            // 
            // FQuanLyHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 601);
            this.Controls.Add(this.panelhtqlht);
            this.Controls.Add(this.txthienthi);
            this.Controls.Add(this.btntchocphi);
            this.Controls.Add(this.btntracukqht);
            this.Controls.Add(this.btnxemlichthi);
            this.Name = "FQuanLyHocTap";
            this.Text = "FQuanLyHocTap";
            this.Load += new System.EventHandler(this.FQuanLyHocTap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnxemlichthi;
        private System.Windows.Forms.Button btntracukqht;
        private System.Windows.Forms.Button btntchocphi;
        private System.Windows.Forms.TextBox txthienthi;
        private System.Windows.Forms.Panel panelhtqlht;
    }
}