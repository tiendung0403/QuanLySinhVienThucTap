using System;
using System.Collections.Generic;
using System.Linq;
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

        public int DemSV()
        {
            return this.DanhSachSV.Count;
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
                ketQuaTim.Lop2 = a.Lop2;
                return true;
            }
            return false;
        }

        public List<SinhVien> TimDsTheoLop(string lop)
        {
            List<SinhVien> ds = new List<SinhVien>();
            foreach (SinhVien sv in this.DanhSachSV)
            {
                if (sv.Lop == lop)
                {
                    ds.Add(sv);
                }
            }
            return ds;
        }

        public List<SinhVien> TimDsTheoKhoa(string Khoa)
        {
            List<SinhVien> ds = new List<SinhVien>();
            foreach (SinhVien sv in this.DanhSachSV)
            {
                if (sv.Lop2 == Khoa)
                {
                    ds.Add(sv);
                }
            }
            return ds;
        }



        public List<SinhVien> TimKiem(string s)
        {
            return this.DanhSachSV.Where(sv => sv.HoTen.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0 ||
            sv.MaSinhVien.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public void SapXepTheoTenGoc(bool tangDan = true)
        {
            if (tangDan)
            {
                DanhSachSV.Sort((sv1, sv2) => sv1.HoTen.CompareTo(sv2.HoTen)); // Tăng dần
            }
            else
            {
                DanhSachSV.Sort((sv1, sv2) => sv2.HoTen.CompareTo(sv1.HoTen)); // Giảm dần
            }
        }

        public void SapXepTheoDiemGoc(bool tangDan = true)
        {
            if (tangDan)
            {
                DanhSachSV.Sort((sv1, sv2) => sv1.DiemTrungBinh.CompareTo(sv2.DiemTrungBinh)); // Tăng dần
            }
            else
            {
                DanhSachSV.Sort((sv1, sv2) => sv2.DiemTrungBinh.CompareTo(sv1.DiemTrungBinh)); // Giảm dần
            }
        }


        public List<SinhVien> TimDStheoTT(int codeIndex)
        {
            List<SinhVien> listResult = new List<SinhVien>();

            foreach (SinhVien sv in this.DanhSachSV)
            {
                if (codeIndex == 0 && sv.TrangThaiSV == TrangThaiSV.ChuaThucTap)
                {
                    listResult.Add(sv);
                }
                if (codeIndex == 1 && sv.TrangThaiSV == TrangThaiSV.DangThucTap)
                {
                    listResult.Add(sv);
                }
                if (codeIndex == 2 && sv.TrangThaiSV == TrangThaiSV.KetThuc)
                {
                    listResult.Add(sv);
                }
            }
            return listResult;
        }

        
    }
}