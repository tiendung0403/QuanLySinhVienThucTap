using System;
using System.Collections.Generic;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    [Serializable]

    internal class QuanLySinhVien
    {
        private List<SinhVien> DanhSachSV;

        public QuanLySinhVien()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.DanhSachSV = duLieu.getDanhSachSinhVien();
        }
        public QuanLySinhVien(List<SinhVien> ds)
        {
            this.DanhSachSV = ds;
        }
        public List<SinhVien> getDanhSachSinhVien()
        {
            return this.DanhSachSV;
        }

        public SinhVien Tim(string ma)
        {
            return DanhSachSV.Find(sv => sv.MaSinhVien == ma);
        }

        public bool Them(SinhVien a)
        {
            if (Tim(a.MaSinhVien) == null)
            {
                this.DanhSachSV.Add(a);
                return true;
            }
            return false;
        }

        public bool Xoa(string ma)
        {
            var sv = Tim(ma);
            if (sv != null)
            {
                this.DanhSachSV.Remove(sv); 
                return true;
            }
            return false;
        }

        public bool Sua(SinhVien a)
        {
            SinhVien ketQuaTim = Tim(a.MaSinhVien);
            if (ketQuaTim != null)
            {
                ketQuaTim.HoTen = a.HoTen;
                ketQuaTim.GioiTinh = a.GioiTinh;
                ketQuaTim.NgaySinh = a.NgaySinh;
                ketQuaTim.Email = a.Email;
                ketQuaTim.SoDienThoai = a.SoDienThoai;
                ketQuaTim.DiemTrungBinh = a.DiemTrungBinh;
                ketQuaTim.Lop = a.Lop;
                ketQuaTim.MaCongTy = a.MaCongTy;
                ketQuaTim.MaGiangVien = a.MaGiangVien;
                return true;
            }
            return false;
        }
    }
}