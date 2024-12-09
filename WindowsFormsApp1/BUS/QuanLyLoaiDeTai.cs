using System;
using System.Collections.Generic;
using System.Linq;
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


        public bool Sua(LoaiDeTai a)
        {
            LoaiDeTai ketQuaTim = Tim(a.MaLoai);
            if (ketQuaTim != null)
            {

                TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
                List<DeTai> dsdt = duLieu.getDanhSachDeTai();

                foreach (DeTai dt in dsdt)
                {
                    if (dt.LoaiDT == ketQuaTim.TenLoai)
                    {
                        dt.LoaiDT = a.TenLoai;
                    }
                }
                ketQuaTim.TenLoai = a.TenLoai;

                return true;
            }
            return false;
        }
        public List<LoaiDeTai> TimKiem(string s)
        {
            return DanhSachLDT.Where(ldt => ldt.MaLoai.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0 ||
            ldt.TenLoai.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

    }
}
