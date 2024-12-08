using System.Text.RegularExpressions;

namespace WindowsFormsApp1.DTO
{

    internal class KiemTra
    {
        public static bool KiemTraSoDienThoai(string soDienThoai)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(soDienThoai, pattern);
        }
        public static bool KiemTraEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9]+([._%+-]?[a-zA-Z0-9]+)*@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        public static bool KiemTraChuoi(string chuoi)
        {
            if (string.IsNullOrWhiteSpace(chuoi))
                return false;
            string pattern = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẮẰẲẴẶÂẤẦẨẪẬÊẾỀỂỄỆÒÓÔÕƠỜỞỠỢÚỨỪỬỰÝýÿ\s]";
            return Regex.IsMatch(chuoi, pattern);
        }
        public static bool KiemTraDiaChi(string chuoi)
        {
            if (string.IsNullOrWhiteSpace(chuoi))
                return false;
            string pattern = @"^[a-zA-Z0-9/\.,ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẮẰẲẴẶÂẤẦẨẪẬÊẾỀỂỄỆÒÓÔÕƠỜỞỠỢÚỨỪỬỰÝýÿ\s]";
            return Regex.IsMatch(chuoi, pattern);

        }


    }
}
