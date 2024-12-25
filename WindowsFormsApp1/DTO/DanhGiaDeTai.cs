using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    [Serializable]
    public class DanhGiaDeTai
    {
        public string MaDG { get; set; }
        public int Tuan { get; set; }
        public DeTai DeTai { get; set; }
        public SinhVien SinhVien { get; set; }
        public string NhanXet { get; set; }
        public double Diem { get; set; }
        public string LinkBaoCao { get; set; }

        public DanhGiaDeTai()
        {

        }

        public DanhGiaDeTai(string maDG, int tuan, DeTai deTai, SinhVien sinhVien, string nhanXet, double diem, string linkBaoCao)
        {
            if (!KiemTra.KiemTraChuoi(maDG))
            {
                throw new AggregateException("Mã không hợp lệ");
            }
            else MaDG = maDG;
            Tuan = tuan;
            DeTai = deTai;
            SinhVien = sinhVien;
            NhanXet = nhanXet;
            Diem = diem;
            LinkBaoCao = linkBaoCao;
            
        }
    }
}
