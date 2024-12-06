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
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class ProjectControl : UserControl
    {
        public event EventHandler ExitButtonClicked;

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

        private void hienThiDanhSach(DataGridView dgv, List<DeTai> ds)
        {
            dgv.DataSource = ds.ToList();
        }
        private void ProjectControl_Load(object sender, EventArgs e)
        {
            hienThiDanhSach(dgvDanhSachDeTai, quanly.DanhSachDeTai);
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
                    hienThiDanhSach(dgvDanhSachDeTai, quanly.getDanhSachDeTai());
                }
                else
                {
                    MessageBox.Show("Đề tài đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                DeTai nsx = new DeTai(txtMa.Text, txtTen.Text, dateNgayBD.Value, dateNgayKT.Value, comboLoaiDT.Text, comboMaCTY.Text);
                if (quanly.Sua(nsx))
                {
                    hienThiDanhSach(dgvDanhSachDeTai, quanly.DanhSachDeTai);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Đề tài cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            txtMa.Clear();
            txtTen.Clear();

            hienThiDanhSach(dgvDanhSachDeTai, quanly.getDanhSachDeTai());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, e);
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                bool result = TruyCapDuLieu.docFile(filePath);
                if (result)
                {
                    MessageBox.Show("Dữ liệu đã được tải thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    quanly = new QuanLyDeTai();
                    hienThiDanhSach(dgvDanhSachDeTai, quanly.DanhSachDeTai);
                }
                else
                {
                    MessageBox.Show("Không thể đọc tệp dữ liệu hoặc tệp không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvDanhSachDeTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DeTai dt = quanly.Tim(dgvDanhSachDeTai.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtMa.Text = dt.MaDT;
                txtTen.Text = dt.TenDT;
                dateNgayBD.Value = dt.NgayBatDau;
                dateNgayKT.Value = dt.NgayKetThuc;
                comboLoaiDT.Text = dt.LoaiDT;
                comboMaCTY.Text = dt.MaCTy;
            }
        }
    }
}
