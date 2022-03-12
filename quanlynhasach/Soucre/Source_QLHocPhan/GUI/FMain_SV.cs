using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
namespace GUI
{
    public partial class FMain_SV : Form
    {
        public string TenDangnhap = "";
        public string Matkhau = "";
        public string HoTen = "";
        public string Quyen = "";
        public FMain_SV()
        {
            InitializeComponent();
        }
        public FMain_SV(string tendangnhap,string matkhau)
        {
            InitializeComponent();
            this.TenDangnhap = tendangnhap;
            this.Matkhau = matkhau;
            //this.Quyen = quyen;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 F = new Form1();
            F.Show();
        }

        private void FMain_SV_Load(object sender, EventArgs e)
        {
            txthienthitendn.Text = TenDangnhap;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.panelhienthi.Controls.Clear();

            FThongTinCaNhan frmChild = new FThongTinCaNhan(txthienthitendn.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panelhienthi.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }

        private void btndkhp_Click(object sender, EventArgs e)
        {
            this.panelhienthi.Controls.Clear();

            DangKyHocPhan frmChild = new DangKyHocPhan(txthienthitendn.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panelhienthi.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }

        private void btndkcd_Click(object sender, EventArgs e)
        {
            this.panelhienthi.Controls.Clear();

            DangKyChuyenDe frmChild = new DangKyChuyenDe(txthienthitendn.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panelhienthi.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }

        private void btndkcc_Click(object sender, EventArgs e)
        {
            this.panelhienthi.Controls.Clear();

            DangKyChungChi frmChild = new DangKyChungChi(txthienthitendn.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panelhienthi.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }

        private void btnqlht_Click(object sender, EventArgs e)
        {
            this.panelhienthi.Controls.Clear();

            FQuanLyHocTap frmChild = new FQuanLyHocTap(txthienthitendn.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmChild.TopLevel = false;

            // Gắn vào panel
            this.panelhienthi.Controls.Add(frmChild);

            // Hiển thị form
            frmChild.Show();
        }
    }
}
