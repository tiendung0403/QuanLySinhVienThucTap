using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Security.AccessControl;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    [Serializable]

    internal class QuanLyGiangVien
    {
        private List<GiangVien> DanhsachGiangVien;

        public QuanLyGiangVien()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.DanhsachGiangVien = duLieu.getDanhSachGiangVien();
        }

        public List<GiangVien> getDanhSachGV()
        {
            return this.DanhsachGiangVien;
        }
        public int DemGV()
        {
            return this.DanhsachGiangVien.Count;
        }

        public GiangVien Tim(string ma)
        {
            return this.DanhsachGiangVien.Find(gv => gv.MaGiangVien == ma);
        }

        public bool Them(GiangVien a)
        {
            if (Tim(a.MaGiangVien) == null)
            {
                this.DanhsachGiangVien.Add(a);
                return true;
            }
            return false;
        }

        public bool xoa(string ma)
        {
           GiangVien sv=Tim(ma);
            if (sv != null)
            {
                this.DanhsachGiangVien.Remove(sv);
                return true;
            }
            return false;
        }

        public bool Sua(GiangVien a)
        {
            GiangVien ketQuaTim = Tim(a.MaGiangVien);
            if (ketQuaTim != null)
            {
                ketQuaTim.HoTen = a.HoTen;
                ketQuaTim.GioiTinh = a.GioiTinh;
                ketQuaTim.NgaySinh = a.NgaySinh;
                ketQuaTim.ChucVu = a.ChucVu;
                ketQuaTim.Email = a.Email;
                ketQuaTim.SoDienThoai = a.SoDienThoai;
                ketQuaTim.Khoa=a.Khoa;
                return true;
            }
            return false;
        }
        public List<GiangVien> TimKiem(string s)
        {
            return this.DanhsachGiangVien.Where(gv => gv.MaGiangVien.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0 || 
            gv.HoTen.IndexOf(s,StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public List<GiangVien> TimDsTheoKhoa(string khoa)
        {
            List<GiangVien> ds = new List<GiangVien>();
            foreach (GiangVien giangVien in DanhsachGiangVien)
            {
                if (giangVien.Khoa == khoa)
                {
                    ds.Add(giangVien);
                }
            }
            return ds;
        }

        public List<GiangVien> TimDsTheoTrangThai(TrangThai trangthai)
        {
            List<GiangVien> ds = new List<GiangVien>();
            foreach (GiangVien giangVien in DanhsachGiangVien)
            {
                if (giangVien.TrangThai == trangthai)
                {
                    ds.Add(giangVien);
                }
            }
            return ds;
        }

        public bool ThayTheGV(string maGVold,string maGVnew)
        {
            GiangVien gvNew = Tim(maGVnew);
            QuanLyDeTai dt= new QuanLyDeTai();
            foreach (DeTai detai in dt.getDanhSachDeTai())
            {
                if (detai.GiaoVien.MaGiangVien == maGVold)
                {
                    detai.GiaoVien = gvNew;
                    return true;
                }
            }
            return false;
        }

    }
}
