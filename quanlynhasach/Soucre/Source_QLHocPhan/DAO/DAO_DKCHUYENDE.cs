using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class DAO_DKCHUYENDE:DBConnect
    {

        public DataTable DSChuyenDeDK(DTO_DKCHUYENDE DKCD)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from PhieuDangKyCD where MSSV= N'" + DKCD.DTO_MSSV + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable getLopChuyenDe()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LopChuyenDe", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public bool DangKiLopChuyenDe(DTO_DKCHUYENDE DKCD)
        {
            try
            {
                con.Open();
                // Tạo đối tượng SqlCommand
                SqlDataAdapter data = new SqlDataAdapter("dangkychuyende", con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.Add("@MSSV", SqlDbType.NVarChar, 10).Value = DKCD.DTO_MSSV;
                data.SelectCommand.Parameters.Add("@MaLopCD", SqlDbType.NVarChar, 10).Value = DKCD.DTO_MaLopCD;
              

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
        public bool HuyDangKiLopChuyenDe(DTO_DKCHUYENDE DKCD)
        {
            try
            {
                con.Open();
                // Tạo đối tượng SqlCommand
                SqlDataAdapter data = new SqlDataAdapter("HuyDKChuyenDe", con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.Add("@MaPhieuDKCD", SqlDbType.NVarChar, 10).Value = DKCD.DTO_MSSV;

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
        public DataTable getLichThi_ChuyenDe()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LichThi_ChuyenDe", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable getNamHoc_ChuyenDe()
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select distinct NamHoc from LichThi_ChuyenDe", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable getHocKy_ChuyenDe()
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select distinct HocKy from LichThi_ChuyenDe", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable TimKiemLichThiCD_NamHoc(DTO_DKCHUYENDE DKCD)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from LichThi_ChuyenDe where NamHoc= N'" + DKCD.DTO_MSSV + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable TimKiemLichThiCD_HocKy(DTO_DKCHUYENDE DKCD)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from LichThi_ChuyenDe where HocKy= N'" + DKCD.DTO_MSSV + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }

    }
}
