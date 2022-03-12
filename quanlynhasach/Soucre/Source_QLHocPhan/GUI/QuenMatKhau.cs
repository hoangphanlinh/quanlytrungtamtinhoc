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
    public partial class QuenMatKhau : Form
    {
        BUS_TAIKHOAN bus_tk = new BUS_TAIKHOAN();
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            
            DTO_TAIKHOAN dto_tk = new DTO_TAIKHOAN(txttendn.Text,txtmatkhaumoi.Text,txtnhaplaimk.Text);
            if (bus_tk.QuenMatKhau(dto_tk) == true)
            {
                MessageBox.Show("Cập nhật thành công!");

            }
            else
            {
                MessageBox.Show("Không thành công!");

            }
        }

       

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txttendn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatkhaumoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnhaplaimk_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
