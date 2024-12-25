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

namespace WindowsFormsApp1.GUI.MainForm
{
    public partial class frmDetailStudent : Form
    {
        private SinhVien sv;
        public frmDetailStudent(string maSV)
        {
            InitializeComponent();
            this.sv = new QuanLySinhVien().Tim(maSV);
        }

        private void frmDetailStudent_Load(object sender, EventArgs e)
        {
            if (sv != null)
            {
                txtMaSV.Text = sv.MaSinhVien;
                txtHotenSV.Text = sv.HoTen;
                dateNgaySinhSV.Text = sv.NgaySinh.ToString();
                txtGioiTinhSV.Text = sv.GioiTinh;
                txtSDTSV.Text = sv.SoDienThoai;
                txtEmailSV.Text = sv.Email;
                txtKhoaSV.Text = sv.Lop2;
                txtLopHocSV.Text = sv.Lop;

            }

            DeTai findDT = new QuanLyDeTai().TimDTtheoMaSV(sv.MaSinhVien);
            if (findDT != null)
            {
                txtMaDT.Text = findDT.MaDT;
                txtTenDT.Text = findDT.TenDT;
                txtLoaiDT.Text = findDT.LoaiDT;
                txtDonViTT.Text = findDT.MaCTy;
                if (findDT.GiaoVien.MaGiangVien != "null")
                {
                    txtMaGV.Text = findDT.GiaoVien.MaGiangVien;
                }
                else { txtMaGV.Hide(); lbMaGV.Hide(); }
                dateNgayBD.Text = findDT.NgayBatDau.ToString();
                dateNgayKT.Text = findDT.NgayKetThuc.ToString();
            }

            List<DanhGiaDeTai> listDG = new QuanLyDanhGia().LocVaSapXepTheoMaSV(sv.MaSinhVien);
            if (listDG != null)
            {
                Display(dgvDanhGiaTuan, listDG);
            }
            KetQua findKQ = new QuanLyKetQua().TimKQtheoMaSV(sv.MaSinhVien);
            if (findKQ != null)
            {
                txtMaKQ.Text = findKQ.MaKQ;
                txtNhanXet.Text = findKQ.NhanXet;
                txtTongDiem.Text = findKQ.TongDiem.ToString();
                if (findKQ.KetQuaCuoiCung == KieuKetQua.Dat)
                {
                    lbKetQua.Text = "Đạt";
                    lbKetQua.ForeColor = Color.Green;
                }

            }
            else { lbKetQua.Hide(); }   
        }

        private void Display(DataGridView dgv, List<DanhGiaDeTai> list)
        {
            dgv.Rows.Clear();
            foreach (DanhGiaDeTai dg in list)
            {
                dgv.Rows.Add(dg.MaDG, dg.Tuan);
            }
        }

        private void dgvDanhGiaTuan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhGiaTuan.Rows[e.RowIndex].Cells[0].Value != null)
            {
                string maDG = dgvDanhGiaTuan.Rows[e.RowIndex].Cells[0].Value.ToString();
                DanhGiaDeTai dg = new QuanLyDanhGia().Tim(maDG);
                if (dg != null)
                {
                    txtMaDG.Text = dg.MaDG;
                    txtTuan.Text = dg.Tuan.ToString();
                    txtLinkBaoCao.Text = dg.LinkBaoCao;
                    txtNhanXetTuan.Text = dg.NhanXet;
                    txtDiemTuan.Text = dg.Diem.ToString();
                }
            }
        }
    }
}
