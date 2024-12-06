using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.BLL
{
    internal class QuanLyCongTy
    {
        public List<CongTy> DanhsachCTy { get; set; }

        public QuanLyCongTy()
        {
            TruyCapDuLieu duLieu = TruyCapDuLieu.khoitao();
            this.DanhsachCTy = duLieu.getDanhSachCongTy();
        }

        public List<CongTy> getDanhSachCongTy()
        {
            return this.DanhsachCTy;
        }

        public CongTy Tim(string ma)
        {
            return DanhsachCTy.Find(cty => cty.MaCongTy == ma);
        }

        public bool Them(CongTy a)
        {
            if (Tim(a.MaCongTy) == null)
            {
                DanhsachCTy.Add(a);
                return true;
            }
            return false;
        }

        public bool Xoa(string ma)
        {
            var cty = Tim(ma);
            if (cty != null)
            {
                DanhsachCTy.Remove(cty);
                return true;
            }
            return false;
        }

        public bool Sua(CongTy a)
        {
            CongTy ketQuaTim = Tim(a.MaCongTy); 
            if (ketQuaTim != null)
            {
                ketQuaTim.MaCongTy = a.MaCongTy;
                ketQuaTim.TenCongTy = a.TenCongTy;
                ketQuaTim.TenVietTat = a.TenVietTat;
                ketQuaTim.DiaChi = a.DiaChi;
                ketQuaTim.SoDienThoai = a.SoDienThoai;
                ketQuaTim.Email = a.Email;
                return true; 
            }
            return false;
        }
    }
}
