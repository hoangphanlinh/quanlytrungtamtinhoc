using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LOPHOCPHAN
    {
        private string MSSV;
        private string MaLopHP;
        public string DK_MSSV
        {
            get { return MSSV; }
            set { MSSV = value; }
        }
        public string DK_MaLopHP
        {
            get { return MaLopHP; }
            set { MaLopHP = value; }
        }
        public DTO_LOPHOCPHAN() { }
        public DTO_LOPHOCPHAN(string mssv)
        {
            this.DK_MSSV = mssv;
        }
        public DTO_LOPHOCPHAN(string mssv, string malophp)
        {
            this.DK_MSSV = mssv;
            this.DK_MaLopHP = malophp;
        }


    }
    
}
