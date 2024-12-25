using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    [Serializable]
    public class QuanLyDanhGia
    {
        private List<DanhGiaDeTai> dsDanhGia;

        public QuanLyDanhGia()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.dsDanhGia = duLieu.getDanhSachDanhGia();
        }   

        public List<DanhGiaDeTai> getDanhSachDanhGia()
        {
            return this.dsDanhGia;
        }

        public DanhGiaDeTai Tim(string ma)
        {
            return this.dsDanhGia.Find(dg => dg.MaDG == ma);
        }

        public DanhGiaDeTai TimTuan(int tuan)
        {
            return this.dsDanhGia.Find(dg => dg.Tuan == tuan);
        }

        public bool KiemTraDG(int tuan, string maDT)
        {
            foreach(DanhGiaDeTai dgdt in dsDanhGia)
            {
                if(dgdt.Tuan == tuan && dgdt.DeTai.MaDT == maDT)
                {
                    return true;
                }
            }
            return false;
        }

        public DanhGiaDeTai TangDanTheoTuan()
        {
            
            return this.dsDanhGia.OrderBy(dg => dg.Tuan).FirstOrDefault();
        }

        public DanhGiaDeTai TimTheoMaDT(string maDT)
        {
            return this.dsDanhGia.Find(dg => dg.DeTai.MaDT == maDT);
        }

        public List<DanhGiaDeTai> TimDsTheoMaDT(string maDT)
        {
            List<DanhGiaDeTai> danhSach = new List<DanhGiaDeTai>();
            foreach (DanhGiaDeTai dt in this.dsDanhGia)
            {
                if(this.dsDanhGia.Find(dg => dg.DeTai.MaDT == maDT) != null)
                {
                    danhSach.Add(dt);
                }
            }
            return danhSach;
        }

        public List<DanhGiaDeTai> TimDsTheoMaSV(string maSV)
        {
            List<DanhGiaDeTai> danhSach = new List<DanhGiaDeTai>();
            foreach (DanhGiaDeTai dt in this.dsDanhGia)
            {
                if (dt.SinhVien.MaSinhVien == maSV)
                {
                    danhSach.Add(dt);
                }
            }
            return danhSach;
        }

        public bool Them(DanhGiaDeTai a)
        {
            if (Tim(a.MaDG) == null)
            {
                this.dsDanhGia.Add(a);
                return true;
            }
            return false;
        }

        public bool Xoa(string ma)
        {
            var dg = Tim(ma);
            if (dg != null)
            {
                this.dsDanhGia.Remove(dg);
                return true;
            }
            return false;
        }

        public bool Sua(DanhGiaDeTai a)
        {
            DanhGiaDeTai ketQuaTim = Tim(a.MaDG);
            if (ketQuaTim != null)
            {
                ketQuaTim.Tuan = a.Tuan;
                ketQuaTim.DeTai = a.DeTai;
                ketQuaTim.SinhVien = a.SinhVien;
                ketQuaTim.NhanXet = a.NhanXet;
                ketQuaTim.Diem = a.Diem;
                ketQuaTim.LinkBaoCao = a.LinkBaoCao;
                return true;
            }
            return false;
        }

        public List<DanhGiaDeTai> Timkiem(string a)
        {
            return dsDanhGia.Where(dg => dg.MaDG.IndexOf(a, StringComparison.OrdinalIgnoreCase) >= 0 ||
            dg.DeTai.MaDT.IndexOf(a, StringComparison.OrdinalIgnoreCase) >= 0 ||
            dg.SinhVien.MaSinhVien.IndexOf(a, StringComparison.OrdinalIgnoreCase) >= 0 || 
            dg.DeTai.TenDT.IndexOf(a,StringComparison.OrdinalIgnoreCase) >= 0).ToList();

        }
        public List<DanhGiaDeTai> LocVaSapXepTheoMaDT(string maDT)
        {
            List<DanhGiaDeTai> danhSach = TimDsTheoMaDT(maDT);
            return danhSach.OrderBy(dg => dg.Tuan).ToList();
        }

        public List<DanhGiaDeTai> LocVaSapXepTheoMaSV(string maSV)
        {
            List<DanhGiaDeTai> danhSach = TimDsTheoMaSV(maSV);
            return danhSach.OrderBy(dg => dg.Tuan).ToList();
        }

        public bool CheckKQsinhVien(string maSV)
        {
            foreach (KetQua kq in new QuanLyKetQua().getDanhSachKetQua())
            {
                if (kq.SinhVien.MaSinhVien == maSV)
                {
                    return true; 
                }
            }
            return false;
        }
    }
}
