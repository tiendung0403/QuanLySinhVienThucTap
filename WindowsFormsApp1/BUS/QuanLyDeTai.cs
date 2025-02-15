﻿using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    [Serializable]

    internal class QuanLyDeTai
    {
        public List<DeTai> DanhSachDeTai;

        public QuanLyDeTai()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.DanhSachDeTai = duLieu.getDanhSachDeTai();
        }

        public List<DeTai> getDanhSachDeTai()
        {
            return this.DanhSachDeTai;
        }

        public int DemDT()
        {
            return this.DanhSachDeTai.Count;
        }

        public DeTai Tim(string ma)
        {
            return this.DanhSachDeTai.Find(dt => dt.MaDT == ma);
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
                ketQuaTim.TenDT = a.TenDT;
                ketQuaTim.SinhVien = a.SinhVien;
                ketQuaTim.NgayBatDau = a.NgayBatDau;
                ketQuaTim.NgayKetThuc = a.NgayKetThuc;
                ketQuaTim.LoaiDT = a.LoaiDT;
                ketQuaTim.MaCTy = a.MaCTy;
                ketQuaTim.GiaoVien = a.GiaoVien;
                
                return true;
            }
            return false;
        }
        public List<DeTai> TimKiem(string s)
        {
            return DanhSachDeTai.Where(dt => dt.TenDT.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0 ||
            dt.LoaiDT.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0 ||
            dt.MaCTy.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0 ||
            dt.MaDT.IndexOf(s, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        }

        public DeTai TimDTtheoMaSV(string maSV)
        {
            foreach (DeTai dt in this.DanhSachDeTai)
            {
                if (dt.SinhVien.MaSinhVien == maSV)
                {
                    return dt;
                }
            }
            return null;
        }


        public KetQua TimKQtheoMaDT(string maDT)
        {
            foreach(KetQua kt in new QuanLyKetQua().getDanhSachKetQua())
            {
                if (kt.DeTai.MaDT == maDT)
                {
                    return kt;
                }
            }
            return null;
        }
        

    }
}
