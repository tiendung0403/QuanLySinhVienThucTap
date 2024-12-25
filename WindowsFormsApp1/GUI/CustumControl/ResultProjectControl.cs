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
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.GUI.MainForm;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class ResultProjectControl : UserControl
    {
        private QuanLyDanhGia quanLyDG;
        public ResultProjectControl()
        {
            InitializeComponent();
           
            quanLyDG = new QuanLyDanhGia();
            //if (form_QuanLySinhVien.roleMain == Role.User)
            {
                //groupBoxInput.Hide();
            }
            //else
            {
                groupBoxInput.Show();
            }
            Display(dgvDanhSachDeTai, quanLyDG.getDanhSachDanhGia());
        }

        private void btnaAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            int tuan;

            if (!int.TryParse(txtTuan.Text, out tuan)) {
                MessageBox.Show("Tuần phải là số");
                return; 
            }
            else if (tuan < 1 || tuan > 15)
            {
                MessageBox.Show("Tuần phải từ 1 đến 10");
                return;
            }
            double diem;
            if (!double.TryParse(txtDiem.Text, out diem))
            {
                MessageBox.Show("điểm không đúng định dạng");
                return;
            }
            else if(diem <0 || diem > 10)
            {
                MessageBox.Show("Diểm phải từ 1 đến 10");
                return;
            }
            if (quanLyDG.KiemTraDG(tuan, txtMaDT.Text))
            {
                MessageBox.Show($"Tuần {tuan} của Mã đề tài {txtMaDT.Text} đã tồn tại");
                return;
            }
            try
            {
                DeTai timDT = new QuanLyDeTai().Tim(txtMaDT.Text);
                if (timDT == null)
                {
                    MessageBox.Show("Mã đề tài không tồn tại");
                    return;
                }
                else
                {
                    foreach (KetQua kq in new QuanLyKetQua().getDanhSachKetQua())
                    {
                        if (kq.DeTai.MaDT == timDT.MaDT)
                        {
                            MessageBox.Show("Đề tài đã có kết quả không thể tiếp tục đánh giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                if (quanLyDG.Them(new DTO.DanhGiaDeTai(txtMa.Text, tuan, timDT, timDT.SinhVien, txtNhanXet.Text, diem, txtLinkBaoCao.Text)))
                {
                    MessageBox.Show("Thêm thành công");
                    Display(dgvDanhSachDeTai, quanLyDG.getDanhSachDanhGia());
                }
                else { MessageBox.Show("Mã đánh giá bị trùng"); }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Thông Báo");
            }
        }

        private void Display(DataGridView dgv, List<DanhGiaDeTai> ds)
        {
            dgv.Rows.Clear();
            foreach (DanhGiaDeTai dg in ds)
            {
                dgv.Rows.Add(dg.MaDG, dg.Tuan, dg.DeTai.MaDT, dg.DeTai.TenDT,  dg.SinhVien.MaSinhVien, dg.Diem);
            }
        }

        private void dgvDanhSachDeTai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDanhSachDeTai.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    string maDG = dgvDanhSachDeTai.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DanhGiaDeTai dg = quanLyDG.Tim(maDG);
                    if (dg != null)
                    {
                        txtChiTietMaDG.Text = dg.MaDG;
                        txtChiTietTuan.Text = dg.Tuan.ToString();
                        txtChiTietMaDT.Text = dg.DeTai.MaDT;
                        txtChiTietBaoCao.Text = dg.LinkBaoCao;
                        txtChiTietMaSV.Text = dg.SinhVien.MaSinhVien;
                        txtChiTietHoTenSV.Text = dg.SinhVien.HoTen;
                        txtChiTietNhanXet.Text = dg.NhanXet;
                        txtChiTietDiem.Text = dg.Diem.ToString();
                        txtChiTietTenDT.Text = dg.DeTai.TenDT;
                        txtMa.Text = dg.MaDG;
                        txtTuan.Text = dg.Tuan.ToString();
                        txtMaDT.Text = dg.DeTai.MaDT;
                        txtNhanXet.Text = dg.NhanXet;
                        txtDiem.Text = dg.Diem.ToString();
                        txtLinkBaoCao.Text = dg.LinkBaoCao;
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            //string maDG = txtMa.Text;

            //DanhGiaDeTai dg = quanLyDG.Tim(maDG);
            //if (quanLyDG.CheckKQsinhVien(dg.SinhVien.MaSinhVien))
            //{
            //    MessageBox.Show("Sinh viên đã có kết quả không thể sửa");
            //    return;
            //}

            //int tuan;

            //if (!int.TryParse(txtTuan.Text, out tuan))
            //{
            //    MessageBox.Show("Tuần phải là số");
            //    return;
            //}
            //else if (tuan < 1 || tuan > 15)
            //{
            //    MessageBox.Show("Tuần phải từ 1 đến 10");
            //    return;
            //}
            ////if (quanLyDG.TimTuan(tuan) != null)
            ////{
            ////    MessageBox.Show("Tuần đã tồn tại");
            ////    return;
            ////}

            //string maDT = txtMaDT.Text;

            //DeTai timDT = new QuanLyDeTai().Tim(maDT);

            //if (timDT == null)
            //{
            //    MessageBox.Show("Mã đề tài không tồn tại");
            //    return;
            //}

            //string nhanXet = txtNhanXet.Text;
            //double diem = Convert.ToDouble(txtDiem.Text);
            //string link = txtLinkBaoCao.Text;
            //if (quanLyDG.Sua(new DTO.DanhGiaDeTai(maDG, tuan, timDT, timDT.SinhVien, nhanXet, diem, link)))
            //{
            //    MessageBox.Show("Sửa thành công");
            //    Display(dgvDanhSachDeTai, quanLyDG.getDanhSachDanhGia());
            //}
            //else
            //{
            //    MessageBox.Show("Sửa thất bại");
            //}
            //
            DeTai timDT = new QuanLyDeTai().Tim(txtMaDT.Text);
            if (timDT == null)
            {
                MessageBox.Show("Mã đề tài không tồn tại");
                return;
            }
            else
            {
                foreach (KetQua kq in new QuanLyKetQua().getDanhSachKetQua())
                {
                    if (kq.DeTai.MaDT == timDT.MaDT)
                    {
                        MessageBox.Show("Đề tài đã có kết quả không thể sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            int tuan;
            if (!int.TryParse(txtTuan.Text, out tuan))
            {
                MessageBox.Show("Tuần phải là số");
                return;
            }
            else if (tuan < 1 || tuan > 15)
            {
                MessageBox.Show("Tuần phải từ 1 đến 10");
                return;
            }
            double diem;
            if (!double.TryParse(txtDiem.Text, out diem))
            {
                MessageBox.Show("điểm không đúng định dạng");
                return;
            }
            else if (diem < 0 || diem > 10)
            {
                MessageBox.Show("Diểm phải từ 1 đến 10");
                return;
            }
            try
            {
                if (quanLyDG.Sua(new DTO.DanhGiaDeTai(txtMa.Text, tuan, timDT, timDT.SinhVien, txtNhanXet.Text, diem, txtLinkBaoCao.Text)))
                {
                    MessageBox.Show("Sửa thành công");
                    Display(dgvDanhSachDeTai, quanLyDG.getDanhSachDanhGia());
                }
                else { MessageBox.Show("Mã đánh giá không đúng"); }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông Báo");
            }
        }

    


        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            string maDT=txtMa.Text;
            DanhGiaDeTai dg= quanLyDG.Tim(maDT);
            if(quanLyDG.CheckKQsinhVien(dg.SinhVien.MaSinhVien))
            {
                MessageBox.Show("Sinh viên đã có kết quả không thể xóa");
                return;
            }

            if (quanLyDG.Xoa(maDT))
            {
                MessageBox.Show("Xóa thành công");
                Display(dgvDanhSachDeTai, quanLyDG.getDanhSachDanhGia());
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (quanLyDG.TimDsTheoMaDT(txtTimkiem.Text) != null)
            {
                List<DanhGiaDeTai> ds = quanLyDG.LocVaSapXepTheoMaSV(txtTimkiem.Text);
                if (ds != null)
                {
                    Display(dgvDanhSachDeTai, ds);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy đối tượng với madt");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            Display(dgvDanhSachDeTai, quanLyDG.getDanhSachDanhGia());
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            Display(dgvDanhSachDeTai, quanLyDG.Timkiem(txtTimkiem.Text));
                
        }
    }
}
