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
        string filePath = "datasystem.bin";

        public TypeProjectControl()
        {
            InitializeComponent();
        }

        private void TypeProjectControl_Load(object sender, EventArgs e)
        {
            TruyCapDuLieu.docFile(filePath);
            quanly = new QuanLyLoaiDeTai();
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
                    TruyCapDuLieu.ghiFile(filePath);
                }
                else
                    MessageBox.Show("Loại đề tài đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            TruyCapDuLieu.khoitao();
            {
                //saveFileDialog.FileName;

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
                txtMa.Enabled = false;
            try
            {
                LoaiDeTai nsx = new LoaiDeTai(txtMa.Text, txtHoten.Text);
                if (quanly.Sua(nsx))
                    hienThiDanhSach(dgvDanhSachLDT, quanly.getDanhSachLoaiDT());
                TruyCapDuLieu.ghiFile(filePath);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message+", vui lòng nhập đầy đủ thông tin hoặc click chọn vào hàng cần sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;
            TruyCapDuLieu.docFile(filePath);


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMa.Enabled = true;

            txtMa.Clear();
            txtHoten.Clear();
            TruyCapDuLieu.ghiFile(filePath);
            hienThiDanhSach(dgvDanhSachLDT, quanly.getDanhSachLoaiDT());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitButtonClicked?.Invoke(this, e);
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            TruyCapDuLieu.khoitao();
            {
                //saveFileDialog.FileName;

                bool result = TruyCapDuLieu.docFile(filePath);
                if (result)
                {
                    MessageBox.Show("Dữ liệu đã được tải thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    quanly = new QuanLyLoaiDeTai();
                    hienThiDanhSach(dgvDanhSachLDT, quanly.getDanhSachLoaiDT());
                }
                else
                {
                    MessageBox.Show("Không thể đọc tệp dữ liệu hoặc tệp không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
