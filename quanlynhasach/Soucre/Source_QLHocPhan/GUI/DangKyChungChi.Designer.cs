
namespace GUI
{
    partial class DangKyChungChi
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
            this.btnxem_dscc = new System.Windows.Forms.Button();
            this.dtg_danhsachchungchi = new System.Windows.Forms.DataGridView();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnhuydkchungchi = new System.Windows.Forms.Button();
            this.btnxem_dsdk = new System.Windows.Forms.Button();
            this.dtg_dsccdk = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.radio_B = new System.Windows.Forms.RadioButton();
            this.rdio_A = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachchungchi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dsccdk)).BeginInit();
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
            this.textBox1.TabIndex = 11;
            // 
            // btnxem_dscc
            // 
            this.btnxem_dscc.Location = new System.Drawing.Point(1052, 18);
            this.btnxem_dscc.Name = "btnxem_dscc";
            this.btnxem_dscc.Size = new System.Drawing.Size(75, 31);
            this.btnxem_dscc.TabIndex = 5;
            this.btnxem_dscc.Text = "Xem";
            this.btnxem_dscc.UseVisualStyleBackColor = true;
            this.btnxem_dscc.Click += new System.EventHandler(this.btnxem_dscc_Click);
            // 
            // dtg_danhsachchungchi
            // 
            this.dtg_danhsachchungchi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_danhsachchungchi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_danhsachchungchi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_danhsachchungchi.Location = new System.Drawing.Point(6, 55);
            this.dtg_danhsachchungchi.Name = "dtg_danhsachchungchi";
            this.dtg_danhsachchungchi.RowHeadersWidth = 51;
            this.dtg_danhsachchungchi.RowTemplate.Height = 24;
            this.dtg_danhsachchungchi.Size = new System.Drawing.Size(1175, 271);
            this.dtg_danhsachchungchi.TabIndex = 0;
            // 
            // btnDangKi
            // 
            this.btnDangKi.Location = new System.Drawing.Point(558, 601);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(104, 46);
            this.btnDangKi.TabIndex = 10;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnhuydkchungchi);
            this.groupBox2.Controls.Add(this.btnxem_dsdk);
            this.groupBox2.Controls.Add(this.dtg_dsccdk);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1187, 217);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sach Hoc Phan Dang Ky";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnhuydkchungchi
            // 
            this.btnhuydkchungchi.Location = new System.Drawing.Point(859, 13);
            this.btnhuydkchungchi.Name = "btnhuydkchungchi";
            this.btnhuydkchungchi.Size = new System.Drawing.Size(128, 27);
            this.btnhuydkchungchi.TabIndex = 5;
            this.btnhuydkchungchi.Text = "Hủy đăng ký";
            this.btnhuydkchungchi.UseVisualStyleBackColor = true;
            this.btnhuydkchungchi.Click += new System.EventHandler(this.btnhuydkchungchi_Click);
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
            // dtg_dsccdk
            // 
            this.dtg_dsccdk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_dsccdk.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_dsccdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_dsccdk.Location = new System.Drawing.Point(6, 46);
            this.dtg_dsccdk.Name = "dtg_dsccdk";
            this.dtg_dsccdk.RowHeadersWidth = 51;
            this.dtg_dsccdk.RowTemplate.Height = 24;
            this.dtg_dsccdk.Size = new System.Drawing.Size(1175, 165);
            this.dtg_dsccdk.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Controls.Add(this.radio_B);
            this.groupBox1.Controls.Add(this.rdio_A);
            this.groupBox1.Controls.Add(this.btnxem_dscc);
            this.groupBox1.Controls.Add(this.dtg_danhsachchungchi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1187, 332);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sach Hoc Phan ";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMaLoai.Location = new System.Drawing.Point(699, 18);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(100, 23);
            this.txtMaLoai.TabIndex = 8;
            this.txtMaLoai.Text = "Mã loại";
            // 
            // radio_B
            // 
            this.radio_B.AutoSize = true;
            this.radio_B.Location = new System.Drawing.Point(536, 19);
            this.radio_B.Name = "radio_B";
            this.radio_B.Size = new System.Drawing.Size(125, 24);
            this.radio_B.TabIndex = 7;
            this.radio_B.TabStop = true;
            this.radio_B.Text = "Chứng Chỉ B";
            this.radio_B.UseVisualStyleBackColor = true;
            this.radio_B.CheckedChanged += new System.EventHandler(this.radio_B_CheckedChanged);
            // 
            // rdio_A
            // 
            this.rdio_A.AutoSize = true;
            this.rdio_A.Location = new System.Drawing.Point(372, 18);
            this.rdio_A.Name = "rdio_A";
            this.rdio_A.Size = new System.Drawing.Size(121, 24);
            this.rdio_A.TabIndex = 6;
            this.rdio_A.TabStop = true;
            this.rdio_A.Text = "Chứng chỉ A";
            this.rdio_A.UseVisualStyleBackColor = true;
            this.rdio_A.CheckedChanged += new System.EventHandler(this.rdio_A_CheckedChanged);
            // 
            // DangKyChungChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 653);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DangKyChungChi";
            this.Text = "DangKyChungChi";
            this.Load += new System.EventHandler(this.DangKyChungChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachchungchi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dsccdk)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnxem_dscc;
        private System.Windows.Forms.DataGridView dtg_danhsachchungchi;
        private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnxem_dsdk;
        private System.Windows.Forms.DataGridView dtg_dsccdk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_B;
        private System.Windows.Forms.RadioButton rdio_A;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Button btnhuydkchungchi;
    }
}