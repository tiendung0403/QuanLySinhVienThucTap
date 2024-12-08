using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class CompanyControl : UserControl
    {
        private QuanLyCongTy quanly;
        public event EventHandler ExitButtonClicked;

        public CompanyControl()
        {            
            quanly = new QuanLyCongTy();
            InitializeComponent();
        }
        private void CompanyControl_Load(object sender, EventArgs e)
        {
            hienThiDanhSach(dgvDanhsachcongty, quanly.getDanhSachCongTy());
        }


        private void hienThiDanhSach(DataGridView dgv, List<CongTy> ds)
        {
            dgv.DataSource = ds.ToList();
            dgv.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            try
            {
                CongTy nsx = new CongTy(txtMa.Text, txtTen.Text, txtTenVT.Text, txtDiachi.Text, txtSDT.Text, txtEmail.Text);
                if (quanly.Them(nsx))
                {
                    hienThiDanhSach(dgvDanhsachcongty, quanly.getDanhSachCongTy());
                }
                else
                    MessageBox.Show("Công ty đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            try
            {
                CongTy nsx = new CongTy(txtMa.Text, txtTen.Text, txtTenVT.Text, txtDiachi.Text,txtSDT.Text, txtEmail.Text);
                if (quanly.Sua(nsx))
                    hienThiDanhSach(dgvDanhsachcongty, quanly.getDanhSachCongTy());

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message+" vui lòng nhập thông tin hoặc click chọn vào hàng cần sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void txtClear()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtTenVT.Clear();
            txtDiachi.Clear();
            txtEmail.Clear();
            txtSDT.Clear();

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            txtClear();
            hienThiDanhSach(dgvDanhsachcongty, quanly.getDanhSachCongTy());

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, e);
        }

        private void dgvDanhsachcongty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                CongTy cty = quanly.Tim(dgvDanhsachcongty.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtMa.Text = cty.MaCongTy;
                txtTen.Text = cty.TenCongTy;
                txtTenVT.Text = cty.TenVietTat;
                txtDiachi.Text = cty.DiaChi;
                txtEmail.Text = cty.Email;
                txtSDT.Text = cty.SoDienThoai;
            }

        }
    }
}
