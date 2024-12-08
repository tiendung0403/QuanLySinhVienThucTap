using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (!KiemTra.KiemTraChuoi(value))
                    throw new AggregateException("Tên không hợp lệ");
                else ten = value;
            }
        }
        public LoaiDeTai()
        {
            MaLoai = "";
            TenLoai = "";
        }
        public LoaiDeTai(string maLoai, string tenLoai )
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
        }
    }
}
