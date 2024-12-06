using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    [Serializable]

    internal class QuanLyDeTai
    {
        public List<DeTai> DanhSachDeTai { get; set; }

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
            return DanhSachDeTai.Find(ldt => ldt.MaDT == ma);
        }

        public bool Them(DeTai a)
        {
            if (Tim(a.MaDT) == null)
            {
                DanhSachDeTai.Add(a);
                return true;
            }
            return false;
        }

        public bool Xoa(string ma)
        {
            var ldt = Tim(ma);
            if (ldt != null)
            {
                DanhSachDeTai.Remove(ldt);
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
