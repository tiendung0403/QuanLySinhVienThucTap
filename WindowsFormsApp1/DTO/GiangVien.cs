using System;

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
                if (!KiemTra.KiemTraChuoi(value))
                    throw new ArgumentException("Mã không hợp lệ");
                ma = value;
            }
        }
        public string HoTen
        {
            get => ten;
            set
            {
                if (!KiemTra.KiemTraChuoi(value))
                    throw new ArgumentException("Tên không hợp lệ");
                ten = value;
            }
        }
        public string GioiTinh
        {
            get => gioitinh;
            set
            {
                if (!KiemTra.KiemTraChuoi(value))
                    throw new ArgumentException("Giới tính không hợp lệ");
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
                if (!KiemTra.KiemTraChuoi(value))
                    throw new ArgumentException("Chức vụ không hợp lệ");
                chucvu = value;
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (!KiemTra.KiemTraEmail(value))
                    throw new ArgumentException("Email không hợp lệ");
                email = value;
            }
        }
        public string SoDienThoai
        {
            get => sdt;
            set
            {
                if (!KiemTra.KiemTraSoDienThoai(value))
                    throw new ArgumentException("Số điện thoại không đủ 10 chữ số");
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
    }
}

