using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DTO
{
    [Serializable]

    internal class GiangVien
    {
        private string ma, ten, gioitinh, chucvu, email, sdt;
        private DateTime ngaysinh;

        public string MaGiangVien
        {
            get => ma;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Mã không được để trống.");
                ma = value;
            }
        }
        public string HoTen
        {
            get => ten;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên không được để trống.");
                ten = value;
            }
        }
        public string GioiTinh
        {
            get => gioitinh;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Giới tính không được để trống.");
                gioitinh = value;
            }
        }    
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
        public string ChucVu
        {
            get => chucvu;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Chức vụ không được để trống.");
                chucvu = value;
            }
        }
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
        public string SoDienThoai
        {
            get => sdt;
            set
            {
                if (!KiemTraSoDienThoai(value))
                    throw new ArgumentException("Số điện thoại không hợp lệ.");
                sdt = value;
            }
        }

        public GiangVien() { }

        public GiangVien(string maGiangVien, string hoTen, string gioiTinh, DateTime ngaySinh, string chucVu, string email, string soDienThoai)
        {
            MaGiangVien = maGiangVien;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            ChucVu = chucVu;
            Email = email;
            SoDienThoai = soDienThoai;
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

