using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class QuanLyLoaiDeTai
    {
        public List<LoaiDeTai> DanhSachLDT { get; set; }

        public QuanLyLoaiDeTai()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.DanhSachLDT = duLieu.getDanhSachLoaiDT();
        }

        public List<LoaiDeTai> getDanhSachLoaiDT()
        {
            return this.DanhSachLDT;
        }        

        public LoaiDeTai Tim(string ma)
        {
            return DanhSachLDT.Find(ldt => ldt.MaLoai == ma);
        }

        public bool Them(LoaiDeTai a)
        {
            if (Tim(a.MaLoai) == null)
            {
                DanhSachLDT.Add(a);
                return true;
            }
            return false;
        }

        public bool Xoa(string ma)
        {
            var ldt = Tim(ma);
            if (ldt != null) 
            {
                DanhSachLDT.Remove(ldt);
                return true;
            }
            return false; 
        }

        public bool Sua(LoaiDeTai a)
        {
            LoaiDeTai ketQuaTim = Tim(a.MaLoai);
            if (ketQuaTim != null)
            {
                ketQuaTim.MaLoai = a.MaLoai;
                ketQuaTim.TenLoai = a.TenLoai;
                return true;
            }
            return false; 
        }
    }
}
