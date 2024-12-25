using System.Text.RegularExpressions;
using System.Net.Mail;
using System;

namespace WindowsFormsApp1.DTO
{

    internal class KiemTra
    {
        public static bool KiemTraSoDienThoai(string soDienThoai)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(soDienThoai, pattern);
        }

        //public static bool KiemTraEmail(string email)
        //{
        //    string pattern = @"^[a-zA-Z0-9]+([._%+-]?[a-zA-Z0-9]+)*@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$";
        //    return Regex.IsMatch(email, pattern);
        //}


        public static bool KiemTraEmail(string email)
        {
            email = email.Trim();
            string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z]+\.(gmail\.com|[a-zA-Z]+\.[a-zA-Z]{2,})$";
            return Regex.IsMatch(email, pattern);
        }
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        public static bool KiemTraTen(string chuoi)
        {

            if (string.IsNullOrWhiteSpace(chuoi))
                return false;

            chuoi = chuoi.Trim();
            string pattern = @"^[a-zA-ZàáảãạăằắẳẵặâầấẩẫậÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬđĐéèẻêẽẹềễếểệÉÈẺÊẼẸỀỄẾỂỆýỳỵỷỹÝỲỴỶỸúùủưũụừữứửựÚÙỦƯŨỤỪỮỨỬỰíìịỉĩÍÌỊỈĨõỏóòổốồôọớờơộỗợỡởÕỎÓÒỔỐỒÔỌỚỜƠỘỖỢỠỞ\s]+$";
            return Regex.IsMatch(chuoi, pattern);
        }
        public static bool KiemTraChuoi(string chuoi)
        {
            if (string.IsNullOrWhiteSpace(chuoi))
                return false;
            chuoi = chuoi.Trim();
            string pattern = @"^[a-zA-Z0-9]+$";

            return Regex.IsMatch(chuoi, pattern);
        }
        //public static bool KiemTraDiaChi(string chuoi)
        //{
        //    if (string.IsNullOrWhiteSpace(chuoi))
        //        return false;
        //    string pattern = @"^[a-zA-Z0-9/\.,ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẮẰẲẴẶÂẤẦẨẪẬÊẾỀỂỄỆÒÓÔÕƠỜỞỠỢÚỨỪỬỰÝýÿ\s]+$";
        //    return Regex.IsMatch(chuoi, pattern);

        //}


        public static bool KiemTraDiaChi(string chuoi)
        {
            if (string.IsNullOrWhiteSpace(chuoi))
                return false;

            string pattern = @"^[a-zA-Z0-9àáảãạăằắẳẵặâầấẩẫậÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬđĐéèẻêẽẹềễếểệÉÈẺÊẼẸỀỄẾỂỆýỳỵỷỹÝỲỴỶỸúùủưũụừữứửựÚÙỦƯŨỤỪỮỨỬỰíìịỉĩÍÌỊỈĨõỏóòổốồôọớờơộỗợỡởÕỎÓÒỔỐỒÔỌỚỜƠỘỖỢỠỞ\s/.,-]+$";

            return Regex.IsMatch(chuoi, pattern);
        }



}
}
