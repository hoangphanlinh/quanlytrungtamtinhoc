using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace BUS
{
    public class BUS_TAIKHOAN
    {
        DAO_TAIKHOAN DAO_tk = new DAO_TAIKHOAN();
        public bool DANGNHAP(DTO_TAIKHOAN tk)
        {
            return DAO_tk.DANGNHAP(tk);
        }
        public bool QuenMatKhau(DTO_TAIKHOAN dto_Taikhoan)
        {
            return DAO_tk.QuenMatKhau(dto_Taikhoan);
        }
        public DataTable getThongTinTaiKhoan(DTO_TAIKHOAN TTTK)
        {
            return DAO_tk.getThongTinTaiKhoan(TTTK);
        }
        public bool CapNhatThongTinTK(DTO_TAIKHOAN TTTK)
        {
            return DAO_tk.CapNhatThongTinTK(TTTK);
        }


    }
}
