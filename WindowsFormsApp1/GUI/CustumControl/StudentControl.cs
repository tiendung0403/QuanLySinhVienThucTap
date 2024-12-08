using System;
using System.Collections.Generic;
using System.Linq;
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
            dgv.Refresh();
        }
        private void LoadData()
        {
            QuanLyGiangVien gv = new QuanLyGiangVien();
            comboMaGV.Items.Clear();
            comboMaCty.Items.Clear();
            foreach (GiangVien a in gv.getDanhSachGV())
            {
                comboMaGV.Items.Add(a.MaGiangVien);
            }
            QuanLyCongTy cty = new QuanLyCongTy();
            foreach (CongTy a in cty.getDanhSachCongTy())
            {
                comboMaCty.Items.Add(a.TenVietTat);
            }
        }

        private void StudentControl_Load(object sender, EventArgs e)
        {
            LoadData();
            hienThiDanhSach(dgvDSSinhvien, quanly.getDanhSachSinhVien());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            try
            {
                SinhVien sv = new SinhVien(txtMa.Text, txtHoten.Text, txtGioitinh.Text, dateNgaySinh.Value, txtEmail.Text, txtSDT.Text, txtDTB.Text, txtLopHoc.Text, comboMaCty.Text, comboMaGV.Text);
                if (quanly.Them(sv))
                {
                    hienThiDanhSach(dgvDSSinhvien, quanly.getDanhSachSinhVien());
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
        private void btnFix_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            try
            {
                SinhVien sv = new SinhVien(txtMa.Text, txtHoten.Text, txtGioitinh.Text, dateNgaySinh.Value, txtEmail.Text, txtSDT.Text, txtDTB.Text, txtLopHoc.Text, comboMaCty.Text, comboMaGV.Text);
                if (quanly.Sua(sv))
                {
                    hienThiDanhSach(dgvDSSinhvien, quanly.getDanhSachSinhVien());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " vui lòng nhập thông tin hoặc click chọn vào hàng cần sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = new SinhVien();
                sv.MaSinhVien = txtMa.Text;
                quanly.Xoa(sv.MaSinhVien);
                hienThiDanhSach(dgvDSSinhvien, quanly.getDanhSachSinhVien());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " vui click chọn vào hàng cần xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtHoten.Clear();
            txtEmail.Clear();
            txtSDT.Clear(); ;
            txtDTB.Clear();
            txtLopHoc.Clear();
            LoadData();
            hienThiDanhSach(dgvDSSinhvien, quanly.getDanhSachSinhVien());
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, e);
        }


        private void dgvDSSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                SinhVien sv = quanly.Tim(dgvDSSinhvien.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtMa.Text = sv.MaSinhVien;
                txtHoten.Text = sv.HoTen;
                txtGioitinh.Text = sv.GioiTinh;
                dateNgaySinh.Value = sv.NgaySinh;
                txtEmail.Text = sv.Email;
                txtSDT.Text = sv.SoDienThoai;
                txtDTB.Text = sv.DiemTrungBinh.ToString();
                txtLopHoc.Text = sv.Lop;
                comboMaCty.Text = sv.MaCongTy;
                comboMaGV.Text = sv.MaGiangVien;
            }

        }
    }
}
