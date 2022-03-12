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
    public partial class Tracuukqht : Form
    {
        string tendangnhap = "";
        DTO_LOPHOCPHAN dto_dkhp = new DTO_LOPHOCPHAN();
        BUS_DKHP bus_dkhp = new BUS_DKHP();
        BUS_DKCHUYENDE bus_dkcd = new BUS_DKCHUYENDE();
        BUS_DKCHUNGCHI bus_dkcc = new BUS_DKCHUNGCHI();
        public Tracuukqht()
        {
            InitializeComponent();
        }
        public Tracuukqht(string tendangnhap)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
        }

        private void Tracuukqht_Load(object sender, EventArgs e)
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

        private void btnlthocphan_Click(object sender, EventArgs e)
        {
            dtg_xemketquaHP.Visible = true;
            cbbnamhoc.Visible = true;
            cbbhocky.Visible = true;

            dtg_xemketquaCD.Visible = false;
            cbbnamhocCD.Visible = false;
            cbbhockyCD.Visible = false;

            dtg_xemketquaCC.Visible = false;
            cbbHocKyCC.Visible = false;
            cbbNamhocCC.Visible = false;
        }

        private void btnltchuyende_Click(object sender, EventArgs e)
        {
            dtg_xemketquaHP.Visible = false;
           cbbnamhoc.Visible = false;
            cbbhocky.Visible = false;

           dtg_xemketquaCD.Visible = true;
            cbbnamhocCD.Visible = true;
            cbbhockyCD.Visible = true;

            dtg_xemketquaCC.Visible = false;
            cbbHocKyCC.Visible = false;
            cbbNamhocCC.Visible = false;
        }
    }
}
