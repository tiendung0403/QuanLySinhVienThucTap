using System;
using System.Text.RegularExpressions;
using WindowsFormsApp1.BUS;

namespace WindowsFormsApp1.DTO
{

    [Serializable]

    public class DeTai
    {
        private string ma,ten;
        private DateTime ngaybd, ngaykt;
        private SinhVien sinhVien ;
        private GiangVien giaoVien;

        public string MaDT { get => ma; set
            {
                if (!KiemTra.KiemTraChuoi(value))
                    throw new AggregateException("Mã không hợp lệ");
                else ma = value;
            } 
        }
        public string TenDT { get => ten; set 
            {
                if (!KiemTra.KiemTraTen(value))
                    throw new AggregateException("Tên không hợp lệ");
                else ten = value;
            }
        }
        public DateTime NgayBatDau { get => ngaybd; set
            {
                if (value > DateTime.Now.Date)
                    throw new AggregateException("Ngày bắt đầu không hợp lệ");
                else ngaybd = value;
            }
        }
        public DateTime NgayKetThuc { get => ngaykt; set
            {
                if (value < NgayBatDau)
                    throw new AggregateException("Ngày kết thúc đang nhỏ hơn ngày bắt đầu");
                else ngaykt = value;
            }
        }
        public string LoaiDT { get; set; }
        public string MaCTy { get; set; }
        public SinhVien SinhVien { get { return this.sinhVien; } set { this.sinhVien = value; } }
        public GiangVien GiaoVien { get { return this.giaoVien; } set { this.giaoVien = value; } }
        public string TrangThai { get { return TinhTT(); } }

        private string TinhTT()
        {
            QuanLyKetQua kt= new QuanLyKetQua();
            if (kt.findDeTai(this.MaDT) != null)
                return "Kết thúc";
            return "Bắt đầu";
        }

      
        public DeTai()
        {
            MaDT = null;
            TenDT = null;
            this.sinhVien = new SinhVien();
            NgayBatDau = DateTime.Now;
            NgayKetThuc = DateTime.Now;
            LoaiDT = null;
            MaCTy = null;
            this.giaoVien = new GiangVien();
           
        }

        public DeTai(string ma,string ten,SinhVien sv,DateTime ngaybd,DateTime ngaykt,string loai,string macty,GiangVien gv)
        {
            MaDT = ma;
            TenDT = ten;
            this.sinhVien = sv;
            NgayBatDau = ngaybd;
            NgayKetThuc = ngaykt;
            if (!KiemTra.KiemTraTen(loai))
            {
                throw new AggregateException("Loại đề tài không hợp lệ");
            }
            else LoaiDT = loai;


            MaCTy = macty;
            this.giaoVien = gv;
        }
    }
}
