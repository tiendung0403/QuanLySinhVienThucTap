using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class StudentControl : UserControl
    {
        private QuanLySinhVien quanly;
        public StudentControl()
        {
            quanly = new QuanLySinhVien();
            InitializeComponent();
        }

        private void hienThiDanhSach(DataGridView dgv, List<SinhVien> ds)
        {
            dgv.DataSource = ds.ToList();
            dgv.Refresh();
        }
        private bool kiemtraRong()
        {
            if (txtMa.Text == "" || txtHoten.Text == "") return true;
            else return false;
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {
            List<SinhVien> dsSV = quanly.DanhSachSV;
            hienThiDanhSach(dgvDSSinhvien, dsSV);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }


        private void btnFix_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnReal_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
