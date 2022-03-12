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
using System.Data.SqlTypes;
namespace GUI
{
    public partial class Form1 : Form
    {
        BUS_TAIKHOAN bus_tk = new BUS_TAIKHOAN();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //public string quyen = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if(txttendn.Text !="" && txtmatkhau.Text !="")
            {
                //tao DTO
                DTO_TAIKHOAN dto_tk = new DTO_TAIKHOAN(txttendn.Text, txtmatkhau.Text);
                if(bus_tk.DANGNHAP(dto_tk)==true)
                {
                    
                        MessageBox.Show("dang nhap thanh cong!");
                    //DangKyHocPhan F = new DangKyHocPhan(dto_tk.TK_TENDANGNHAP,dto_tk.TK_HOTEN,dto_tk.TK_MATKHAU,dto_tk.TK_QUYEN);
                    //DangKyChuyenDe F = new DangKyChuyenDe(dto_tk.TK_TENDANGNHAP,dto_tk.TK_HOTEN,dto_tk.TK_MATKHAU,dto_tk.TK_QUYEN);
                    //DangKyChungChi F = new DangKyChungChi(dto_tk.TK_TENDANGNHAP, dto_tk.TK_HOTEN, dto_tk.TK_MATKHAU, dto_tk.TK_QUYEN);
                      this.Hide();
                        FMain_SV F = new FMain_SV(txttendn.Text,txtmatkhau.Text);
                        F.Show();
                    
                    
                    

                }    
                else
                {
                    MessageBox.Show("Khong dang nhap thanh cong!");

                }
            }
            else
            {
                MessageBox.Show("Nhap thong tin!");

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnquenmatkhau_Click(object sender, EventArgs e)
        {
            QuenMatKhau f = new QuenMatKhau();
            f.ShowDialog();
        }
    }
}
