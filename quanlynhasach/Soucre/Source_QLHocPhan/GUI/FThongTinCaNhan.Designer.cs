
namespace GUI
{
    partial class FThongTinCaNhan
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
            this.dtg_thongtincanhan = new System.Windows.Forms.DataGridView();
            this.btncapnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtincanhan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_thongtincanhan
            // 
            this.dtg_thongtincanhan.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_thongtincanhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_thongtincanhan.Location = new System.Drawing.Point(12, 12);
            this.dtg_thongtincanhan.Name = "dtg_thongtincanhan";
            this.dtg_thongtincanhan.RowHeadersWidth = 51;
            this.dtg_thongtincanhan.RowTemplate.Height = 24;
            this.dtg_thongtincanhan.Size = new System.Drawing.Size(817, 135);
            this.dtg_thongtincanhan.TabIndex = 0;
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btncapnhat.Location = new System.Drawing.Point(739, 153);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(90, 27);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // FThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 191);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.dtg_thongtincanhan);
            this.Name = "FThongTinCaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FThongTinCaNhan";
            this.Load += new System.EventHandler(this.FThongTinCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_thongtincanhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_thongtincanhan;
        private System.Windows.Forms.Button btncapnhat;
    }
}