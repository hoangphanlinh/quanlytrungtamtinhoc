using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class DAO_TAIKHOAN:DBConnect
    {
        public bool DANGNHAP(DTO_TAIKHOAN tk)
        {
            try
            {
                // Ket noi
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select*from TaiKhoan where Tendangnhap= N'" + tk.TK_TENDANGNHAP + "'and Matkhau = N'" + tk.TK_MATKHAU + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    tk.TK_NHAPLAIMK = dt.Columns["Quyen"].ToString();
                    return true;
                }    
                
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                // Dong ket noi
                con.Close();
            }

            return false;
        }
        public bool QuenMatKhau(DTO_TAIKHOAN dto_Taikhoan)
        {
            try
            {
                con.Open();
                // Tạo đối tượng SqlCommand
                SqlDataAdapter data = new SqlDataAdapter("DoiMatKhau", con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar, 10).Value = dto_Taikhoan.TK_TENDANGNHAP;
                data.SelectCommand.Parameters.Add("@MatKhauMoi", SqlDbType.NVarChar, 10).Value = dto_Taikhoan.TK_MATKHAU;
                data.SelectCommand.Parameters.Add("@NhapLaiMatKhau", SqlDbType.NVarChar, 10).Value = dto_Taikhoan.TK_NHAPLAIMK;

                //data.SelectCommand.ExecuteNonQuery();

                if (data.SelectCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                con.Close();
            }

            return false;
        }
        public DataTable getThongTinTaiKhoan(DTO_TAIKHOAN TTTK)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from SinhVien where MSSV= N'" + TTTK.TK_TENDANGNHAP+ "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;

        }
        public bool CapNhatThongTinTK(DTO_TAIKHOAN TTTK)
        {
            try
            {
                con.Open();
                // Tạo đối tượng SqlCommand
                SqlDataAdapter data = new SqlDataAdapter("UPDATE SinhVien SET SDT = @SDT WHERE MSSV = @MSSV", con);
                data.SelectCommand.CommandType = CommandType.Text;
                data.SelectCommand.Parameters.Add("@SDT", SqlDbType.NVarChar, 10).Value = TTTK.TK_TENDANGNHAP;
                data.SelectCommand.Parameters.Add("@MSSV", SqlDbType.NVarChar, 10).Value = TTTK.TK_MATKHAU;
         

                //data.SelectCommand.ExecuteNonQuery();

                if (data.SelectCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                con.Close();
            }

            return false;
        }

    }
}
