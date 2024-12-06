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
    public partial class TeacherControl : UserControl
    {
        private QuanLyGiangVien quanly;
        public event EventHandler ExitButtonClicked;

        public TeacherControl()
        {
            quanly = new QuanLyGiangVien();
            InitializeComponent();
        }
        private bool kiemtraRong()
        {
            if (txtMa.Text == "" || txtTen.Text == "" || txtGioitinh.Text == "" || txtChucvu.Text == "" || txtEmail.Text == "" || txtSDT.Text == "")
                return true;
            else return false;
        }

        private void hienThiDanhSach(DataGridView dgv, List<GiangVien> ds)
        {
            dgv.DataSource = ds.ToList();
        }

        private void TeacherControl_Load(object sender, EventArgs e)
        {
            hienThiDanhSach(dgvDSGV, quanly.DanhsachGiangVien);
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
                GiangVien gv = new GiangVien(txtMa.Text, txtTen.Text, txtGioitinh.Text, dateNgaySinh.Value, txtChucvu.Text,txtEmail.Text, txtSDT.Text);
                if (quanly.Them(gv))
                {
                    hienThiDanhSach(dgvDSGV, quanly.getDanhSachGV());
                }
                else
                {
                    MessageBox.Show("Giảng Viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                GiangVien gv = new GiangVien(txtMa.Text, txtTen.Text, txtGioitinh.Text, dateNgaySinh.Value, txtChucvu.Text, txtEmail.Text, txtSDT.Text);
                if (quanly.Sua(gv))
                {
                    hienThiDanhSach(dgvDSGV, quanly.DanhsachGiangVien);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Giảng viên cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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
        private void txtClear()
        {
            txtMa.Clear();
            txtTen.Clear();
            txtChucvu.Clear();
            txtEmail.Clear();
            txtSDT.Clear();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            txtClear();
            hienThiDanhSach(dgvDSGV, quanly.getDanhSachGV());

        }
        public void btnExit_Click(object sender, EventArgs e)
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

                    quanly = new QuanLyGiangVien();
                    hienThiDanhSach(dgvDSGV, quanly.DanhsachGiangVien);
                }
                else
                {
                    MessageBox.Show("Không thể đọc tệp dữ liệu hoặc tệp không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                GiangVien gv = quanly.Tim(dgvDSGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtMa.Text = gv.MaGiangVien;
                txtTen.Text = gv.HoTen;
                txtGioitinh.Text = gv.GioiTinh;
                dateNgaySinh.Value = gv.NgaySinh;
                txtChucvu.Text = gv.ChucVu;
                txtEmail.Text = gv.Email;
                txtSDT.Text = gv.SoDienThoai;
            }

        }
    }
}
