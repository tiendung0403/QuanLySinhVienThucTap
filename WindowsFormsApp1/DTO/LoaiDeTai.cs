using System;

namespace WindowsFormsApp1.DTO
{
    [Serializable]
    internal class LoaiDeTai
    {
        private string maloai;
        private string ten;
        public string MaLoai { get => maloai; 
            set
            {
                if (!KiemTra.KiemTraChuoi(value))
                    throw new AggregateException("Mã không hợp lệ");
                else maloai = value;
            }
        }
        public string TenLoai { get => ten;
            set
            {
                if (!KiemTra.KiemTraTen(value))
                    throw new AggregateException("Tên không hợp lệ");
                else ten = value;
            }
        }
        public string Khoa { get; set; }
        public DateTime NgayThem { get; set; }
        public LoaiDeTai()
        {
        }
        public LoaiDeTai(string maLoai,string khoa, string tenLoai,DateTime ngayThem )
        {
            MaLoai = maLoai;
            Khoa = khoa;
            TenLoai = tenLoai;
            NgayThem = ngayThem;
        }
    }
}
