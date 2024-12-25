using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;
namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class DepartmentControl : UserControl
    {
        private QuanLyKhoa quanLyKhoa;
        public DepartmentControl()
        {
            InitializeComponent();
            quanLyKhoa = new QuanLyKhoa();
            DisplayComboBox(cmboKhoa, quanLyKhoa.getDanhSachKhoa());
        }

        private void Display(DataGridView dgv, List<Khoa> ds)
        {
            dgv.Rows.Clear();
            foreach (Khoa kh in ds)
            {
                dgv.Rows.Add(kh.maDsKhoa,kh.MaKhoa, kh.TenKhoa, kh.LopHoc,kh.NamHoc,kh.SoLuongSV);
            }
        }

        bool KiemTraDinhDangLop(string lop)
        {
            // Định dạng lớp
            string pattern = @"^D\d{2}_[A-Z]{2}\d{2}$";
            return Regex.IsMatch(lop, pattern); // nếu sai trả về false
        }


        private void DisplayComboBox(ComboBox cmbo, List<Khoa> ds)
        {
            var distinctKhoa = ds.Select(k => k.MaKhoa).Distinct().ToList();
            cmboKhoa.DataSource = distinctKhoa;
            cmboKhoa.DisplayMember = "MaKhoa"; // Chỉ hiển thị tên khoa

            var distinctLop = ds.Select(k => k.LopHoc).Distinct().ToList();
            cmboLop.DataSource = distinctLop;
            cmboLop.DisplayMember = "LopHoc"; // Chỉ hiển thị tên lớp

            var distinctNam = ds.Select(k => k.NamHoc).Distinct().ToList();
            cmboNam.DataSource = distinctNam;
            cmboNam.DisplayMember = "NamHoc"; // Chỉ hiển thị năm học
        }
        private void trangthaitextbox(bool a)
        {
            txtMaDsKhoa.Enabled = a;
            txtTenLop.Enabled = a;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            trangthaitextbox(true);
            string mads = txtMaDsKhoa.Text;
            string maKhoa=txtMaKhoa.Text;
            string tenKhoa=txtTenKhoa.Text;
            string lopHoc = txtTenLop.Text;
            if (KiemTraDinhDangLop(lopHoc) == false)
            {
                MessageBox.Show("Lớp học không đúng định dạng _ định dạng đúng vd: D22_TH15");
                return;
            }
            if (quanLyKhoa.KiemTraKhoa(maKhoa,lopHoc) != null)
            {
                MessageBox.Show("Lớp học đã tồn tại");
                return;
            }

            int namHoc = 0;
            if(int.TryParse(txtNamHoc.Text, out namHoc) == false)
            {
                MessageBox.Show("Năm học phải là số");
                return;
            }
            try
            {
                if (quanLyKhoa.Them(new Khoa(mads, maKhoa, tenKhoa, lopHoc, namHoc)))
                {
                    MessageBox.Show("Thêm thành công");
                    Display(dgvDsKhoa, quanLyKhoa.getDanhSachKhoa());
                    DisplayComboBox(cmboKhoa, quanLyKhoa.getDanhSachKhoa());
                }
                else { MessageBox.Show("Thêm thất bại, mã danh sách đã tồn tại vui lòng chọn mã khác"); }

            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            trangthaitextbox(false);
            string maDs = txtMaDsKhoa.Text;
            string maKhoa = txtMaKhoa.Text;
            string tenKhoa = txtTenKhoa.Text;
            string lopHoc = txtTenLop.Text;
            
            int namHoc = 0;
            if (KiemTraDinhDangLop(lopHoc) == false)
            {
                MessageBox.Show("Lớp học không đúng định dạng _ định dạng đúng vd: D22_TH15");
                return;
            }
            if (int.TryParse(txtNamHoc.Text, out namHoc) == false)
            {
                MessageBox.Show("Năm học phải là số");
                return;
            }
            //if (quanLyKhoa.KiemTraKhoa(maKhoa, lopHoc) != null)
            //{
            //    MessageBox.Show("Lớp học đã tồn tại");
            //    return;
            //}
            Khoa findKhoa = quanLyKhoa.findKhoa(maDs);
            if (findKhoa != null && findKhoa.SoLuongSV > 0)
            {
                MessageBox.Show("Không thể sửa vì khoa và lớp này còn sinh viên");
                return;
            }
            try
            {
                if (quanLyKhoa.Sua(new Khoa(maDs, maKhoa, tenKhoa, lopHoc, namHoc)))
                {
                    MessageBox.Show("Sửa thành công");
                    Display(dgvDsKhoa, quanLyKhoa.getDanhSachKhoa());
                }
                else { MessageBox.Show("Sửa thất bại không tìm thấy mã ds để sửa"); }

            }catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            trangthaitextbox(true);
            string maKhoa = txtMaDsKhoa.Text;
            Khoa findKhoa = this.quanLyKhoa.findKhoa(maKhoa);
            if (findKhoa.SoLuongSV > 0)
            {
                MessageBox.Show("Không thể xóa khoa này vì còn sinh viên");
                return;
            }
            
            if (quanLyKhoa.Xoa(maKhoa))
            {
                MessageBox.Show("Xóa thành công");
                Display(dgvDsKhoa, quanLyKhoa.getDanhSachKhoa());
            }     
            else { MessageBox.Show("Xóa thất bại"); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            trangthaitextbox(true);
            Display(dgvDsKhoa, quanLyKhoa.getDanhSachKhoa());
        }

        private void dgvDsKhoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvDsKhoa.Rows[e.RowIndex].Cells[0].Value != null)
            {
                string makhoa = dgvDsKhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                Khoa kh = quanLyKhoa.findKhoa(makhoa);
                if (kh != null)
                {

                    txtMaDsKhoa.Text = kh.maDsKhoa;
                    txtMaKhoa.Text = kh.MaKhoa;
                    txtTenKhoa.Text = kh.TenKhoa;
                    txtTenLop.Text = kh.LopHoc;
                    txtNamHoc.Text = kh.NamHoc.ToString();
                }
                else
                {
                    //  MessageBox.Show("Không tìm thấy"+kh);
                }
            }
           
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string findMaDs = txtTimkiem.Text;
            List<Khoa> result = quanLyKhoa.AllSearch(findMaDs);
            if (result != null)
            {             
                Display(dgvDsKhoa, result);
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void btnSearch_Lop_Click(object sender, EventArgs e)
        {
            List<Khoa> result = quanLyKhoa.TimDsTheoLop(cmboLop.Text);
            if (result != null)
            {
                Display(dgvDsKhoa, result);
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void btnSearch_Khoa_Click(object sender, EventArgs e)
        {
            List<Khoa> result = quanLyKhoa.TimDsTheoKhoa(cmboKhoa.Text);
            if (result != null)
            {
                Display(dgvDsKhoa, result);
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void btnSearch_Nam_Click(object sender, EventArgs e)
        {
            List<Khoa> result = quanLyKhoa.TimDsTheoNam(cmboNam.Text);
            if (result != null)
            {
                Display(dgvDsKhoa, result);
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void DepartmentControl_Load(object sender, EventArgs e)
        {
            DisplayComboBox(cmboKhoa, quanLyKhoa.getDanhSachKhoa());
            Display(dgvDsKhoa, quanLyKhoa.getDanhSachKhoa());   
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string findMaDs = txtTimkiem.Text;
            List<Khoa> result = quanLyKhoa.AllSearch(findMaDs);
            if (result != null)
            {
                Display(dgvDsKhoa, result);
            }
        }
    }
}
