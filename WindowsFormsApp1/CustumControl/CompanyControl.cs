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
    public partial class CompanyControl : UserControl
    {
        private QuanLyCongTy quanly;
        public CompanyControl()
        {
            quanly = new QuanLyCongTy();
            InitializeComponent();
        }
        private void CompanyControl_Load(object sender, EventArgs e)
        {
            List<CongTy> dsCongty = quanly.getDanhSachCongTy();
            hienThiDanhSach(dgvDanhsachcongty, dsCongty);
        }

        private bool kiemtraRong()
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtDiachi.Text == "") return true;
            else return false;
        }

        private void hienThiDanhSach(DataGridView dgv, List<CongTy> ds)
        {
            dgv.DataSource = ds.ToList();
            dgv.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            if (kiemtraRong())
            {
                MessageBox.Show("Không được để trống ô nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CongTy nsx = new CongTy(txtMa.Text, txtTen.Text, txtTenVT.Text, txtDiachi.Text, txtEmail.Text, txtSDT.Text);
                if (quanly.Them(nsx))
                {
                    hienThiDanhSach(dgvDanhsachcongty, quanly.DanhsachCTy);
                }
                else
                {
                    MessageBox.Show("Công ty đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (kiemtraRong())
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtMa.Enabled = false;

                CongTy nsx = new CongTy(txtMa.Text, txtTen.Text, txtTenVT.Text, txtDiachi.Text, txtEmail.Text, txtSDT.Text);
                if (quanly.Sua(nsx))
                {
                    hienThiDanhSach(dgvDanhsachcongty, quanly.getDanhSachCongTy());
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Công ty cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                bool result = TruyCapDuLieu.ghiFile(filePath);
                if (result)
                {
                    MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu tệp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        }

        private void btnReadfile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                bool result = TruyCapDuLieu.docFile(filePath);
                if (result)
                {
                    MessageBox.Show("Dữ liệu đã được tải thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    quanly = new QuanLyCongTy();
                    hienThiDanhSach(dgvDanhsachcongty, quanly.getDanhSachCongTy());
                }
                else
                {
                    MessageBox.Show("Không thể đọc tệp dữ liệu hoặc tệp không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
