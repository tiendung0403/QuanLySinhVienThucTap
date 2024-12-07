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
                if (string.IsNullOrWhiteSpace(value))
                    throw new AggregateException("Mã đang trống");
                else maloai = value;
            }
        }
        public string TenLoai { get =>ten;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new AggregateException("Tên đang trống");
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
