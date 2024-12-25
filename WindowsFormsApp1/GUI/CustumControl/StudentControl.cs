using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.GUI.MainForm;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class StudentControl : UserControl
    {
        private QuanLySinhVien quanly;

        public StudentControl()
        {
            quanly = new QuanLySinhVien();
            InitializeComponent();
        }

        private void hienThiDanhSach(DataGridView dgv, List<SinhVien> ds)
        {
            QuanLyKetQua qlkq = new QuanLyKetQua();
            KetQua a;
            dgv.Rows.Clear();
            foreach(SinhVien sv in ds)
            {
                if (qlkq.TimKQtheoMaSV(sv.MaSinhVien) == null)
                {
                    dgv.Rows.Add(sv.MaSinhVien, sv.HoTen, sv.GioiTinh, sv.NgaySinh, sv.Email, sv.SoDienThoai, sv.Lop2, sv.Lop, sv.TrangThaiSV,"NULL");
                }
                else
                {
                    a = qlkq.TimKQtheoMaSV(sv.MaSinhVien);
                    
                    dgv.Rows.Add(sv.MaSinhVien, sv.HoTen, sv.GioiTinh, sv.NgaySinh, sv.Email, sv.SoDienThoai, sv.Lop2, sv.Lop, sv.TrangThaiSV, a.KetQuaCuoiCung);


                }
            }
        }

        private void LoadDataCboKhoa(ComboBox cb,List<Khoa> ds)
        {
            var distinctKhoa = ds.Select(k => k.MaKhoa).Distinct().ToList();
            comboChonKhoa.DataSource = distinctKhoa;
            comboChonKhoa.DisplayMember = "MaKhoa"; 
            

        }
        private void LoadDataCboLoc(ComboBox cb, List<SinhVien> ds)
        {
            var distinctKhoa = ds.Select(k => k.Lop2).Distinct().ToList();
            cmboKhoa.DataSource = distinctKhoa;
            cmboKhoa.DisplayMember = "Lop2"; 
            var distinctLop = ds.Select(k => k.Lop).Distinct().ToList();
            cmboLop.DataSource = distinctLop;
            cmboLop.DisplayMember = "Lop"; 
        }


        private void StudentControl_Load(object sender, EventArgs e)
        {
            LoadDataCboKhoa(comboChonKhoa, new QuanLyKhoa().getDanhSachKhoa());
            LoadDataCboLoc(cmboKhoa, quanly.getDanhSachSinhVien());

            hienThiDanhSach(dgvDSSinhvien, quanly.getDanhSachSinhVien());
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            if(string.IsNullOrEmpty(cmboChonLop.Text) )
            {
                MessageBox.Show("Vui lòng chọn lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                SinhVien sv = new SinhVien(txtMa.Text, txtHoten.Text, txtGioitinh.Text, dateNgaySinh.Value, txtEmail.Text, txtSDT.Text,0, cmboChonLop.Text, comboChonKhoa.Text);
                if (quanly.Them(sv))
                {
                    MessageBox.Show("Thêm thành công");
                    hienThiDanhSach(dgvDSSinhvien, quanly.getDanhSachSinhVien());
                    LoadDataCboLoc(cmboKhoa, quanly.getDanhSachSinhVien());
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
                SinhVien sv = new SinhVien(txtMa.Text, txtHoten.Text, txtGioitinh.Text, dateNgaySinh.Value, txtEmail.Text, txtSDT.Text, 0,cmboChonLop.Text,comboChonKhoa.Text);
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
            
            string ma = txtMa.Text;
            var sv = quanly.Tim(txtMa.Text);
            if(sv.TrangThaiSV == DTO.TrangThaiSV.DangThucTap || sv.TrangThaiSV == DTO.TrangThaiSV.KetThuc)
            {
                MessageBox.Show($"Sinh viên Đang {sv.TrangThaiSV} không xóa được ");
            }
            else if (quanly.Xoa(ma))
            {
                hienThiDanhSach(dgvDSSinhvien, quanly.getDanhSachSinhVien());
            }
            else
            {
                MessageBox.Show(" vui click chọn vào hàng cần xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Clear();
            txtHoten.Clear();
            txtEmail.Clear();
            txtSDT.Clear(); ;
           // txtDTB.Clear();
            
          //  LoadDataCboCongTy(comboMaCty, new QuanLyCongTy().getDanhSachCongTy());
           // LoadDataCboGiangVien(comboMaGV, new QuanLyGiangVien().getDanhSachGV());
            hienThiDanhSach(dgvDSSinhvien, quanly.getDanhSachSinhVien());
        }
        string getMaSV=null;
        private void dgvDSSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSSinhvien.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    getMaSV = dgvDSSinhvien.Rows[e.RowIndex].Cells[0].Value.ToString();
                    SinhVien sv = quanly.Tim(dgvDSSinhvien.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtMa.Text = sv.MaSinhVien;
                    txtHoten.Text = sv.HoTen;
                    txtGioitinh.Text = sv.GioiTinh;
                    dateNgaySinh.Value = sv.NgaySinh;
                    txtEmail.Text = sv.Email;
                    txtSDT.Text = sv.SoDienThoai;
                   
                
                    comboChonKhoa.Text = sv.Lop2;     
                    cmboChonLop.SelectedItem = sv.Lop;
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimkiem.Text;
            List<SinhVien> ketQua = quanly.TimKiem(tuKhoa);
            hienThiDanhSach(dgvDSSinhvien, ketQua);
        }


        private void btnSearh_Lop_Click(object sender, EventArgs e)
        {
            string lop = cmboLop.Text;
            List<SinhVien> ds = quanly.TimDsTheoLop(lop);
            if (ds != null && ds.Count > 0)
            {
                hienThiDanhSach(dgvDSSinhvien, ds);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên nào trong lớp này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDSSinhvien.Rows.Clear();
            }
        }

        private void btnSearch_Khoa_Click(object sender, EventArgs e)
        {
            string khoa=cmboKhoa.Text;
            List<SinhVien> ds = quanly.TimDsTheoKhoa(khoa);
            if (ds != null)
            {
                hienThiDanhSach(dgvDSSinhvien, ds);
                
              
            }
            else { MessageBox.Show("Không tìm thấy"); }

        }

        private void dgvDSSinhvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDSSinhvien.Columns[e.ColumnIndex].Name == "TrangThaiSV")
            {
                if (e.Value != null)
                {
                    TrangThaiSV trangThai = (TrangThaiSV)e.Value;
                    if (trangThai==DTO.TrangThaiSV.ChuaThucTap)
                    {
                        e.Value = "Chưa thực tập";
                    }
                    else if(trangThai== DTO.TrangThaiSV.DangThucTap)
                    {
                        e.Value = "Đang thực tập";
                    }
                    else
                    {
                        e.Value = "Kết thúc thực tập";
                    }
                }
            }
        }

        private void btnDetailStudent_Click(object sender, EventArgs e)
        {
            if (getMaSV != null)
            {
                frmDetailStudent frm = new frmDetailStudent(getMaSV);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xem chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
        }

        private void cmboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmboLocTrangThai.SelectedIndex == 0)
            {
                hienThiDanhSach(dgvDSSinhvien, quanly.TimDStheoTT(0));
            }else if(cmboLocTrangThai.SelectedIndex == 1)
            {
                hienThiDanhSach(dgvDSSinhvien, quanly.TimDStheoTT(1));
            }
            else
            {
                hienThiDanhSach(dgvDSSinhvien, quanly.TimDStheoTT(2));
            }
        }

        private void comboChonKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmboChonLop.Items.Clear();
            foreach (Khoa kh in new QuanLyKhoa().getDanhSachKhoa())
            {
                if (kh.MaKhoa == comboChonKhoa.Text)
                {
                    cmboChonLop.Items.Add(kh.LopHoc);
                }
            }
        }

    }
}
