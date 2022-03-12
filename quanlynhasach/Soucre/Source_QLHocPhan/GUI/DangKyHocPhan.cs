using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using DTO;
using BUS;
namespace GUI
{
    public partial class DangKyHocPhan : Form
    {
        public string TenDangnhap = "";
        public string Matkhau = "";
        public string HoTen = "";
        public string Quyen = "";

        DTO_TAIKHOAN tk = new DTO_TAIKHOAN();
        BUS_DKHP dkhp = new BUS_DKHP();
        public DangKyHocPhan()
        {
            InitializeComponent();
        }
        public DangKyHocPhan(string tendangnhap) //string hoten, string matkhau, string quyen)
        {
            InitializeComponent();
            this.TenDangnhap = tendangnhap;
            /*this.Matkhau = matkhau;
            this.HoTen = hoten;
            this.Quyen = quyen;*/

        }

        private void DangKyHocPhan_Load(object sender, EventArgs e)
        {
            textBox1.Text = TenDangnhap;
        }

        private void btnxem_dsdk_Click(object sender, EventArgs e)
        {
           
            DTO_LOPHOCPHAN dto_dkhp = new DTO_LOPHOCPHAN(TenDangnhap);
            dtg_dshpdk.DataSource = dkhp.XemDSHocphanDK(dto_dkhp);
        }

        private void btnxem_dshp_Click(object sender, EventArgs e)
        {
            
            dtg_danhsachhocphan.DataSource = dkhp.getLopHocPhan();
        }

        

        private void btnhuydk_Click(object sender, EventArgs e)
        {
            DTO_LOPHOCPHAN dto_tk = new DTO_LOPHOCPHAN(dtg_dshpdk.CurrentRow.Cells["MaPhieuDKHP"].Value.ToString());
            if (dkhp.HuyDangKiHocPhan(dto_tk) == true)
            {
                MessageBox.Show("Hủy Đăng kí thanh cong!");

            }
            else
            {
                MessageBox.Show("Hủy không thành công!");

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DangKyHocPhan f = new DangKyHocPhan();
            f.Close();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            DTO_LOPHOCPHAN dto_tk = new DTO_LOPHOCPHAN(TenDangnhap, dtg_danhsachhocphan.CurrentRow.Cells["MaLopHP"].Value.ToString());
            if (dkhp.DangKiLopHocPhan(dto_tk) == true)
            {
                MessageBox.Show("Đăng kí thanh cong!");

            }
            else
            {
                MessageBox.Show("Đăng kí không thành công!");

            }
        }
    }
}

    


