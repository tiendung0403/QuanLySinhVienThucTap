using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.CustumControl
{
    public partial class ProjectControl : UserControl
    {
        private QuanLyDeTai quanly;
        public ProjectControl()
        {
            InitializeComponent();
            quanly = new QuanLyDeTai();
        }
        private bool kiemtraRong()
        {
            if (txtMa.Text == "" || txtTen.Text == "") return true;
            else return false;
        }

        private void hienThiDanhSachNhaSanXuat(DataGridView dgv, List<DeTai> ds)
        {
            dgv.DataSource = ds.ToList();
            dgv.Refresh();
        }
        private void ProjectControl_Load(object sender, EventArgs e)
        {
            List<DeTai> dsDeTai = quanly.getDanhSachDeTai();
            hienThiDanhSachNhaSanXuat(dgvDanhSachDeTai, dsDeTai);
        }

        private void btnaAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            if (kiemtraRong())
            {
                MessageBox.Show("Không được để trống ô nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DeTai nsx = new DeTai(txtMa.Text, txtTen.Text, dateNgayBD.Value, dateNgayKT.Value, comboLoaiDT.Text, comboMaCTY.Text);
                if (quanly.Them(nsx))
                {
                    hienThiDanhSachNhaSanXuat(dgvDanhSachDeTai, quanly.getDanhSachDeTai());
                }
                else
                {
                    MessageBox.Show("Loại đề tài đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

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

        private void btnReadFile_Click(object sender, EventArgs e)
        {

        }

    }
}
