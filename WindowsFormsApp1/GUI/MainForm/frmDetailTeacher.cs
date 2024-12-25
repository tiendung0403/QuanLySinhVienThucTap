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

namespace WindowsFormsApp1.GUI.MainForm
{
    public partial class frmDetailTeacher : Form
    {
        private GiangVien gv;

        public frmDetailTeacher(string maGV)
        {
            InitializeComponent();
            this.gv =  new QuanLyGiangVien().Tim(maGV);
        }

        private void frmDetailTeacher_Load(object sender, EventArgs e)
        {
            if (gv != null)
            {
                txtMa.Text= gv.MaGiangVien;
                txtHoten.Text = gv.HoTen;
                txtGioiTinh.Text = gv.GioiTinh;
                dateNgaySinh.Text = gv.NgaySinh.ToString();
                txtChucVu.Text = gv.ChucVu;
                txtEmail.Text = gv.Email;
                txtSDT.Text = gv.SoDienThoai;
                txtKhoa.Text = gv.Khoa;
                Display(dgvDSSinhvien, new QuanLyDeTai().getDanhSachDeTai());
            }
        }

        private void Display(DataGridView dgv, List<DeTai> ds)
        {
            dgv.Rows.Clear();

            foreach (DeTai dt in ds)
            {
                if (dt.GiaoVien.MaGiangVien == gv.MaGiangVien && dt.SinhVien.TrangThaiSV != TrangThaiSV.KetThuc )
                {
                    dgv.Rows.Add(dt.SinhVien.MaSinhVien, dt.SinhVien.HoTen, dt.SinhVien.Email, dt.SinhVien.SoDienThoai, dt.SinhVien.Lop2,dt.SinhVien.Lop);
                }
            }
        }
    }
}
