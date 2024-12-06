using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1.DTO
{
    [Serializable]

    internal class SinhVien
    {
        private string masinhvien;
        public string MaSinhVien
        {
            get => masinhvien;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Mã không được để trống.");
                masinhvien = value;
            }
        }

        private string hoten;
        public string HoTen
        {
            get => hoten;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên không được trống");
                hoten = value;
            }
        }

        private string gioitinh;
        public string GioiTinh
        {
            get => gioitinh;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Giới tính không được trống");
                gioitinh = value;
            }
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
                if (!KiemTraEmail(value))
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
                if (!KiemTraSoDienThoai(value))
                    throw new ArgumentException("Số điện thoại không hợp lệ.");
                soDienThoai = value;
            }
        }

        private double dtb;
        private bool kiemtraDiem(string s)
        {
            try
            {
                double.Parse(s);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

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
        public string MaCongTy { get; set; }
        public string MaGiangVien { get; set; }


        public SinhVien() { }

        public SinhVien(string maSinhVien, string hoTen, string gioiTinh, DateTime ngaySinh, string email, string soDienThoai, double diemTrungBinh, string lop, string maCongTy, string maGiangVien)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Email = email;
            SoDienThoai = soDienThoai;
            DiemTrungBinh = diemTrungBinh;
            Lop = lop;
            MaCongTy = maCongTy;
            MaGiangVien = maGiangVien;
        }

        private bool KiemTraEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9]+([._%+-]?[a-zA-Z0-9]+)*@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool KiemTraSoDienThoai(string soDienThoai)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(soDienThoai, pattern);
        }

    }
}

