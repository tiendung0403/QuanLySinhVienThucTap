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
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
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
