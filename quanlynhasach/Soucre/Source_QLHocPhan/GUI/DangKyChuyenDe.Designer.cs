
namespace GUI
{
    partial class DangKyChuyenDe
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnxem_dsdk = new System.Windows.Forms.Button();
            this.dtg_dschuyendedk = new System.Windows.Forms.DataGridView();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHuyCD = new System.Windows.Forms.Button();
            this.btnxem_dshp = new System.Windows.Forms.Button();
            this.dtg_danhsachchuyende = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dschuyendedk)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachchuyende)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(1110, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(83, 22);
            this.textBox1.TabIndex = 7;
            // 
            // btnxem_dsdk
            // 
            this.btnxem_dsdk.Location = new System.Drawing.Point(1052, 13);
            this.btnxem_dsdk.Name = "btnxem_dsdk";
            this.btnxem_dsdk.Size = new System.Drawing.Size(75, 27);
            this.btnxem_dsdk.TabIndex = 4;
            this.btnxem_dsdk.Text = "Xem";
            this.btnxem_dsdk.UseVisualStyleBackColor = true;
            this.btnxem_dsdk.Click += new System.EventHandler(this.btnxem_dsdk_Click);
            // 
            // dtg_dschuyendedk
            // 
            this.dtg_dschuyendedk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_dschuyendedk.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_dschuyendedk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_dschuyendedk.Location = new System.Drawing.Point(6, 46);
            this.dtg_dschuyendedk.Name = "dtg_dschuyendedk";
            this.dtg_dschuyendedk.RowHeadersWidth = 51;
            this.dtg_dschuyendedk.RowTemplate.Height = 24;
            this.dtg_dschuyendedk.Size = new System.Drawing.Size(1175, 165);
            this.dtg_dschuyendedk.TabIndex = 0;
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(558, 601);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(104, 46);
            this.btnDangKi.TabIndex = 6;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHuyCD);
            this.groupBox2.Controls.Add(this.btnxem_dsdk);
            this.groupBox2.Controls.Add(this.dtg_dschuyendedk);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1187, 217);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sach Hoc Phan Dang Ky";
            // 
            // btnHuyCD
            // 
            this.btnHuyCD.Location = new System.Drawing.Point(867, 13);
            this.btnHuyCD.Name = "btnHuyCD";
            this.btnHuyCD.Size = new System.Drawing.Size(133, 27);
            this.btnHuyCD.TabIndex = 5;
            this.btnHuyCD.Text = "Hủy đăng ký";
            this.btnHuyCD.UseVisualStyleBackColor = true;
            this.btnHuyCD.Click += new System.EventHandler(this.btnHuyCD_Click);
            // 
            // btnxem_dshp
            // 
            this.btnxem_dshp.Location = new System.Drawing.Point(1052, 18);
            this.btnxem_dshp.Name = "btnxem_dshp";
            this.btnxem_dshp.Size = new System.Drawing.Size(75, 31);
            this.btnxem_dshp.TabIndex = 5;
            this.btnxem_dshp.Text = "Xem";
            this.btnxem_dshp.UseVisualStyleBackColor = true;
            this.btnxem_dshp.Click += new System.EventHandler(this.btnxem_dschuyende_Click);
            // 
            // dtg_danhsachchuyende
            // 
            this.dtg_danhsachchuyende.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_danhsachchuyende.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_danhsachchuyende.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_danhsachchuyende.Location = new System.Drawing.Point(6, 55);
            this.dtg_danhsachchuyende.Name = "dtg_danhsachchuyende";
            this.dtg_danhsachchuyende.RowHeadersWidth = 51;
            this.dtg_danhsachchuyende.RowTemplate.Height = 24;
            this.dtg_danhsachchuyende.Size = new System.Drawing.Size(1175, 271);
            this.dtg_danhsachchuyende.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxem_dshp);
            this.groupBox1.Controls.Add(this.dtg_danhsachchuyende);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 332);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sach Hoc Phan ";
            // 
            // DangKyChuyenDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 653);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DangKyChuyenDe";
            this.Text = "DangKyChuyenDe";
            this.Load += new System.EventHandler(this.DangKyChuyenDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dschuyendedk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachchuyende)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnxem_dsdk;
        private System.Windows.Forms.DataGridView dtg_dschuyendedk;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnxem_dshp;
        private System.Windows.Forms.DataGridView dtg_danhsachchuyende;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuyCD;
    }
}