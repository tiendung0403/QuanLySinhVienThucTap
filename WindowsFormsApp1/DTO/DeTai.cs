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
        public string MaDT { get; set; }
        public string TenDT { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
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
