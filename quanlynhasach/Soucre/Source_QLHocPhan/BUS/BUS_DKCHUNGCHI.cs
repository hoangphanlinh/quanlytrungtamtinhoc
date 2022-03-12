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
    public class BUS_DKCHUNGCHI
    {
        DAO_DKCHUNGCHI DAO_DKCC = new DAO_DKCHUNGCHI();
        public DataTable XemDSChungChiDK(DTO_DKCHUNGCHI DKCC)
        {
            return DAO_DKCC.XemDSChungChiDK(DKCC);
        }
        public DataTable getLopChungChi(DTO_DKCHUNGCHI DKCC)
        {
            return DAO_DKCC.getLopChungChi(DKCC);
        }
        public bool DangKiLopChungChi(DTO_DKCHUNGCHI DKCC)
        {
            return DAO_DKCC.DangKiLopChungChi(DKCC);
        }
        public bool HuyDangKiLopChungChi(DTO_DKCHUNGCHI DKCC)
        {
            return DAO_DKCC.HuyDangKiLopChungChi(DKCC);
        }
        public DataTable getLichThi_ChungChi(DTO_DKCHUNGCHI DKCC)
        {
            return DAO_DKCC.getLichThi_ChungChi(DKCC);
        }
        public DataTable getNam_ChungChi()
        {
            return DAO_DKCC.getNam_ChungChi();
        }
        public DataTable getHocKy_ChungChi()
        {
            return DAO_DKCC.getHocKy_ChungChi();
        }
        public DataTable TimKiemtHocKy_ChungChi(DTO_DKCHUNGCHI DKCC)
        {
            return DAO_DKCC.TimKiemtHocKy_ChungChi(DKCC);
        }
        public DataTable TimKiemtNam_ChungChi(DTO_DKCHUNGCHI DKCC)
        {
            return DAO_DKCC.TimKiemtNam_ChungChi(DKCC);
        }
        public DataTable TimKiemNam_HocKy_ChungChi(DTO_DKCHUNGCHI DKCC)
        {
            return DAO_DKCC.TimKiemNam_HocKy_ChungChi(DKCC);
        }

    }
}
