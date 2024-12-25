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
        private QuanLySinhVien qlSV;
        private QuanLyGiangVien qLGV;
       
        public ProjectControl()
        {               
            quanly = new QuanLyDeTai();
            qlSV = new QuanLySinhVien();
            qLGV =new QuanLyGiangVien();
            InitializeComponent();
        }

        private void hienThiDanhSach(DataGridView dgv, List<DeTai> ds)
        {
            dgv.Rows.Clear();
            
            foreach (DeTai deTai in ds)
            {
                if (deTai != null )
                {
                    if (deTai.SinhVien != null)
                    {
                        if (deTai.GiaoVien != null)
                        {
                            dgv.Rows.Add(deTai.MaDT, deTai.TenDT,
                                deTai.SinhVien.HoTen, deTai.SinhVien.MaSinhVien, deTai.NgayBatDau, deTai.NgayKetThuc,
                                deTai.LoaiDT, deTai.MaCTy, deTai.GiaoVien.MaGiangVien, deTai.TrangThai);
                        }
                        else { MessageBox.Show("giaovien null"); }
                    }
                    else { MessageBox.Show("sinhvien null"); }
                }
                else
                {
                    MessageBox.Show("DeTai null");
                }
            }
        }

        private void ProjectControl_Load(object sender, EventArgs e)
        {
            LoadDataCboCongTy(comboMaCTY,new QuanLyCongTy().getDanhSachCongTy());
            LoadDataCboLoaiDT(comboLoaiDT, new QuanLyLoaiDeTai().getDanhSachLoaiDT());
            LoadDataCboMaGV(cmboMaGV, new QuanLyGiangVien().getDanhSachGV());
            hienThiDanhSach(dgvDanhSachDeTai, quanly.getDanhSachDeTai());
            rdoNgoaiTruong_CheckedChanged(sender, e);
        }

        private void LoadDataCboCongTy(ComboBox cb, List<CongTy> ds)
        {
            cb.DisplayMember = "TenVietTat";
            cb.DataSource = ds;
        }

        private void LoadDataCboLoaiDT(ComboBox cb, List<LoaiDeTai> ds)
        {
            cb.Items.Clear();
            if (!string.IsNullOrEmpty(txtMaSV.Text))
            {
                SinhVien sinhVien = qlSV.Tim(txtMaSV.Text);
                if (sinhVien != null)
                {
                    foreach (LoaiDeTai ldt in ds)
                    {
                        if (ldt.Khoa == sinhVien.Lop2)
                            cb.Items.Add(ldt.TenLoai);
                    }
                }
            }
        }

        private void LoadDataCboMaGV(ComboBox cb, List<GiangVien> ds)
        {
            cb.Items.Clear();
            SinhVien sinhVien = qlSV.Tim(txtMaSV.Text);
            if (sinhVien != null)
            {

                foreach (GiangVien gv in ds)
                {
                    if (gv.Khoa == sinhVien.Lop2)
                        cb.Items.Add(gv.MaGiangVien);
                }
            }
        }

        private void btnaAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            SinhVien timSV = this.qlSV.Tim(txtMaSV.Text);
            GiangVien timGV = this.qLGV.Tim(cmboMaGV.Text);

            if (timSV == null) 
            { 
                MessageBox.Show("Không tìm thấy sinh viên dựa trên mã");
                return; 
            }
            if (rdoTaiTruong.Checked == true)
            {
                if (timGV == null) { MessageBox.Show("Mã giáo viên đang trống"); return; }
            }
            else
            {
                timGV = new GiangVien("null", "null", "null", DateTime.MinValue, "null", "null@gmail.com", "1234567890", "null");
            }

            if(quanly.TimDTtheoMaSV(txtMaSV.Text) != null)
            {
                MessageBox.Show("Sinh viên đã có đề tài, không thể thêm mới"); return;
            }
            
            try
            {
                DeTai dt = new DeTai(txtMa.Text, txtTen.Text,timSV, dateNgayBD.Value, dateNgayKT.Value, comboLoaiDT.Text, comboMaCTY.Text,timGV);
                if (quanly.Them(dt))
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
            if (quanly.TimKQtheoMaDT(txtMa.Text) != null)
            {
                MessageBox.Show("Không thể sửa vì đề tài đã có kết quả"); return;
            }

            SinhVien timSV = this.qlSV.Tim(txtMaSV.Text);
            GiangVien timGV = this.qLGV.Tim(cmboMaGV.Text);
            if (timSV == null) { 
                MessageBox.Show("Mã sinh viên không có trong dữ liệu"); return; 
            }

            if (rdoTaiTruong.Checked == true)
            {
                if (timGV == null) { MessageBox.Show("Mã Giáo viên đang trống"); return; }
            }
            else
            {
                timGV = new GiangVien("null", "null", "null", DateTime.MinValue, "null", "null@gmail.com", "1234567890", "null");

            }
            try
            {
                DeTai nsx = new DeTai(txtMa.Text, txtTen.Text, timSV,dateNgayBD.Value, dateNgayKT.Value, comboLoaiDT.Text, comboMaCTY.Text,timGV);
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
            if (quanly.TimKQtheoMaDT(txtMa.Text) != null)
            {
                MessageBox.Show("Không thể xóa vì đề tài đã có kết quả"); return;
            }

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
                if (dgvDanhSachDeTai.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    DeTai dt = quanly.Tim(dgvDanhSachDeTai.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtMa.Text = dt.MaDT;
                    txtTen.Text = dt.TenDT;
                    dateNgayBD.Value = dt.NgayBatDau;
                    dateNgayKT.Value = dt.NgayKetThuc;
                    comboMaCTY.Text = dt.MaCTy;       
                    txtMaSV.Text = dt.SinhVien.MaSinhVien;
                    if (dt.GiaoVien.MaGiangVien != "null")
                    {
                        rdoTaiTruong.Checked = true;
                        cmboMaGV.Text = dt.GiaoVien.MaGiangVien;
                    }
                    else { rdoNgoaiTruong.Checked = true; }
                    comboLoaiDT.Text = dt.LoaiDT;
                }

            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimkiem.Text;
            List<DeTai> ketQua = quanly.TimKiem(tuKhoa);
            hienThiDanhSach(dgvDanhSachDeTai, ketQua);
        }

        private void rdoTaiTruong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTaiTruong.Checked==true)
            {
                this.comboMaCTY.DataSource = null;
                this.comboMaCTY.Items.Add("STU");
                this.comboMaCTY.SelectedIndex = 0;
                this.label8.Show();
                this.cmboMaGV.Show();
            }
            
        }

        private void rdoNgoaiTruong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNgoaiTruong.Checked == true)
            {
                this.comboMaCTY.DataSource = null;
                LoadDataCboCongTy(comboMaCTY, new QuanLyCongTy().getDanhSachCongTy());
                this.label8.Hide();
                this.cmboMaGV.Hide();
            }
        }

        

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            LoadDataCboLoaiDT(comboLoaiDT, new QuanLyLoaiDeTai().getDanhSachLoaiDT());
            LoadDataCboMaGV(cmboMaGV, new QuanLyGiangVien().getDanhSachGV());
        }

       
        
    }
}
