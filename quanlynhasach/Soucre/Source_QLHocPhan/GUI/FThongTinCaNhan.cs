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
namespace GUI
{
    public partial class FThongTinCaNhan : Form
    {
        BUS_TAIKHOAN bus_tk = new BUS_TAIKHOAN();
        public string Tendanhnhap = "";
        public FThongTinCaNhan()
        {
            InitializeComponent();
        }
        public FThongTinCaNhan(string tendangnhap)
        {
            InitializeComponent();
            this.Tendanhnhap = tendangnhap;
        }

        private void FThongTinCaNhan_Load(object sender, EventArgs e)
        {
            DTO_TAIKHOAN dto_tk = new DTO_TAIKHOAN(Tendanhnhap);
            dtg_thongtincanhan.DataSource = bus_tk.getThongTinTaiKhoan(dto_tk);
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            DTO_TAIKHOAN dto_tk = new DTO_TAIKHOAN(dtg_thongtincanhan.CurrentRow.Cells["SDT"].Value.ToString(),Tendanhnhap);
            if(bus_tk.CapNhatThongTinTK(dto_tk)==true)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");

            }
        }
    }
}
