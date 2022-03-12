using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DKCHUYENDE
    {
        private string MSSV;
        private string MaLopCD;
        public string DTO_MSSV
        {
            get { return MSSV; }
            set { MSSV = value; }
        }
        public string DTO_MaLopCD
        {
            get { return MaLopCD; }
            set { MaLopCD= value; }
        }
        public DTO_DKCHUYENDE() { }
        public DTO_DKCHUYENDE(string mssv)
        {
            this.MSSV= mssv;
        }
        public DTO_DKCHUYENDE(string mssv, string malopcd)
        {
            this.MSSV = mssv;
            this.MaLopCD = malopcd;

        }

    }
}
