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
    public class BUS_DKHP
    {
        DAO_DANGKIHP DAO_DKHP = new DAO_DANGKIHP();
        public DataTable XemDSHocphanDK(DTO_LOPHOCPHAN DKHP)
        {
            return DAO_DKHP.XemDSHocphanDK(DKHP);
        }
        public DataTable getLopHocPhan()
        {
            return DAO_DKHP.getLopHocPhan();
        }
        public bool DangKiLopHocPhan(DTO_LOPHOCPHAN DKHP)
        {
            return DAO_DKHP.DangKiLopHocPhan(DKHP);       
        }
        public bool HuyDangKiHocPhan(DTO_LOPHOCPHAN DKHP)
        {
            return DAO_DKHP.HuyDangKiHocPhan(DKHP);
        }
        public DataTable getLichThi_HocPhan(DTO_LOPHOCPHAN DKHP)
        {
            return DAO_DKHP.getLichThi_HocPhan(DKHP);
        }
        public DataTable getNamHoc_HocPhan()
        {
            return DAO_DKHP.getNamHoc_HocPhan();
        }
        public DataTable getHocKy_HocPhan()
        {
            return DAO_DKHP.getHocKy_HocPhan();
        }
        public DataTable XemLichThiHP_Nam(DTO_LOPHOCPHAN DKHP)
        {
            return DAO_DKHP.XemLichThiHP_Nam(DKHP);
        }
        public DataTable XemLichThiHP_HocKy(DTO_LOPHOCPHAN DKHP)
        {
            return DAO_DKHP.XemLichThiHP_HocKy(DKHP);
        }

    }
}
