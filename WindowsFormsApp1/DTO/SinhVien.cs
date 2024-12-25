using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.DTO
{
    
    public enum TrangThaiSV
    {
        ChuaThucTap,
        DangThucTap,
        KetThuc
    }
    [Serializable]
    public class SinhVien
    {
        private string masinhvien;
        public string MaSinhVien
        {
            get => masinhvien;
            set
            {
                if (!KiemTra.KiemTraChuoi(value))
                    throw new ArgumentException("Mã không hợp lệ.");
                masinhvien = value;
            }
        }

        private string hoten;
        public string HoTen
        {
            get => hoten;
            set
            {
                if (!KiemTra.KiemTraTen(value))
                    throw new ArgumentException("Tên không hợp lệ");
                hoten = value;
            }
        }

        private string gioitinh;
        public string GioiTinh
        {
            get => gioitinh;
            set => gioitinh = value;  
        }

        private DateTime ngaysinh;
        public DateTime NgaySinh
        {
            get => ngaysinh;
            set
            {
                if (value >= DateTime.Now.Date)
                    throw new ArgumentException("Ngày sinh không hợp lệ");
                else ngaysinh = value;
            }
        }

        private string email;
        public string Email
        {
            get => email;
            set
            {
                if (!KiemTra.IsEmail(value))
                    throw new ArgumentException("Email không hợp lệ.");
                email = value;
            }
        }

        private string soDienThoai;
        public string SoDienThoai
        {
            get => soDienThoai;
            set
            {
                if (!KiemTra.KiemTraSoDienThoai(value))
                    throw new ArgumentException("Số điện thoại có 10 chữ số không hợp lệ.");
                soDienThoai = value;
            }
        }

        private double dtb;

        public double DiemTrungBinh
        {
            get => dtb;
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Điểm phải trong khoảng từ 0 đến 10");
                dtb = value;
            }
        }
        private string lop;
        public string Lop
        {
            get => lop;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Lớp không được trống");
                lop = value;
            }
        }

        private string lop2;
        public string Lop2 //khoa
        {
            get => lop2;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Khoa không được trống");
                lop2 = value;
            }
        }


        public SinhVien() {
            MaSinhVien = "";
            HoTen = "";
            GioiTinh = "";
            NgaySinh = DateTime.Now;
            Email = "";
            SoDienThoai = "";
            DiemTrungBinh = 0;
            Lop = "";
            Lop2 = "";
        }

        public SinhVien(string maSinhVien, string hoTen, string gioiTinh, DateTime ngaySinh, string email, string soDienThoai, double diemTrungBinh, string lop, string lop2)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Email = email;
            SoDienThoai = soDienThoai;
            DiemTrungBinh = diemTrungBinh;
            Lop = lop;
            Lop2 = lop2;
        }

        public SinhVien(string maSinhVien, string hoTen, string gioiTinh, DateTime ngaySinh, string email, string soDienThoai, string diemTrungBinh, string lop, string lop2)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Email = email;
            SoDienThoai = soDienThoai;
            DiemTrungBinh = kiemtraDiem(diemTrungBinh);
            Lop = lop;
            Lop2 = lop2;
        }

        private double kiemtraDiem(string s)
        {
            try
            {
                double.Parse(s);
                return double.Parse(s);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public TrangThaiSV TrangThaiSV { get { return TinhTT(); } }

        public TrangThaiSV TinhTT() {
            foreach (DeTai dt in new QuanLyDeTai().getDanhSachDeTai())
            {
                if (dt.SinhVien.MaSinhVien == this.masinhvien && dt.TrangThai == "Kết thúc")
                {
                    return TrangThaiSV.KetThuc;
                } else if (dt.SinhVien.MaSinhVien == this.masinhvien && dt.TrangThai == "Bắt đầu")
                {
                    return TrangThaiSV.DangThucTap;
                }
            }
            return TrangThaiSV.ChuaThucTap;
        }
    }
}

