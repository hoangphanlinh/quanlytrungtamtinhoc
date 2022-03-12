
namespace GUI
{
    partial class DangKyHocPhan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxem_dshp = new System.Windows.Forms.Button();
            this.dtg_danhsachhocphan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxem_dsdk = new System.Windows.Forms.Button();
            this.btnhuydk = new System.Windows.Forms.Button();
            this.dtg_dshpdk = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btndangky = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachhocphan)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dshpdk)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxem_dshp);
            this.groupBox1.Controls.Add(this.dtg_danhsachhocphan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách học phần ";
            // 
            // btnxem_dshp
            // 
            this.btnxem_dshp.Location = new System.Drawing.Point(482, 5);
            this.btnxem_dshp.Name = "btnxem_dshp";
            this.btnxem_dshp.Size = new System.Drawing.Size(75, 31);
            this.btnxem_dshp.TabIndex = 5;
            this.btnxem_dshp.Text = "Xem";
            this.btnxem_dshp.UseVisualStyleBackColor = true;
            this.btnxem_dshp.Click += new System.EventHandler(this.btnxem_dshp_Click);
            // 
            // dtg_danhsachhocphan
            // 
            this.dtg_danhsachhocphan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtg_danhsachhocphan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_danhsachhocphan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_danhsachhocphan.Location = new System.Drawing.Point(6, 42);
            this.dtg_danhsachhocphan.Name = "dtg_danhsachhocphan";
            this.dtg_danhsachhocphan.RowHeadersWidth = 51;
            this.dtg_danhsachhocphan.RowTemplate.Height = 24;
            this.dtg_danhsachhocphan.Size = new System.Drawing.Size(1027, 224);
            this.dtg_danhsachhocphan.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxem_dsdk);
            this.groupBox2.Controls.Add(this.btnhuydk);
            this.groupBox2.Controls.Add(this.dtg_dshpdk);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1033, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đã đăng ký";
            // 
            // btnxem_dsdk
            // 
            this.btnxem_dsdk.Location = new System.Drawing.Point(454, 11);
            this.btnxem_dsdk.Name = "btnxem_dsdk";
            this.btnxem_dsdk.Size = new System.Drawing.Size(75, 27);
            this.btnxem_dsdk.TabIndex = 4;
            this.btnxem_dsdk.Text = "Xem";
            this.btnxem_dsdk.UseVisualStyleBackColor = true;
            this.btnxem_dsdk.Click += new System.EventHandler(this.btnxem_dsdk_Click);
            // 
            // btnhuydk
            // 
            this.btnhuydk.Location = new System.Drawing.Point(892, 238);
            this.btnhuydk.Name = "btnhuydk";
            this.btnhuydk.Size = new System.Drawing.Size(135, 34);
            this.btnhuydk.TabIndex = 5;
            this.btnhuydk.Text = "Hủy đăng ký";
            this.btnhuydk.UseVisualStyleBackColor = true;
            this.btnhuydk.Click += new System.EventHandler(this.btnhuydk_Click);
            // 
            // dtg_dshpdk
            // 
            this.dtg_dshpdk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_dshpdk.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_dshpdk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_dshpdk.Location = new System.Drawing.Point(5, 44);
            this.dtg_dshpdk.Name = "dtg_dshpdk";
            this.dtg_dshpdk.RowHeadersWidth = 51;
            this.dtg_dshpdk.RowTemplate.Height = 24;
            this.dtg_dshpdk.Size = new System.Drawing.Size(1022, 194);
            this.dtg_dshpdk.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(968, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(83, 22);
            this.textBox1.TabIndex = 3;
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(941, 568);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(104, 45);
            this.btndangky.TabIndex = 7;
            this.btndangky.Text = "Đăng ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // DangKyHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 620);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "DangKyHocPhan";
            this.Text = "DangKyHocPhan";
            this.Load += new System.EventHandler(this.DangKyHocPhan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhsachhocphan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_dshpdk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtg_danhsachhocphan;
        private System.Windows.Forms.DataGridView dtg_dshpdk;
        //private System.Windows.Forms.Button btnDangKi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnxem_dshp;
        private System.Windows.Forms.Button btnxem_dsdk;
        private System.Windows.Forms.Button btnhuydk;
        private System.Windows.Forms.Button btndangky;
    }
}