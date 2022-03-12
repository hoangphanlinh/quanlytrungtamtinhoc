using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DAO_DANGKIHP:DBConnect
    {

        public DataTable XemDSHocphanDK(DTO_LOPHOCPHAN DKHP)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from PhieuDangKyHocPhan where MSSV= N'" + DKHP.DK_MSSV+ "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable getLopHocPhan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LopHocPhan", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool DangKiLopHocPhan(DTO_LOPHOCPHAN DKHP)
        {
            try
            {
                con.Open();
                // Tạo đối tượng SqlCommand
                SqlDataAdapter data = new SqlDataAdapter("dangkylophocphan", con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.Add("@MSSV", SqlDbType.NVarChar, 10).Value = DKHP.DK_MSSV;
                data.SelectCommand.Parameters.Add("@MaLopHP", SqlDbType.NVarChar, 10).Value = DKHP.DK_MaLopHP;
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
        public bool HuyDangKiHocPhan(DTO_LOPHOCPHAN DKHP)
        {
            try
            {
                con.Open();
                // Tạo đối tượng SqlCommand
                SqlDataAdapter data = new SqlDataAdapter("HuyDKHocPhan", con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.Add("@MaPhieuDKHP", SqlDbType.NVarChar, 10).Value = DKHP.DK_MSSV;
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
        public DataTable getLichThi_HocPhan(DTO_LOPHOCPHAN DKHP)
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from LichThi_HocPhan where MSSV= N'" + DKHP.DK_MSSV + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable getNamHoc_HocPhan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT NamHoc FROM LichThi_HocPhan", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable getHocKy_HocPhan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DISTINCT HocKy FROM LichThi_HocPhan", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable XemLichThiHP_Nam(DTO_LOPHOCPHAN DKHP)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from LichThi_HocPhan where NamHoc= N'" + DKHP.DK_MSSV + "' and  MSSV = N'" + DKHP.DK_MaLopHP + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable XemLichThiHP_HocKy(DTO_LOPHOCPHAN DKHP)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from LichThi_HocPhan where HocKy= N'" + DKHP.DK_MSSV + "' and  MSSV = N'" + DKHP.DK_MaLopHP + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
    }
}
