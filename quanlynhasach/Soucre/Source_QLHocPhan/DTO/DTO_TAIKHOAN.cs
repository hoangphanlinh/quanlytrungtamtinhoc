using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TAIKHOAN
    {
        private string tendangnhap;
        private string hoten;
        private string matkhau;
        private string quyen;
        private string nhaplaimk;
        public string TK_TENDANGNHAP
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }
        public string TK_HOTEN
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string TK_MATKHAU
        {
            get { return matkhau; }
            set {matkhau = value; }
        }
        public string TK_QUYEN
        {
            get { return quyen; }
            set { quyen = value; }
        }
        public string TK_NHAPLAIMK
        {
            get { return nhaplaimk; }
            set { nhaplaimk = value; }
        }
        public DTO_TAIKHOAN() { }
        public DTO_TAIKHOAN(string tendangnhap)
        {
            this.tendangnhap = tendangnhap;
        }
        public DTO_TAIKHOAN(string tendn,string mk)
        {
            this.tendangnhap = tendn;
            //this.hoten = hoten;
            this.matkhau = mk;
            //this.quyen = quyen;
        }
        public DTO_TAIKHOAN(string tendn, string mkmoi,string nhaplaimk)
        {
            this.tendangnhap = tendn;
            this.matkhau = mkmoi;
            this.nhaplaimk = nhaplaimk;
        }
    }
}
