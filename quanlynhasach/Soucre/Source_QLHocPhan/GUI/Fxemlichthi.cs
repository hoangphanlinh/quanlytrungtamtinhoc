using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;
namespace GUI
{
    public partial class Fxemlichthi : Form
    {
        string tendangnhap = "";
        DTO_LOPHOCPHAN dto_dkhp = new DTO_LOPHOCPHAN();
        BUS_DKHP bus_dkhp = new BUS_DKHP();
        BUS_DKCHUYENDE bus_dkcd = new BUS_DKCHUYENDE();
        BUS_DKCHUNGCHI bus_dkcc = new BUS_DKCHUNGCHI();
        public Fxemlichthi()
        {
            InitializeComponent();
        }
        public Fxemlichthi(string tendangnhap)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
        }

        private void Fxemlichthi_Load(object sender, EventArgs e)
        {
            txthienthi.Text = tendangnhap;
        }
        public void Loadcombobox_hocphan()
        {
            cbbnamhoc.DataSource = bus_dkhp.getNamHoc_HocPhan();
            cbbhocky.DataSource = bus_dkhp.getHocKy_HocPhan();
            cbbnamhoc.DisplayMember = "NamHoc";
            cbbnamhoc.ValueMember = "NamHoc";
            cbbhocky.DisplayMember = "HocKy";
            cbbhocky.ValueMember = "HocKy";
        }
        public void Loadcombobox_chuyende()
        {
            cbbnamhocCD.DataSource = bus_dkcd.getNamHoc_ChuyenDe();
            cbbhockyCD.DataSource = bus_dkcd.getHocKy_ChuyenDe();
            cbbnamhocCD.DisplayMember = "NamHoc";
            cbbnamhocCD.ValueMember = "NamHoc";
            cbbhockyCD.DisplayMember = "HocKy";
            cbbhockyCD.ValueMember = "HocKy";
        }
        public void Loadcombobox_chungchi()
        {
            cbbNamhocCC.DataSource = bus_dkcc.getNam_ChungChi();
            cbbHocKyCC.DataSource = bus_dkcc.getHocKy_ChungChi();
            cbbNamhocCC.DisplayMember = "NamHoc";
            cbbNamhocCC.ValueMember = "NamHoc";
            cbbHocKyCC.DisplayMember = "HocKy";
            cbbHocKyCC.ValueMember = "HocKy";
        }
        private void cbbnamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void cbbhocky_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void btnlthocphan_Click(object sender, EventArgs e)
        {
            
            
            dtg_xemlichthi.Visible = true;
            cbbnamhoc.Visible = true;
            cbbhocky.Visible = true;

            dtg_xemlichthiCD.Visible = false;
            cbbnamhocCD.Visible = false;
            cbbhockyCD.Visible = false;

            dtg_xemlichthuCC.Visible = false;
            cbbHocKyCC.Visible = false;
            cbbNamhocCC.Visible = false;
            DTO_LOPHOCPHAN dkhp = new DTO_LOPHOCPHAN(tendangnhap);
            dtg_xemlichthi.DataSource = bus_dkhp.getLichThi_HocPhan(dkhp);
            Loadcombobox_hocphan();
        }

        private void btnltchuyende_Click(object sender, EventArgs e)
        {
            dtg_xemlichthi.Visible = false;
            cbbnamhoc.Visible = false;
            cbbhocky.Visible = false;

            dtg_xemlichthiCD.Visible = true;
            cbbnamhocCD.Visible = true;
            cbbhockyCD.Visible = true;

            dtg_xemlichthuCC.Visible = false;
            cbbHocKyCC.Visible = false;
            cbbNamhocCC.Visible = false;
            
            dtg_xemlichthiCD.DataSource = bus_dkcd.getLichThi_ChuyenDe();
            Loadcombobox_chuyende();
        }

        private void btnltchungchi_Click(object sender, EventArgs e)
        {
            dtg_xemlichthi.Visible = false;
            cbbnamhoc.Visible = false;
            cbbhocky.Visible = false;

            dtg_xemlichthiCD.Visible = false;
            cbbnamhocCD.Visible = false;
            cbbhockyCD.Visible = false;

            dtg_xemlichthuCC.Visible = true;
            cbbHocKyCC.Visible = true;
            cbbNamhocCC.Visible = true;
            DTO_DKCHUNGCHI dto_dkcc = new DTO_DKCHUNGCHI(tendangnhap);
            dtg_xemlichthuCC.DataSource = bus_dkcc.getLichThi_ChungChi(dto_dkcc);
            Loadcombobox_chungchi();


        }

        private void cbbnamhoc_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
                DTO_LOPHOCPHAN dkhp = new DTO_LOPHOCPHAN(cbbnamhoc.SelectedValue.ToString(),tendangnhap);
                dtg_xemlichthi.DataSource = bus_dkhp.XemLichThiHP_Nam(dkhp); 

        }

        private void cbbhocky_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
                DTO_LOPHOCPHAN dkhp = new DTO_LOPHOCPHAN(cbbhocky.SelectedValue.ToString(),tendangnhap);
                dtg_xemlichthi.DataSource = bus_dkhp.XemLichThiHP_HocKy(dkhp);
            
               
        }

        private void cbbnamhocCD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DTO_DKCHUYENDE dkcd = new DTO_DKCHUYENDE(cbbnamhocCD.SelectedValue.ToString());
            dtg_xemlichthiCD.DataSource = bus_dkcd.TimKiemLichThiCD_NamHoc(dkcd);
        }

        private void cbbhockyCD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DTO_DKCHUYENDE dkcd = new DTO_DKCHUYENDE(cbbhockyCD.SelectedValue.ToString());
            dtg_xemlichthiCD.DataSource = bus_dkcd.TimKiemLichThiCD_HocKy(dkcd);
        }

        private void cbbNamhocCC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DTO_DKCHUNGCHI dto_dkcc = new DTO_DKCHUNGCHI(tendangnhap, cbbNamhocCC.SelectedValue.ToString());
            dtg_xemlichthuCC.DataSource = bus_dkcc.TimKiemtNam_ChungChi(dto_dkcc);
        }

        private void cbbHocKyCC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DTO_DKCHUNGCHI dto_dkcc = new DTO_DKCHUNGCHI(tendangnhap, cbbHocKyCC.SelectedValue.ToString());
            dtg_xemlichthuCC.DataSource = bus_dkcc.TimKiemtHocKy_ChungChi(dto_dkcc);
        }

        private void btnlichthicc_Click(object sender, EventArgs e)
        {
            DTO_DKCHUNGCHI DTO_DKCC = new DTO_DKCHUNGCHI(tendangnhap, cbbNamhocCC.SelectedValue.ToString(), cbbHocKyCC.SelectedValue.ToString());
            dtg_xemlichthuCC.DataSource = bus_dkcc.TimKiemNam_HocKy_ChungChi(DTO_DKCC);
        }
    }
}
