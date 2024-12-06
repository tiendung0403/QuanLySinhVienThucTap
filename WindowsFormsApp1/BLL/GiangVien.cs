using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    [Serializable]

    internal class GiangVien
    {
        public string MaGiangVien { get; set; }   
        public string HoTen { get; set; }       
        public string GioiTinh { get; set; }    
        public DateTime NgaySinh { get; set; }  
        public string ChucVu { get; set; }       
        public string Email { get; set; }        
        public string SoDienThoai { get; set; }  

        public GiangVien() { }

        public GiangVien(string maGiangVien, string hoTen, string gioiTinh, DateTime ngaySinh, string chucVu, string email, string soDienThoai)
        {
            MaGiangVien = maGiangVien;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            ChucVu = chucVu;
            Email = email;
            SoDienThoai = soDienThoai;
        }
    }
}

