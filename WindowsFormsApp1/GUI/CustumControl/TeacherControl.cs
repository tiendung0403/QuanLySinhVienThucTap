using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.GUI.MainForm;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class TeacherControl : UserControl
    {
        private QuanLyGiangVien quanly;

        public TeacherControl()
        {
            quanly = new QuanLyGiangVien();
            InitializeComponent();
            DisplayCmbo(new QuanLyKhoa().getDanhSachKhoa());
            DisplayCmboLoc(quanly.getDanhSachGV());
        }

        private void hienThiDanhSach(DataGridView dgv, List<GiangVien> ds)
        {
            dgv.DataSource = ds.ToList();
            dgv.Refresh();
        }

        private void DisplayCmbo(List<Khoa> ds)
        {
            var distinctKhoa = ds.Select(k => k.MaKhoa).Distinct().ToList();
            cmboKhoa.DataSource = distinctKhoa;
            cmboKhoa.DisplayMember = "MaKhoa";
        }

        private void DisplayCmboLoc(List<GiangVien> ds)
        {
            var distinctKhoa = ds.Select(k => k.Khoa).Distinct().ToList();
            cmboLocKhoa.DataSource = distinctKhoa;
            cmboLocKhoa.DisplayMember = "Khoa"; 

            var distincetrangthai = ds.Select(k => k.TrangThai).Distinct().ToList();
            cmboTrangThai.DataSource = distincetrangthai;
            cmboTrangThai.DisplayMember = "TrangThai"; 
        }

        private void TeacherControl_Load(object sender, EventArgs e)
        {
            
            hienThiDanhSach(dgvDSGV, quanly.getDanhSachGV());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            try
            {
                GiangVien gv = new GiangVien(txtMa.Text, txtTen.Text, txtGioitinh.Text, dateNgaySinh.Value, txtChucvu.Text, txtEmail.Text, txtSDT.Text,cmboKhoa.Text);
                if (quanly.Them(gv))
                {
                    hienThiDanhSach(dgvDSGV, quanly.getDanhSachGV());
                   
                }
                else
                {
                    MessageBox.Show("Giảng Viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            {
                txtMa.Enabled = false;
                try
                {
                    GiangVien gv = new GiangVien(txtMa.Text, txtTen.Text, txtGioitinh.Text, dateNgaySinh.Value, txtChucvu.Text, txtEmail.Text, txtSDT.Text,cmboKhoa.Text);
                    if (quanly.Sua(gv))
                    {
                        hienThiDanhSach(dgvDSGV, quanly.getDanhSachGV());

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + " Vui lòng nhập đầy đủ thông tin hoặc chọn hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            GiangVien giangVien = quanly.Tim(txtMa.Text);
            if (giangVien != null)
            {

                if (giangVien.TrangThai == DTO.TrangThai.DangDay)
                {
                    MessageBox.Show("Không thể xóa vì giảng viên đang được phân công dạy vui lòng thay đổi gv trước khi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (giangVien.TrangThai == DTO.TrangThai.NghiDay)
                {
                    foreach(KetQua kq in new QuanLyKetQua().getDanhSachKetQua())
                    {
                        if(kq.GiaoVien.MaGiangVien == giangVien.MaGiangVien)
                        {
                            MessageBox.Show("Giáo viên đã có dữ liệu trong danh sách kết quả thực tập của sinh viên , không được xóa");
                            return;
                        }
                    }
                    if (quanly.xoa(txtMa.Text))
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienThiDanhSach(dgvDSGV, quanly.getDanhSachGV());
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy giảng viên cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        string getCodeGV = null;
        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSGV.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string ma = dgvDSGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    getCodeGV = ma;
                    GiangVien gv = quanly.Tim(ma);
                    if (gv != null)
                    {
                        txtMa.Text = gv.MaGiangVien;
                        txtTen.Text = gv.HoTen;
                        txtGioitinh.Text = gv.GioiTinh;
                        dateNgaySinh.Value = gv.NgaySinh;
                        txtChucvu.Text = gv.ChucVu;
                        txtEmail.Text = gv.Email;
                        txtSDT.Text = gv.SoDienThoai;

                        txtMaGVhientai.Text = gv.MaGiangVien;
                        txtTenGVhientai.Text = gv.HoTen;

                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text;
            List<GiangVien> ketQua = quanly.TimKiem(tuKhoa);
            hienThiDanhSach(dgvDSGV, ketQua);
        }
      
        private void dgvDSGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSGV.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (e.Value != null)
                {
                    TrangThai trangThai = (TrangThai)e.Value;
                    if (trangThai == DTO.TrangThai.DangDay)
                    {
                        e.Value = "Đã được phân công";
                    }
                    else if (trangThai == DTO.TrangThai.NghiDay)
                    {
                        e.Value = "Chưa được phân công";
                    }
                }
            }
        }

        private void cmboLocKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<GiangVien> ds = quanly.TimDsTheoKhoa(cmboLocKhoa.Text);
            hienThiDanhSach(dgvDSGV, ds);
        }

        private void cmboTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<GiangVien> ds = quanly.TimDsTheoTrangThai((TrangThai)cmboTrangThai.SelectedItem);
            hienThiDanhSach(dgvDSGV, ds);
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            string maGVhientai = txtMaGVhientai.Text;   
            string maGVthaythe = txtMaGVthaythe.Text;
            if(quanly.ThayTheGV(maGVhientai, maGVthaythe))
            {
                MessageBox.Show("Đã thay đổi công tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienThiDanhSach(dgvDSGV, quanly.getDanhSachGV());
            }

        }

        private void btnDetailStudent_Click(object sender, EventArgs e)
        {
            if(getCodeGV == null)
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmDetailTeacher frm = new frmDetailTeacher(getCodeGV);
            frm.ShowDialog();
        }
    }
}
