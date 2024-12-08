using System;
using System.Collections.Generic;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    [Serializable]

    internal class QuanLyLoaiDeTai
    {
        private List<LoaiDeTai> DanhSachLDT;

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
            return this.DanhSachLDT.Find(ldt => ldt.MaLoai == ma);
        }

        public bool Them(LoaiDeTai a)
        {
            if (Tim(a.MaLoai) == null)
            {
                this.DanhSachLDT.Add(a);
                return true;
            }
            return false;
        }

        public bool Xoa(string ma)
        {
            var ldt = Tim(ma);
            if (ldt != null) 
            {
                this.DanhSachLDT.Remove(ldt);
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
