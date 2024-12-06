using System;

namespace WindowsFormsApp1.BLL
{
    [Serializable]

    internal class CongTy
    {
        public string MaCongTy { get; set; }
        public string TenCongTy { get; set; }
        public string TenVietTat { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

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

