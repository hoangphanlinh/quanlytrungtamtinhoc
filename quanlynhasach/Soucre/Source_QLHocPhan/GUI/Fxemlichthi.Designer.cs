
namespace GUI
{
    partial class Fxemlichthi
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
            this.dtg_xemlichthi = new System.Windows.Forms.DataGridView();
            this.txthienthi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbnamhoc = new System.Windows.Forms.ComboBox();
            this.cbbhocky = new System.Windows.Forms.ComboBox();
            this.btnlthocphan = new System.Windows.Forms.Button();
            this.btnltchuyende = new System.Windows.Forms.Button();
            this.btnltchungchi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_xemlichthiCD = new System.Windows.Forms.DataGridView();
            this.dtg_xemlichthuCC = new System.Windows.Forms.DataGridView();
            this.cbbnamhocCD = new System.Windows.Forms.ComboBox();
            this.cbbhockyCD = new System.Windows.Forms.ComboBox();
            this.cbbNamhocCC = new System.Windows.Forms.ComboBox();
            this.cbbHocKyCC = new System.Windows.Forms.ComboBox();
            this.btnlichthicc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_xemlichthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_xemlichthiCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_xemlichthuCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_xemlichthi
            // 
            this.dtg_xemlichthi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_xemlichthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_xemlichthi.Location = new System.Drawing.Point(12, 99);
            this.dtg_xemlichthi.Name = "dtg_xemlichthi";
            this.dtg_xemlichthi.RowHeadersWidth = 51;
            this.dtg_xemlichthi.RowTemplate.Height = 24;
            this.dtg_xemlichthi.Size = new System.Drawing.Size(1042, 382);
            this.dtg_xemlichthi.TabIndex = 0;
            // 
            // txthienthi
            // 
            this.txthienthi.Location = new System.Drawing.Point(954, 12);
            this.txthienthi.Name = "txthienthi";
            this.txthienthi.Size = new System.Drawing.Size(100, 22);
            this.txthienthi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Học kỳ";
            // 
            // cbbnamhoc
            // 
            this.cbbnamhoc.FormattingEnabled = true;
            this.cbbnamhoc.Location = new System.Drawing.Point(99, 57);
            this.cbbnamhoc.Name = "cbbnamhoc";
            this.cbbnamhoc.Size = new System.Drawing.Size(169, 24);
            this.cbbnamhoc.TabIndex = 4;
            this.cbbnamhoc.SelectedIndexChanged += new System.EventHandler(this.cbbnamhoc_SelectedIndexChanged);
            this.cbbnamhoc.SelectionChangeCommitted += new System.EventHandler(this.cbbnamhoc_SelectionChangeCommitted);
            // 
            // cbbhocky
            // 
            this.cbbhocky.FormattingEnabled = true;
            this.cbbhocky.Location = new System.Drawing.Point(359, 57);
            this.cbbhocky.Name = "cbbhocky";
            this.cbbhocky.Size = new System.Drawing.Size(169, 24);
            this.cbbhocky.TabIndex = 5;
            this.cbbhocky.SelectedIndexChanged += new System.EventHandler(this.cbbhocky_SelectedIndexChanged);
            this.cbbhocky.SelectionChangeCommitted += new System.EventHandler(this.cbbhocky_SelectionChangeCommitted);
            // 
            // btnlthocphan
            // 
            this.btnlthocphan.Location = new System.Drawing.Point(99, 2);
            this.btnlthocphan.Name = "btnlthocphan";
            this.btnlthocphan.Size = new System.Drawing.Size(90, 32);
            this.btnlthocphan.TabIndex = 7;
            this.btnlthocphan.Text = "Học phần";
            this.btnlthocphan.UseVisualStyleBackColor = true;
            this.btnlthocphan.Click += new System.EventHandler(this.btnlthocphan_Click);
            // 
            // btnltchuyende
            // 
            this.btnltchuyende.Location = new System.Drawing.Point(219, 2);
            this.btnltchuyende.Name = "btnltchuyende";
            this.btnltchuyende.Size = new System.Drawing.Size(90, 32);
            this.btnltchuyende.TabIndex = 8;
            this.btnltchuyende.Text = "Chuyên đề";
            this.btnltchuyende.UseVisualStyleBackColor = true;
            this.btnltchuyende.Click += new System.EventHandler(this.btnltchuyende_Click);
            // 
            // btnltchungchi
            // 
            this.btnltchungchi.Location = new System.Drawing.Point(337, 2);
            this.btnltchungchi.Name = "btnltchungchi";
            this.btnltchungchi.Size = new System.Drawing.Size(90, 32);
            this.btnltchungchi.TabIndex = 9;
            this.btnltchungchi.Text = "Chứng chỉ";
            this.btnltchungchi.UseVisualStyleBackColor = true;
            this.btnltchungchi.Click += new System.EventHandler(this.btnltchungchi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lịch Thi";
            // 
            // dtg_xemlichthiCD
            // 
            this.dtg_xemlichthiCD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_xemlichthiCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_xemlichthiCD.Location = new System.Drawing.Point(12, 99);
            this.dtg_xemlichthiCD.Name = "dtg_xemlichthiCD";
            this.dtg_xemlichthiCD.RowHeadersWidth = 51;
            this.dtg_xemlichthiCD.RowTemplate.Height = 24;
            this.dtg_xemlichthiCD.Size = new System.Drawing.Size(1042, 382);
            this.dtg_xemlichthiCD.TabIndex = 11;
            // 
            // dtg_xemlichthuCC
            // 
            this.dtg_xemlichthuCC.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_xemlichthuCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_xemlichthuCC.Location = new System.Drawing.Point(12, 99);
            this.dtg_xemlichthuCC.Name = "dtg_xemlichthuCC";
            this.dtg_xemlichthuCC.RowHeadersWidth = 51;
            this.dtg_xemlichthuCC.RowTemplate.Height = 24;
            this.dtg_xemlichthuCC.Size = new System.Drawing.Size(1042, 382);
            this.dtg_xemlichthuCC.TabIndex = 12;
            // 
            // cbbnamhocCD
            // 
            this.cbbnamhocCD.FormattingEnabled = true;
            this.cbbnamhocCD.Location = new System.Drawing.Point(99, 57);
            this.cbbnamhocCD.Name = "cbbnamhocCD";
            this.cbbnamhocCD.Size = new System.Drawing.Size(169, 24);
            this.cbbnamhocCD.TabIndex = 13;
            this.cbbnamhocCD.SelectionChangeCommitted += new System.EventHandler(this.cbbnamhocCD_SelectionChangeCommitted);
            // 
            // cbbhockyCD
            // 
            this.cbbhockyCD.FormattingEnabled = true;
            this.cbbhockyCD.Location = new System.Drawing.Point(359, 57);
            this.cbbhockyCD.Name = "cbbhockyCD";
            this.cbbhockyCD.Size = new System.Drawing.Size(169, 24);
            this.cbbhockyCD.TabIndex = 14;
            this.cbbhockyCD.SelectionChangeCommitted += new System.EventHandler(this.cbbhockyCD_SelectionChangeCommitted);
            // 
            // cbbNamhocCC
            // 
            this.cbbNamhocCC.FormattingEnabled = true;
            this.cbbNamhocCC.Location = new System.Drawing.Point(99, 57);
            this.cbbNamhocCC.Name = "cbbNamhocCC";
            this.cbbNamhocCC.Size = new System.Drawing.Size(169, 24);
            this.cbbNamhocCC.TabIndex = 15;
            this.cbbNamhocCC.SelectionChangeCommitted += new System.EventHandler(this.cbbNamhocCC_SelectionChangeCommitted);
            // 
            // cbbHocKyCC
            // 
            this.cbbHocKyCC.FormattingEnabled = true;
            this.cbbHocKyCC.Location = new System.Drawing.Point(359, 57);
            this.cbbHocKyCC.Name = "cbbHocKyCC";
            this.cbbHocKyCC.Size = new System.Drawing.Size(169, 24);
            this.cbbHocKyCC.TabIndex = 16;
            this.cbbHocKyCC.SelectionChangeCommitted += new System.EventHandler(this.cbbHocKyCC_SelectionChangeCommitted);
            // 
            // btnlichthicc
            // 
            this.btnlichthicc.Location = new System.Drawing.Point(555, 50);
            this.btnlichthicc.Name = "btnlichthicc";
            this.btnlichthicc.Size = new System.Drawing.Size(111, 36);
            this.btnlichthicc.TabIndex = 17;
            this.btnlichthicc.Text = "Xem Lịch Thi";
            this.btnlichthicc.UseVisualStyleBackColor = true;
            this.btnlichthicc.Click += new System.EventHandler(this.btnlichthicc_Click);
            // 
            // Fxemlichthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 493);
            this.Controls.Add(this.btnlichthicc);
            this.Controls.Add(this.cbbHocKyCC);
            this.Controls.Add(this.cbbNamhocCC);
            this.Controls.Add(this.cbbhockyCD);
            this.Controls.Add(this.cbbnamhocCD);
            this.Controls.Add(this.dtg_xemlichthuCC);
            this.Controls.Add(this.dtg_xemlichthiCD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnltchungchi);
            this.Controls.Add(this.btnltchuyende);
            this.Controls.Add(this.btnlthocphan);
            this.Controls.Add(this.cbbhocky);
            this.Controls.Add(this.cbbnamhoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txthienthi);
            this.Controls.Add(this.dtg_xemlichthi);
            this.Location = new System.Drawing.Point(179, 49);
            this.Name = "Fxemlichthi";
            this.Text = "Xem Lịch Thi";
            this.Load += new System.EventHandler(this.Fxemlichthi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_xemlichthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_xemlichthiCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_xemlichthuCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_xemlichthi;
        private System.Windows.Forms.TextBox txthienthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbnamhoc;
        private System.Windows.Forms.ComboBox cbbhocky;
        private System.Windows.Forms.Button btnlthocphan;
        private System.Windows.Forms.Button btnltchuyende;
        private System.Windows.Forms.Button btnltchungchi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_xemlichthiCD;
        private System.Windows.Forms.DataGridView dtg_xemlichthuCC;
        private System.Windows.Forms.ComboBox cbbnamhocCD;
        private System.Windows.Forms.ComboBox cbbhockyCD;
        private System.Windows.Forms.ComboBox cbbNamhocCC;
        private System.Windows.Forms.ComboBox cbbHocKyCC;
        private System.Windows.Forms.Button btnlichthicc;
    }
}