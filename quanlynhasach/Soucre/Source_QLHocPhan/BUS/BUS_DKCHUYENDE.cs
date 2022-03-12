using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace BUS
{
    public class BUS_DKCHUYENDE
    {
        DAO_DKCHUYENDE DAO_DKCD = new DAO_DKCHUYENDE();
        public DataTable DSChuyenDeDK(DTO_DKCHUYENDE CD)
        {
            return DAO_DKCD.DSChuyenDeDK(CD);
        }
        public DataTable getLopChuyenDe()
        {
            return DAO_DKCD.getLopChuyenDe();
        }
        public bool DangKiLopChuyenDe(DTO_DKCHUYENDE CD)
        {
            return DAO_DKCD.DangKiLopChuyenDe(CD);
        }
        public bool HuyDangKiLopChuyenDe(DTO_DKCHUYENDE DKCD)
        {
            return DAO_DKCD.HuyDangKiLopChuyenDe(DKCD);
        }
        public DataTable getLichThi_ChuyenDe()
        {
            return DAO_DKCD.getLichThi_ChuyenDe();

        }
        public DataTable getNamHoc_ChuyenDe()
        {
            return DAO_DKCD.getNamHoc_ChuyenDe();
        }
        public DataTable getHocKy_ChuyenDe()
        {
            return DAO_DKCD.getHocKy_ChuyenDe();
        }
        public DataTable TimKiemLichThiCD_NamHoc(DTO_DKCHUYENDE DKCD)
        {
            return DAO_DKCD.TimKiemLichThiCD_NamHoc(DKCD);
        }
        public DataTable TimKiemLichThiCD_HocKy(DTO_DKCHUYENDE DKCD)
        {
            return DAO_DKCD.TimKiemLichThiCD_HocKy(DKCD);

        }



    }
}
