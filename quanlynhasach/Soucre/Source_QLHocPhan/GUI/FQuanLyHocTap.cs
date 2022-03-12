using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FQuanLyHocTap : Form
    {
        string tendangnhap = "";
        public FQuanLyHocTap()
        {
            InitializeComponent();
        }
        public FQuanLyHocTap(string tendangnhap)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
        }

        private void FQuanLyHocTap_Load(object sender, EventArgs e)
        {
            txthienthi.Text = tendangnhap;
        }

        private void btnxemlichthi_Click(object sender, EventArgs e)
        {
            
            this.panelhtqlht.Controls.Clear();

            Fxemlichthi frmChild = new Fxemlichthi(tendangnhap) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panelhtqlht.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }

        private void btntracukqht_Click(object sender, EventArgs e)
        {
            this.panelhtqlht.Controls.Clear();

            Tracuukqht frmChild = new Tracuukqht(tendangnhap) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panelhtqlht.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }
    }
}
