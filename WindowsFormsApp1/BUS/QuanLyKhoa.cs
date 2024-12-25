using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    [Serializable]
    public class QuanLyKhoa
    {

        private List<Khoa> dsKhoa;
        public QuanLyKhoa()
        {
            dsKhoa = new List<Khoa>();
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.dsKhoa = duLieu.getDanhSachKhoa();
        }

        public List<Khoa> getDanhSachKhoa()
        {
            return dsKhoa;
        }

        public int DemMaKhoa()
        {
            HashSet<string> uniqueMaKhoa = new HashSet<string>();
            foreach (Khoa kh in this.dsKhoa)
            {
                uniqueMaKhoa.Add(kh.MaKhoa);
            }
            return uniqueMaKhoa.Count;
        }


        public Khoa findMaDs(string maDs)
        {
            foreach (Khoa kh in this.dsKhoa)
            {
                if (kh.maDsKhoa == maDs)
                {
                    return kh;
                }
            }
            return null;
        }

        public Khoa findKhoa(string maKhoa)
        {
            foreach (Khoa kh in this.dsKhoa)
            {
                if (kh.maDsKhoa == maKhoa)
                {
                    return kh;
                }
            }
            return null;
        }

        public List<Khoa> AllSearch(string search)
        {
            List<Khoa> dsFind = new List<Khoa>();    
            string needFind = search.ToLower();
            foreach(Khoa kh in this.dsKhoa)
            {
                if(kh.maDsKhoa.ToLower().Contains(needFind)||
                        kh.MaKhoa.ToLower().Contains(needFind)||
                    kh.TenKhoa.ToLower().Contains( needFind)||
                    kh.LopHoc.ToLower().Contains(needFind)||
                        kh.NamHoc.ToString().Contains(needFind)||
                    kh.SoLuongSV.ToString().Contains(needFind))
                {
                    dsFind.Add(kh);
                }
            }
            return dsFind;
        }


        public bool Them(Khoa khoa)
        {
            if (findMaDs(khoa.maDsKhoa) == null)
            {
                dsKhoa.Add(khoa);
                return true;
            }
            return false;
        }

        public bool Xoa(string maDs)
        {
            Khoa khoa = findMaDs(maDs);
            if (khoa != null)
            {
                dsKhoa.Remove(khoa);
                return true;
            }
            return false;
        }

        public bool Sua(Khoa khoa)
        {
            Khoa ketQuaTim = findMaDs(khoa.maDsKhoa);
            if (ketQuaTim != null)
            {
                ketQuaTim.MaKhoa = khoa.MaKhoa;
                ketQuaTim.TenKhoa = khoa.TenKhoa;
                ketQuaTim.LopHoc = khoa.LopHoc;
                ketQuaTim.NamHoc = khoa.NamHoc;

                return true;
            }
            return false;
        }

        

        public List<Khoa> TimDsTheoKhoa(string Khoa)
        {
            List<Khoa> danhSach = new List<Khoa>();
            foreach (Khoa kh in this.dsKhoa)
            {
                if (kh.MaKhoa == Khoa)
                {
                    danhSach.Add(kh);
                }
            }
            return danhSach;
        }

        public List<Khoa> TimDsTheoLop(string lop)
        {
            List<Khoa> danhSach = new List<Khoa>();
            foreach (Khoa kh in this.dsKhoa)
            {
                if (kh.LopHoc == lop)
                {
                    danhSach.Add(kh);
                }
            }
            return danhSach;
        }

        public Khoa TimTheoLop(string lop)
        {
            
            foreach (Khoa kh in this.dsKhoa)
            {
                if (kh.LopHoc == lop)
                {
                   return kh;
                }
            }
            return null;
        }

        public Khoa KiemTraKhoa(string khoa,string lop)
        {
            foreach (Khoa kh in this.dsKhoa)
            {
                if (kh.MaKhoa == khoa && kh.LopHoc == lop)
                {
                    return kh;
                }
            }
            return null;
        }

        public List<Khoa> TimDsTheoNam(string nam)
        {
            List<Khoa> danhSach = new List<Khoa>();
            foreach (Khoa kh in this.dsKhoa)
            {
                if (kh.NamHoc == int.Parse(nam))
                {
                    danhSach.Add(kh);
                }
            }
            return danhSach;
        }

      
    }
}
