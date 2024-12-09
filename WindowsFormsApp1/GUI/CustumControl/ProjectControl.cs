using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class ProjectControl : UserControl
    {

        private QuanLyDeTai quanly;
       
        public ProjectControl()
        {               
            quanly = new QuanLyDeTai();
            InitializeComponent();
        }

        private void hienThiDanhSach(DataGridView dgv, List<DeTai> ds)
        {
            dgv.DataSource = ds.ToList();
            dgv.Refresh();
        }
        private void ProjectControl_Load(object sender, EventArgs e)
        {
            LoadDataCboCongTy(comboMaCTY,new QuanLyCongTy().getDanhSachCongTy());
            LoadDataCboLoaiDT(comboLoaiDT, new QuanLyLoaiDeTai().getDanhSachLoaiDT());
            hienThiDanhSach(dgvDanhSachDeTai, quanly.getDanhSachDeTai());
        }
        private void LoadDataCboCongTy(ComboBox cb, List<CongTy> ds)
        {
            cb.DisplayMember = "TenVietTat";
            cb.DataSource = ds;
        }
        private void LoadDataCboLoaiDT(ComboBox cb, List<LoaiDeTai> ds)
        {
            cb.DisplayMember = "TenLoai";
            cb.DataSource = ds;
        }

        private void btnaAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            try
            {
                DeTai nsx = new DeTai(txtMa.Text, txtTen.Text, dateNgayBD.Value, dateNgayKT.Value, comboLoaiDT.Text, comboMaCTY.Text);
                if (quanly.Them(nsx))
                {
                    hienThiDanhSach(dgvDanhSachDeTai, quanly.getDanhSachDeTai());
                }
                else
                    MessageBox.Show("Đề tài đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            try
            {
                DeTai nsx = new DeTai(txtMa.Text, txtTen.Text, dateNgayBD.Value, dateNgayKT.Value, comboLoaiDT.Text, comboMaCTY.Text);
                if (quanly.Sua(nsx))
                {
                    hienThiDanhSach(dgvDanhSachDeTai, quanly.getDanhSachDeTai());
                }
                else
                    MessageBox.Show("Không tìm thấy Đề tài cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message+ ", vui lòng nhập đầy đủ thông tin hoặc click chọn vào hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            quanly.Xoa(txtMa.Text);
            hienThiDanhSach(dgvDanhSachDeTai, quanly.getDanhSachDeTai());


        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            txtMa.Clear();
            txtTen.Clear();
            LoadDataCboCongTy(comboMaCTY, new QuanLyCongTy().getDanhSachCongTy());
            LoadDataCboLoaiDT(comboLoaiDT, new QuanLyLoaiDeTai().getDanhSachLoaiDT());
            hienThiDanhSach(dgvDanhSachDeTai, quanly.getDanhSachDeTai());
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

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimkiem.Text;
            List<DeTai> ketQua = quanly.TimKiem(tuKhoa);
            hienThiDanhSach(dgvDanhSachDeTai, ketQua);
        }
    }
}
