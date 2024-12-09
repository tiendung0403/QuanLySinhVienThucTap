using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    [Serializable]

    internal class QuanLyCongTy
    {
        private List<CongTy> DanhsachCTy;

        public QuanLyCongTy()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.DanhsachCTy = duLieu.getDanhSachCongTy();
        }

        public List<CongTy> getDanhSachCongTy()
        {
            return this.DanhsachCTy;
        }

        public CongTy Tim(string ma)
        {
            return this.DanhsachCTy.Find(cty => cty.MaCongTy == ma);
        }

        public bool Them(CongTy a)
        {
            if (Tim(a.MaCongTy) == null)
            {
                this.DanhsachCTy.Add(a);
                return true;
            }
            return false;
        }

        public bool Xoa(string ma)
        {
            var cty = Tim(ma);
            if (cty != null)
            {
                this.DanhsachCTy.Remove(cty);
                return true;
            }
            return false;
        }

        public bool Sua(CongTy a)
        {
            CongTy ketQuaTim = Tim(a.MaCongTy); 
            if (ketQuaTim != null)
            {
                ketQuaTim.TenCongTy = a.TenCongTy;
                ketQuaTim.TenVietTat = a.TenVietTat;
                ketQuaTim.DiaChi = a.DiaChi;
                ketQuaTim.SoDienThoai = a.SoDienThoai;
                ketQuaTim.Email = a.Email;
                return true; 
            }
            return false;
        }
        public List<CongTy> TimKiem(string s)
        {
            return DanhsachCTy.Where(cty => cty.TenVietTat.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0 ||
            cty.TenCongTy.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0 ||
            cty.MaCongTy.IndexOf(s,StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }
    }
}
