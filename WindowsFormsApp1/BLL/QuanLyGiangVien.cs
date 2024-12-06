using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class QuanLyGiangVien
    {
        public List<GiangVien> DanhsachGiangVien { get; set; }

        public QuanLyGiangVien()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.DanhsachGiangVien = duLieu.getDanhSachGiangVien();
        }

        public List<GiangVien> getDanhSachGV()
        {
            return this.DanhsachGiangVien;
        }

        public GiangVien Tim(string ma)
        {
            return DanhsachGiangVien.Find(gv => gv.MaGiangVien == ma);
        }

        public bool Them(GiangVien a)
        {
            if (Tim(a.MaGiangVien) == null)
            {
                DanhsachGiangVien.Add(a);
                return true;
            }
            return false;
        }

        public bool Xoa(string ma)
        {
            var cty = Tim(ma);
            if (cty != null)
            {
                DanhsachGiangVien.Remove(cty);
                return true;
            }
            return false;
        }

        public bool Sua(GiangVien a)
        {
            GiangVien ketQuaTim = Tim(a.MaGiangVien);
            if (ketQuaTim != null)
            {
                ketQuaTim.MaGiangVien = a.MaGiangVien;
                ketQuaTim.HoTen = a.HoTen;
                ketQuaTim.GioiTinh = a.GioiTinh;
                ketQuaTim.NgaySinh = a.NgaySinh;
                ketQuaTim.ChucVu = a.ChucVu;
                ketQuaTim.Email = a.Email;
                ketQuaTim.SoDienThoai = a.SoDienThoai;
                return true;
            }
            return false;
        }

    }
}
