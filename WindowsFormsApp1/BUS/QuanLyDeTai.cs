using System;
using System.Collections.Generic;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    [Serializable]

    internal class QuanLyDeTai
    {
        private List<DeTai> DanhSachDeTai;

        public QuanLyDeTai()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.DanhSachDeTai = duLieu.getDanhSachDeTai();
        }

        public List<DeTai> getDanhSachDeTai()
        {
            return this.DanhSachDeTai;
        }

        public DeTai Tim(string ma)
        {
            return this.DanhSachDeTai.Find(ldt => ldt.MaDT == ma);
        }

        public bool Them(DeTai a)
        {
            if (Tim(a.MaDT) == null)
            {
                this.DanhSachDeTai.Add(a);
                return true;
            }
            return false;
        }

        public bool Xoa(string ma)
        {
            var ldt = Tim(ma);
            if (ldt != null)
            {
                this.DanhSachDeTai.Remove(ldt);
                return true;
            }
            return false;
        }

        public bool Sua(DeTai a)
        {
            DeTai ketQuaTim = Tim(a.MaDT);
            if (ketQuaTim != null)
            {
                ketQuaTim.MaDT = a.MaDT;
                ketQuaTim.TenDT = a.TenDT;
                ketQuaTim.NgayBatDau = a.NgayBatDau;
                ketQuaTim.NgayKetThuc = a.NgayKetThuc;
                ketQuaTim.LoaiDT = a.LoaiDT;
                ketQuaTim.MaCTy = a.MaCTy;
                return true;
            }
            return false;
        }
    }
}
