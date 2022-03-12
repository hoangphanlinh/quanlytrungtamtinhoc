using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace DAO
{
    public class DAO_DKCHUNGCHI:DBConnect
    {
        public DataTable XemDSChungChiDK(DTO_DKCHUNGCHI DKCC)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from PhieuDangKyHPChungChi where MSSV= N'" + DKCC.DTO_MSSV + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable getLopChungChi(DTO_DKCHUNGCHI DKCC)
        {
            SqlCommand cmd = new SqlCommand("xemlopchungchi", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@MaLoaiCC", DKCC.DTO_MSSV);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();
            return dt;

        }
        public bool DangKiLopChungChi(DTO_DKCHUNGCHI DKCC)
        {
            try
            {
                con.Open();
                // Tạo đối tượng SqlCommand
                SqlDataAdapter data = new SqlDataAdapter("dangkychungchi", con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.Add("@MSSV", SqlDbType.NVarChar, 10).Value = DKCC.DTO_MSSV;
                data.SelectCommand.Parameters.Add("@MaLoaiCC", SqlDbType.NVarChar, 10).Value = DKCC.DTO_MaLoaiCC;
                data.SelectCommand.Parameters.Add("@MaLopChungChi", SqlDbType.NVarChar, 10).Value = DKCC.DTO_MaLopCC;
                //data.SelectCommand.ExecuteNonQuery();

                if (data.SelectCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                // Dong ket noi
                con.Close();
            }

            return false;
        }
        public bool HuyDangKiLopChungChi(DTO_DKCHUNGCHI DKCC)
        {
            try
            {
                con.Open();
                // Tạo đối tượng SqlCommand
                SqlDataAdapter data = new SqlDataAdapter("HuyDKChungChi", con);
                data.SelectCommand.CommandType = CommandType.StoredProcedure;
                data.SelectCommand.Parameters.Add("@MaPhieuDKCC", SqlDbType.NVarChar, 10).Value = DKCC.DTO_MSSV;
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
        public DataTable getLichThi_ChungChi(DTO_DKCHUNGCHI DKCC)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from LichThi_ChungChi where MSSV= N'" + DKCC.DTO_MSSV + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable getNam_ChungChi()
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select distinct NamHoc from LichThi_ChungChi", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable getHocKy_ChungChi()
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select distinct HocKy from LichThi_ChungChi", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable TimKiemtHocKy_ChungChi(DTO_DKCHUNGCHI DKCC)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from LichThi_ChungChi where MSSV= N'" + DKCC.DTO_MSSV + "' and HocKy = N'" + DKCC.DTO_MaLoaiCC + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable TimKiemtNam_ChungChi(DTO_DKCHUNGCHI DKCC)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from LichThi_ChungChi where MSSV= N'" + DKCC.DTO_MSSV + "' and NamHoc = N'" + DKCC.DTO_MaLoaiCC + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }
        public DataTable TimKiemNam_HocKy_ChungChi(DTO_DKCHUNGCHI DKCC)
        {
            // Tạo đối tượng SqlCommand
            SqlDataAdapter da = new SqlDataAdapter("select*from LichThi_ChungChi where MSSV= N'" + DKCC.DTO_MSSV + "' and NamHoc = N'" + DKCC.DTO_MaLoaiCC + "' and HocKy = N'" + DKCC.DTO_MaLopCC + "'", con);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }




    }
}
