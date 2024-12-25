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
using WindowsFormsApp1.GUI.MainForm;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class ResultControl : UserControl
    {
        private QuanLyKetQua quanLyKetQua;
        public ResultControl()
        {
            InitializeComponent();
            quanLyKetQua = new QuanLyKetQua();
            Display(dgvDanhSachKetQua, quanLyKetQua.getDanhSachKetQua());
        }

        private void ResultControl_Load(object sender, EventArgs e)
        {
            //if(form_QuanLySinhVien.roleMain == Role.User)
            //{
            //    groupBoxInput.Hide();
            //    btnaAdd.Hide();
            //    btnDelete.Hide();
            //    btnFix.Hide();
            //}
            //else
            //{
                groupBoxInput.Show();
                btnaAdd.Show();
                btnDelete.Show();
                btnFix.Show();
           // }
        }
        private void Display(DataGridView dgv, List<KetQua> list)
        {
            dgv.Rows.Clear();
            foreach(KetQua kq in list)
            {
                dgv.Rows.Add(kq.MaKQ, kq.DeTai.MaDT,  kq.SinhVien.MaSinhVien, kq.TongDiem,kq.KetQuaCuoiCung);
            }
        }



        private void btnaAdd_Click(object sender, EventArgs e)
        {
            txtMaKQ.Enabled = true;
            string maKQ = txtMaKQ.Text;
            string maDT = txtMaDT.Text;
            DeTai timDT = new QuanLyDeTai().Tim(maDT);
            if (timDT == null)
            {
                MessageBox.Show("Mã đề tài không tồn tại");
                return;
            }
            if(quanLyKetQua.findDeTai(maDT) != null)
            {
                MessageBox.Show("Mã đề tài đã có kết quả đánh giá ");
                return;
            }

            string nhanXet = txtNhanXet.Text;
            double tongDiem; 
            if(!double.TryParse(txtTongDiem.Text, out tongDiem))
            {
                MessageBox.Show("Tổng điểm phải là số");
                return;
            }
            else if(tongDiem < 0 || tongDiem > 10)
            {
                MessageBox.Show("Điểm là chữ số từ 0 đến 10");
                return;

            }
            try
            {
                if (quanLyKetQua.Them(new KetQua(maKQ, timDT, timDT.SinhVien, timDT.GiaoVien, nhanXet, tongDiem)))
                {
                    MessageBox.Show("Thêm thành công");
                    Display(dgvDanhSachKetQua, quanLyKetQua.getDanhSachKetQua());
                }
                else MessageBox.Show("Mã Kết Quả bị trùng lặp", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"Thông báo");
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            txtMaKQ.Enabled = false;
            string maKQ = txtMaKQ.Text;
            string maDT = txtMaDT.Text;
            DeTai timDT = new QuanLyDeTai().Tim(maDT);
            if (timDT == null)
            {
                MessageBox.Show("Mã đề tài không tồn tại");
                return;
            }
            string nhanXet = txtNhanXet.Text;
            double tongDiem;
            if (!double.TryParse(txtTongDiem.Text, out tongDiem))
            {
                MessageBox.Show("Tổng điểm phải là số");
                return;
            }
            if (quanLyKetQua.SuadanhGia(new KetQua(maKQ, timDT, timDT.SinhVien, timDT.GiaoVien, nhanXet, tongDiem)))
            {
                MessageBox.Show("Sửa thành công");
                Display(dgvDanhSachKetQua, quanLyKetQua.getDanhSachKetQua());
            }
            else { MessageBox.Show("Sửa thất bại"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtMaKQ.Enabled = true;
            string maKQ = txtMaKQ.Text;
            if (quanLyKetQua.Xoa(maKQ))
            {
                MessageBox.Show("Xóa thành công");
                Display(dgvDanhSachKetQua, quanLyKetQua.getDanhSachKetQua());
            }
            else { MessageBox.Show("Xóa thất bại"); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKQ.Enabled = true;
            quanLyKetQua.getDanhSachKetQua();
            Display(dgvDanhSachKetQua, quanLyKetQua.getDanhSachKetQua());
        }
        string getCodeKQ = null;
        private void dgvDanhSachKetQua_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDanhSachKetQua.Rows[e.RowIndex].Cells[0].Value!=null)
                {
                    string maKQ = dgvDanhSachKetQua.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.getCodeKQ = maKQ;
                    KetQua kq = quanLyKetQua.findKQ(maKQ);
                    if (kq != null)
                    {
                        txtMaKQ.Text = kq.MaKQ;
                        txtMaDT.Text = kq.DeTai.MaDT;
                        txtNhanXet.Text = kq.NhanXet;
                        txtTongDiem.Text = kq.TongDiem.ToString();

                        txtChiTietMaKQ.Text = kq.MaKQ;
                        txtChiTietMaDT.Text = kq.DeTai.MaDT;
                        txtChiTietTenDT.Text = kq.DeTai.TenDT;
                        txtLoaiDT.Text = kq.DeTai.LoaiDT;
                        dtpNgayBD.Value = kq.DeTai.NgayBatDau;
                        dtpNgayKT.Value = kq.DeTai.NgayKetThuc;

                        txtChiTietHoMaSV.Text = kq.SinhVien.MaSinhVien;
                        txtChiTietHoTenSV.Text = kq.SinhVien.HoTen;
                        if (kq.GiaoVien.MaGiangVien == "null")
                        {
                            txtChiTietMaGV.Hide();
                            txtChiTietTenGV.Hide();
                            label16.Hide();
                            label17.Hide();
                        }
                        else
                        {
                            label16.Show();
                            label17.Show();
                            txtChiTietMaGV.Show();
                            txtChiTietTenGV.Show();
                            txtChiTietMaGV.Text = kq.GiaoVien.MaGiangVien;
                            txtChiTietTenGV.Text = kq.GiaoVien.HoTen;
                        }
                        txtChiTietDV.Text = kq.DeTai.MaCTy;
                        txtChiTietNhanXet.Text = kq.NhanXet;
                        txtChiTietTongDiem.Text = kq.TongDiem.ToString();
                        if (kq.KetQuaCuoiCung == KieuKetQua.Dat)
                        {
                            txtChiTietKetQua.Text = "Đạt";
                        }
                        else
                        {
                            txtChiTietKetQua.Text = "Không đạt";
                        }


                    }
                }
            }
            catch (Exception)
            {
             //   MessageBox.Show(ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string find = txtTimkiem.Text;
            List< KetQua> kt = quanLyKetQua.AllSearch(find);
            if (kt != null)
            {
               Display(dgvDanhSachKetQua, kt);
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
        }

        private void btnDetailResult_Click(object sender, EventArgs e)
        {
            if (getCodeKQ != null)
            {
                KetQua findKQ = quanLyKetQua.findKQ(getCodeKQ);
                
                frmDetailStudent frm = new frmDetailStudent(findKQ.SinhVien.MaSinhVien);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xem chi tiết","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string find = txtTimkiem.Text;
            List<KetQua> kt = quanLyKetQua.AllSearch(find);
            if (kt != null)
            {
                Display(dgvDanhSachKetQua, kt);
            }
        }
    }
}
