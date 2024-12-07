using System;

namespace WindowsFormsApp1.DTO
{
    [Serializable]

    internal class CongTy
    {
        private string ma, ten, tenVT, diachi, sdt, email;

        public string MaCongTy { get => ma; set
            {
                if (!KiemTra.KiemTraChuoi(value))
                    throw new AggregateException("Mã không hợp lệ");
                ma = value;
            }
        }
        public string TenCongTy { get  => ten; set
            {
                if (!KiemTra.KiemTraChuoi(value))
                    throw new AggregateException("Tên không hợp lệ");
                else ten = value;
            }
        }
        public string TenVietTat {
            get => tenVT; set
            {
                if (!KiemTra.KiemTraChuoi(value))
                    throw new AggregateException("Tên Viết tắt không hợp lệ");
                else tenVT = value;
            }
        }
        public string DiaChi {
            get => diachi; set
            {
                if (!KiemTra.KiemTraDiaChi(value))
                    throw new AggregateException("Địa chỉ không hợp lệ");
                else diachi = value;
            }
        }
        public string SoDienThoai {
            get => sdt; set
            {
                if (!KiemTra.KiemTraSoDienThoai(value))
                    throw new AggregateException("Số điện thoại phải có 10 số");
                else ten = value;
            }
        }
        public string Email {
            get => email; set
            {
                if (KiemTra.KiemTraEmail(value))
                    throw new AggregateException("Email không hợp lệ");
                else email = value;
            }
        }

        public CongTy()
        {
        }

        public CongTy(string maCongTy, string tenCongTy, string tenVietTat, string diaChi, string soDienThoai, string email)
        {
            MaCongTy = maCongTy;
            TenCongTy = tenCongTy;
            TenVietTat = tenVietTat;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
        }

    }
}

