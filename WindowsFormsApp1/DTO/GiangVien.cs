using System;
using System.Security.Cryptography;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.DTO
{
    public enum TrangThai
    {
        DangDay,NghiDay
        
    }
    [Serializable]

    public class GiangVien
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
                if (!KiemTra.KiemTraTen(value))
                    throw new ArgumentException("Tên không hợp lệ");
                ten = value;
            }
        }
        public string GioiTinh
        {
            get => gioitinh;
            set => gioitinh = value;
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
                if (!KiemTra.KiemTraTen(value))
                    throw new ArgumentException("Chức vụ không hợp lệ");
                chucvu = value;
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (!KiemTra.IsEmail(value))
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

        public string Khoa { get; set; }
        
        public TrangThai TrangThai { get { return TinhTT(); } }

        public TrangThai TinhTT()
        {
            QuanLyDeTai deTai = new QuanLyDeTai();
            foreach (DeTai dt in deTai.getDanhSachDeTai())
            {
                if (dt.GiaoVien != null && dt.GiaoVien.MaGiangVien == MaGiangVien && dt.SinhVien.TrangThaiSV != TrangThaiSV.KetThuc)
                {
                    return TrangThai.DangDay;
                }
            }
            return TrangThai.NghiDay;
        }

            public GiangVien() {
            MaGiangVien ="";
            HoTen = "";
            GioiTinh = "";
            NgaySinh = DateTime.Now;
            ChucVu = "";
            Email = "";
            SoDienThoai = "";
        }

        public GiangVien(string maGiangVien, string hoTen, string gioiTinh, DateTime ngaySinh, string chucVu, string email, string soDienThoai,string khoa)
        {
            MaGiangVien = maGiangVien;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            ChucVu = chucVu;
            Email = email;
            SoDienThoai = soDienThoai;
            Khoa = khoa;
        }
    }
}

