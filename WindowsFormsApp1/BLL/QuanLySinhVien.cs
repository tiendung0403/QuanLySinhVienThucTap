using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class QuanLySinhVien
    {
        public List<SinhVien> DanhSachSV { get; set; }

        public QuanLySinhVien()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.DanhSachSV = duLieu.getDanhSachSinhVien();
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
                DanhSachSV.Add(a);
                return true;
            }
            return false;
        }

        public bool Xoa(string ma)
        {
            var sv = Tim(ma);
            if (sv != null)
            {
                DanhSachSV.Remove(sv);
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