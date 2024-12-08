using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    [Serializable]

    public class DeTai
    {
        private string ma,ten;
        private DateTime ngaybd, ngaykt;

        public string MaDT { get => ma; set
            {
                if (!KiemTra.KiemTraChuoi(value))
                    throw new AggregateException("Mã không hợp lệ");
                else ma = value;
            } 
        }
        public string TenDT { get => ten; set 
            {
                if (!KiemTra.KiemTraChuoi(value))
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
                if (value >= DateTime.Now.Date)
                    throw new AggregateException("Ngày Kết thúc không hợp lệ");
                else if (value < NgayBatDau)
                    throw new AggregateException("Ngày kết thúc đang nhỏ hơn ngày bắt đầu");
                else ngaykt = value;
            }
        }
        public string LoaiDT { get; set; }
        public string MaCTy { get; set; }

        public DeTai()
        {
        }

        public DeTai(string ma,string ten,DateTime ngaybd,DateTime ngaykt,string loai,string macty)
        {
            MaDT = ma;
            TenDT = ten;
            NgayBatDau = ngaybd;
            NgayKetThuc = ngaykt;
            LoaiDT = loai;
            MaCTy = macty;
        }
    }
}
