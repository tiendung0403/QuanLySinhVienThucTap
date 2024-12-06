using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
        private bool kiemtradiem(string s)
        {
            try
            {
                double.Parse(txtDTB.Text);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            if (kiemtradiem(txtDTB.Text))
            {
                try
                {

                    SinhVien nsx = new SinhVien(txtMa.Text, txtHoten.Text, txtGioitinh.Text, dateNgaySinh.Value, txtEmail.Text, txtSDT.Text, double.Parse(txtDTB.Text), txtLopHoc.Text, comboMaCty.Text, comboMaGV.Text);
                    if (quanly.Them(nsx))
                    {
                        hienThiDanhSach(dgvDSSinhvien, quanly.DanhSachSV);
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            else MessageBox.Show("Điểm không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
