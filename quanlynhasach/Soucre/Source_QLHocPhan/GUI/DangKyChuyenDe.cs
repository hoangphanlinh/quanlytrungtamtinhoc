using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
namespace GUI
{
    
    public partial class DangKyChuyenDe : Form
    {
        BUS_DKCHUYENDE bus_dkcd = new BUS_DKCHUYENDE();
        
        public string TenDangnhap = "";
        public string Matkhau = "";
        public string HoTen = "";
        public string Quyen = "";
        public DangKyChuyenDe()
        {
            InitializeComponent();
        }
        public DangKyChuyenDe(string tendangnhap, string hoten, string matkhau, string quyen)
        {
            InitializeComponent();
            this.TenDangnhap = tendangnhap;
            this.Matkhau = matkhau;
            this.HoTen = hoten;
            this.Quyen = quyen;

        }
        public DangKyChuyenDe(string tendangnhap)
        {
            InitializeComponent();
            this.TenDangnhap = tendangnhap;
            

        }

        private void DangKyChuyenDe_Load(object sender, EventArgs e)
        {
            textBox1.Text = TenDangnhap;
        }

        private void btnxem_dsdk_Click(object sender, EventArgs e)
        {
            DTO_DKCHUYENDE dto_dk = new DTO_DKCHUYENDE(TenDangnhap);
            dtg_dschuyendedk.DataSource = bus_dkcd.DSChuyenDeDK(dto_dk);
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            DTO_DKCHUYENDE dto_tk = new DTO_DKCHUYENDE(TenDangnhap,dtg_danhsachchuyende.CurrentRow.Cells["MaLopCD"].Value.ToString());
            if (bus_dkcd.DangKiLopChuyenDe(dto_tk) == true)
            {
                MessageBox.Show("Đăng kí thành công!");

            }
            else
            {
                MessageBox.Show("Đăng kí không thành công!");

            }
        }

        private void btnxem_dschuyende_Click(object sender, EventArgs e)
        {
            dtg_danhsachchuyende.DataSource = bus_dkcd.getLopChuyenDe();

        }

        private void btnHuyCD_Click(object sender, EventArgs e)
        {
            DTO_DKCHUYENDE dto_tk = new DTO_DKCHUYENDE(dtg_dschuyendedk.CurrentRow.Cells["MaPhieuDKCD"].Value.ToString());
            if (bus_dkcd.HuyDangKiLopChuyenDe(dto_tk) == true)
            {
                MessageBox.Show("Hủy Đăng kí thanh cong!");

            }
            else
            {
                MessageBox.Show("Hủy không thành công!");

            }
        }
    }
}
