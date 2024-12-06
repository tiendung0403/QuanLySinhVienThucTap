using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    [Serializable]

    internal class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }

        private string email;
        public string Email
        {
            get => email;
            set
            {
                if (KiemTraEmail(value))
                    email = value;
                else
                    throw new ArgumentException("Email không hợp lệ.");
            }
        }

        private string soDienThoai;
        public string SoDienThoai
        {
            get => soDienThoai;
            set
            {
                if (KiemTraSoDienThoai(value))
                    soDienThoai = value;
                else
                    throw new ArgumentException("Số điện thoại không hợp lệ. Số điện thoại phải có 10 chữ số.");
            }
        }

        public double DiemTrungBinh { get; set; }
        public string Lop { get; set; }
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
            string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9.]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private bool KiemTraSoDienThoai(string soDienThoai)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(soDienThoai, pattern);
        }

    }
}

