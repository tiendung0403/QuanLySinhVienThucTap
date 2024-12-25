using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.DTO
{
    [Serializable]
    public class Khoa
    {
        public string maDsKhoa { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        
        public string LopHoc { get; set; }
        public int NamHoc { get; set; }  

        public int SoLuongSV { get { return TinhSLSV(); } }

        public int TinhSLSV()
        {
            int sumSL = 0;
            foreach (SinhVien sv in new QuanLySinhVien().getDanhSachSinhVien())
            {
                if (sv.Lop == this.LopHoc &&sv.Lop2==this.MaKhoa)
                {
                    sumSL++;
                }
            }
            return sumSL;
        }

        public Khoa() { }   
        public Khoa(string maDS,string maKhoa, string tenKhoa, string lopHoc, int namHoc)
        {
            if (!KiemTra.KiemTraChuoi(maDS))
            {
                throw new AggregateException("Mã Danh sách không hợp lệ");
            }
            else maDsKhoa = maDS;

            if (!KiemTra.KiemTraChuoi(maKhoa))
            {
                throw new AggregateException("Mã Khoa không hợp lệ");
            }
            else MaKhoa = maKhoa;

            if (!KiemTra.KiemTraTen(tenKhoa))
            {
                throw new AggregateException("Tên khoa không hợp lệ");
            }
            else TenKhoa = tenKhoa;

            LopHoc = lopHoc;
            NamHoc = namHoc;
        }
    }
}
