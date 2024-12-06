using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class StudentControl : UserControl
    {
        public event EventHandler ExitButtonClicked;
        private QuanLySinhVien quanly;

        public StudentControl()
        {
            quanly = new QuanLySinhVien();
            InitializeComponent();
        }

        private void hienThiDanhSach(DataGridView dgv, List<SinhVien> ds)
        {
            dgv.DataSource = ds.ToList();
        }
        private bool kiemtraRong()
        {
            if (txtMa.Text == "" || txtHoten.Text == "") return true;
            else return false;
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {
            hienThiDanhSach(dgvDSSinhvien, quanly.DanhSachSV);
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

        public void btnExit_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, e);
        }

        private void btnReal_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
