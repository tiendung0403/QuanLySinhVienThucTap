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
    public partial class frmDetailCompany : Form
    {
        private CongTy congty;
        public frmDetailCompany(string tenVT)
        {
            InitializeComponent();
            this.congty = new QuanLyCongTy().TimTenVT(tenVT);
        }
        
        private void Display(DataGridView dgv, List<DeTai> ds)
        {
            dgv.Rows.Clear();
            foreach (DeTai dt in ds)
            {
                if (dt.MaCTy == congty.TenVietTat)
                {
                    dgv.Rows.Add(dt.SinhVien.MaSinhVien, dt.SinhVien.HoTen, dt.SinhVien.Email, dt.SinhVien.SoDienThoai, dt.SinhVien.Lop2, dt.SinhVien.Lop);
                }
            }
        }

        private void frmDetailCompany_Load(object sender, EventArgs e)
        {
            if (congty != null)
            {
                txtMa.Text = congty.MaCongTy;
                txtTen.Text = congty.TenCongTy;
                txtDiaChi.Text = congty.DiaChi;
                txtTenVT.Text = congty.TenVietTat;
                txtEmail.Text = congty.Email;
                txtSDT.Text = congty.SoDienThoai;
                Display(dgvDSSinhvien, new QuanLyDeTai().getDanhSachDeTai());
            }
            else { MessageBox.Show("Không tìm thấy công ty"); }
        }
    }
}
