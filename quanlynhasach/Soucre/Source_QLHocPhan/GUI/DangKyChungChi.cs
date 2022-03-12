using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Data.SqlClient;

namespace GUI
{
    public partial class DangKyChungChi : Form
    {
        BUS_DKCHUNGCHI bus_dkcc = new BUS_DKCHUNGCHI();

        public string TenDangnhap = "";
        public string Matkhau = "";
        public string HoTen = "";
        public string Quyen = "";
        public DangKyChungChi()
        {
            InitializeComponent();
        }
        public DangKyChungChi(string tendangnhap)//string matkhau)//string matkhau, string quyen)
        {
            InitializeComponent();
            this.TenDangnhap = tendangnhap;
            //this.Matkhau = matkhau;
            //this.HoTen = hoten;
            //this.Quyen = quyen;

        }


        private void btnxem_dsdk_Click(object sender, EventArgs e)
        {
            DTO_DKCHUNGCHI dto_dk = new DTO_DKCHUNGCHI(TenDangnhap);
            dtg_dsccdk.DataSource = bus_dkcc.XemDSChungChiDK(dto_dk);
        }

        private void btnxem_dscc_Click(object sender, EventArgs e)
        {
            DTO_DKCHUNGCHI dto_dk = new DTO_DKCHUNGCHI(txtMaLoai.Text);
            dtg_danhsachchungchi.DataSource = bus_dkcc.getLopChungChi(dto_dk);

        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            DTO_DKCHUNGCHI dto_tk = new DTO_DKCHUNGCHI(TenDangnhap,txtMaLoai.Text,dtg_danhsachchungchi.CurrentRow.Cells["MaLopChungChi"].Value.ToString());
            if (bus_dkcc.DangKiLopChungChi(dto_tk) == true)
            {
                MessageBox.Show("Đăng kí thanh cong!");

            }
            else
            {
                MessageBox.Show("Đăng kí không thành công!");

            }
        }

        private void DangKyChungChi_Load(object sender, EventArgs e)
        {
            textBox1.Text = TenDangnhap;
        }

        private void rdio_A_CheckedChanged(object sender, EventArgs e)
        {
            if(rdio_A.Checked) //If checked == true
            {
                txtMaLoai.Text = "LCCA";
                //example
            }
        }

        private void radio_B_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_B.Checked) //If checked == true
            {
                txtMaLoai.Text = "LCCB";
                //example
            }
        }

        private void btnhuydkchungchi_Click(object sender, EventArgs e)
        {
            DTO_DKCHUNGCHI dto_tk = new DTO_DKCHUNGCHI(dtg_dsccdk.CurrentRow.Cells["MaPhieuDK"].Value.ToString());
            if (bus_dkcc.HuyDangKiLopChungChi(dto_tk) == true)
            {
                MessageBox.Show("Hủy Đăng kí thành công!");

            }
            else
            {
                MessageBox.Show("Không hủy thành công!");

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
