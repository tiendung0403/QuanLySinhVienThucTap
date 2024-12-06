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

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class TypeProjectControl : UserControl
    {
        public event EventHandler ExitButtonClicked;

        private QuanLyLoaiDeTai quanly;
        public TypeProjectControl()
        {
            InitializeComponent();
            quanly = new QuanLyLoaiDeTai();
        }

        private void TypeProjectControl_Load(object sender, EventArgs e)
        {
            hienThiDanhSach(dgvDanhSachLDT, quanly.DanhSachLDT);
        }
        private void hienThiDanhSach(DataGridView dgv, List<LoaiDeTai> ds)
        {
            dgv.DataSource = ds.ToList();
        }
        private bool kiemtraRong()
        {
            if (txtMa.Text == "" || txtHoten.Text == "") return true;
            else return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            if (kiemtraRong())
            {
                MessageBox.Show("Không được để trống ô nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LoaiDeTai nsx = new LoaiDeTai(txtMa.Text, txtHoten.Text);
                if (quanly.Them(nsx)) {
                    hienThiDanhSach(dgvDanhSachLDT, quanly.DanhSachLDT);
                }
                else 
                {
                    MessageBox.Show("Loại đề tài đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                bool result = TruyCapDuLieu.ghiFile(filePath);
                if (result)
                {
                    MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu tệp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (kiemtraRong())
            {
                MessageBox.Show("Vui lòng chọn hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtMa.Enabled = false;

                LoaiDeTai nsx = new LoaiDeTai(txtMa.Text, txtHoten.Text);
                if (quanly.Sua(nsx))
                {
                    hienThiDanhSach(dgvDanhSachLDT, quanly.DanhSachLDT);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy loại đề tài cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            txtMa.Clear();
            txtHoten.Clear();

            hienThiDanhSach(dgvDanhSachLDT, quanly.getDanhSachLoaiDT());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, e);

        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                bool result = TruyCapDuLieu.docFile(filePath);
                if (result)
                {
                    MessageBox.Show("Dữ liệu đã được tải thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    quanly = new QuanLyLoaiDeTai();
                    hienThiDanhSach(dgvDanhSachLDT, quanly.DanhSachLDT);
                }
                else
                {
                    MessageBox.Show("Không thể đọc tệp dữ liệu hoặc tệp không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
