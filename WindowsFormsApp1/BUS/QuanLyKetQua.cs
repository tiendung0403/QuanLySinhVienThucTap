using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.BUS
{
    [Serializable]
    public class QuanLyKetQua
    {
        private List<KetQua> dsKetQua;
        public QuanLyKetQua()
        {
            dsKetQua = new List<KetQua>();
           TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            dsKetQua = duLieu.getDanhSachKetQua();
        }

        public List<KetQua> getDanhSachKetQua()
        {
            return dsKetQua;
        }

        public KetQua findKQ(string maKQ)
        {
            foreach (KetQua kt in this.dsKetQua)
            {
                if (kt.MaKQ == maKQ)
                {
                    return kt;
                }
            }
            return null;
        }

        public KetQua findDeTai(string maDT)
        {
            foreach (KetQua kt in this.dsKetQua)
            {
                if (kt.DeTai.MaDT == maDT)
                {
                    return kt;
                }
            }
            return null;
        }

        public List<KetQua> AllSearch(string textFind)
        {
            List<KetQua> result= new List<KetQua>();    
           string needFind = textFind.ToLower();
            foreach(KetQua ktd in this.dsKetQua)
            {
                if(ktd.MaKQ.ToLower().Contains(needFind)||
                    ktd.DeTai.MaDT.ToLower().Contains(needFind)||
                        ktd.SinhVien.MaSinhVien.ToLower().Contains(needFind)||
                    ktd.NhanXet.ToLower().Contains(needFind)||
                    ktd.TongDiem.ToString().Contains(needFind))
                {
                    result.Add(ktd);
                }
            }
            return result;
        }

        public bool Them(KetQua ketQua)
        {
            if (findKQ(ketQua.MaKQ) == null)
            {
                dsKetQua.Add(ketQua);
                return true;
            }
            return false;
        }

        public bool Xoa(string maKQ)
        {
            KetQua ketQua = findKQ(maKQ);
            if (ketQua != null)
            {
                dsKetQua.Remove(ketQua);
                return true;
            }
            return false;
        }

        public bool SuadanhGia(KetQua ketQua)
        {
            KetQua ketQua1 = findKQ(ketQua.MaKQ);
            if (ketQua1 != null)
            {
                ketQua1.DeTai = ketQua.DeTai;
                ketQua1.SinhVien = ketQua.SinhVien;
                ketQua1.GiaoVien = ketQua.GiaoVien;
                ketQua1.NhanXet = ketQua.NhanXet;
                ketQua1.TongDiem = ketQua.TongDiem;
                return true;
            }
            return false;
        }

        public KetQua TimKQtheoMaSV(string maSV)
        {
            foreach (KetQua ketQua in this.dsKetQua)
            {
                if (ketQua.SinhVien.MaSinhVien == maSV)
                {
                    return ketQua;
                }
            }
            return null;
        }

        
    }
}
