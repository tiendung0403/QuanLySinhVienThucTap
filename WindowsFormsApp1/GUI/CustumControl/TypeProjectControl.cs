using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class TypeProjectControl : UserControl
    {
        private QuanLyLoaiDeTai quanly; 

        public TypeProjectControl()
        {            
            quanly = new QuanLyLoaiDeTai();
            InitializeComponent();
        }

        private void TypeProjectControl_Load(object sender, EventArgs e)
        {
            hienThiDanhSach(dgvDanhSachLDT, quanly.getDanhSachLoaiDT());
        }
        private void hienThiDanhSach(DataGridView dgv, List<LoaiDeTai> ds)
        {
            dgv.DataSource = ds.ToList();
            dgv.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            try
            {
                LoaiDeTai nsx = new LoaiDeTai(txtMa.Text, txtHoten.Text);
                if (quanly.Them(nsx))
                {
                    hienThiDanhSach(dgvDanhSachLDT, quanly.getDanhSachLoaiDT());
                }
                else
                    MessageBox.Show("Loại đề tài đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDanhSachLDT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                LoaiDeTai ldt = quanly.Tim(dgvDanhSachLDT.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtMa.Text = ldt.MaLoai;
                txtHoten.Text = ldt.TenLoai;
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = false;
            try
            {
                LoaiDeTai nsx = new LoaiDeTai(txtMa.Text, txtHoten.Text);
                if (quanly.Sua(nsx))
                    hienThiDanhSach(dgvDanhSachLDT, quanly.getDanhSachLoaiDT());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message+", vui lòng nhập đầy đủ thông tin hoặc click chọn vào hàng cần sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            txtMa.Clear();
            txtHoten.Clear();
            hienThiDanhSach(dgvDanhSachLDT, quanly.getDanhSachLoaiDT());
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text;
            List<LoaiDeTai> ketQua = quanly.TimKiem(tuKhoa);
            hienThiDanhSach(dgvDanhSachLDT, ketQua);
        }
    }
}
