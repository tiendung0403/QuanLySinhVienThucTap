using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public enum KieuKetQua
    {
        Dat,
        KhongDat
    }
    [Serializable]
    public class KetQua
    {
        public string MaKQ { get; set; }
        public DeTai DeTai { get; set; }
        public SinhVien SinhVien { get; set; }
        public GiangVien GiaoVien { get; set; }
        public string NhanXet { get; set; }
        public double TongDiem { get; set; }
        public KieuKetQua KetQuaCuoiCung { get { return TinhKQ(); } }

       private KieuKetQua TinhKQ()
        {
            if (TongDiem >= 5) return KieuKetQua.Dat;
            return KieuKetQua.KhongDat;
        }
        public KetQua(string maKQ, DeTai deTai, SinhVien sinhVien, GiangVien giaoVien, string nhanXet, double tongDiem)
        {
            if (!KiemTra.KiemTraChuoi(maKQ))
            {
                throw new AggregateException("Mã kết quả không hợp lệ");
            }
            else  MaKQ = maKQ;
            DeTai = deTai;
            SinhVien = sinhVien;
            GiaoVien = giaoVien;
            NhanXet = nhanXet;
            TongDiem = tongDiem;
        }

        public KetQua()
        {
        }
    }
}
