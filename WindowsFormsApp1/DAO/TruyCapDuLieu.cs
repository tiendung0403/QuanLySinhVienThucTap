﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    [Serializable]
    class TruyCapDuLieu
    {
        private static TruyCapDuLieu instanse = null;
        private  List<LoaiDeTai> dsLoaiDeTai;
        private  List<CongTy> dsCongTy;
        private  List<DeTai> dsDeTai;
        private  List<GiangVien> dsGiangVien;
        private  List<SinhVien> dsSinhVien;
        private List<DanhGiaDeTai> dsDanhGiaTai;
        private List<KetQua> dsKetQua;
        private List<Khoa> dsKhoa;
        private List<User> dsUser;
        private TruyCapDuLieu()
        {
            dsLoaiDeTai = new List<LoaiDeTai>();
            dsCongTy = new List<CongTy>();
            dsDeTai = new List<DeTai>();
            dsGiangVien = new List<GiangVien>();
            dsSinhVien = new List<SinhVien>();
            dsDanhGiaTai = new List<DanhGiaDeTai>();
            dsKetQua = new List<KetQua>();
            dsKhoa = new List<Khoa>();
            dsUser = new List<User>();
        }

        public static TruyCapDuLieu khoitao()
        {
            if(instanse == null)
                instanse = new TruyCapDuLieu();
            return instanse;
        }

        public List<LoaiDeTai> getDanhSachLoaiDT()
        {
            return dsLoaiDeTai;
        }
        public List<CongTy> getDanhSachCongTy()
        {
            return dsCongTy;
        }
        public List<DeTai> getDanhSachDeTai()
        {
            return dsDeTai;
        }
        public List<GiangVien> getDanhSachGiangVien()
        {
            return dsGiangVien;
        }
        public List<SinhVien> getDanhSachSinhVien()
        {
            return dsSinhVien;
        }
        public List<DanhGiaDeTai> getDanhSachDanhGia()
        {
            return dsDanhGiaTai;
        }

        public List<KetQua> getDanhSachKetQua()
        {
            return dsKetQua;
        }
        public List<Khoa> getDanhSachKhoa()
        {
            return dsKhoa;
        }

        public List<User> getDanhSachUser()
        {
            return dsUser;
        }



        public static bool docFile(string tenFile)
        {
            try
            {
                using (FileStream file = new FileStream(tenFile, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    instanse = (TruyCapDuLieu)bf.Deserialize(file);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ghiFile(string tenFile)
        {
            try
            {
                using (FileStream file = new FileStream(tenFile, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, instanse);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
