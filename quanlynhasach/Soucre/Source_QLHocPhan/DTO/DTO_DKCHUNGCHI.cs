using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DKCHUNGCHI
    {
        string MSSV;
        string MaLopCC;
        string MaLoaiCC;
        public string DTO_MSSV
        {
            get { return MSSV; }
            set { MSSV = value; }
        }
        public string DTO_MaLopCC
        {
            get { return MaLopCC; }
            set { MaLopCC = value; }
        }
        public string DTO_MaLoaiCC
        {
            get { return MaLoaiCC; }
            set { MaLoaiCC = value; }
        }
        public DTO_DKCHUNGCHI() { }
        public DTO_DKCHUNGCHI(string mssv)
        {
            this.MSSV = mssv;
        }
       
        public DTO_DKCHUNGCHI(string mssv, string maloaiCC)
        {
            this.MSSV = mssv;
            this.MaLoaiCC = maloaiCC;
        }
        public DTO_DKCHUNGCHI(string mssv,string maloaicc,string malopcc)
        {
            this.MSSV = mssv;
            this.MaLoaiCC = maloaicc;
            this.MaLopCC = malopcc;
        }
    }
}
