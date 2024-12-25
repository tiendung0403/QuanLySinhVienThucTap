using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    public enum Role
    {
        Admin
    }
    [Serializable]
    public class User
    {
        public string UserName { get; set; }
        public string FullName { get; set; }    
        public string Password { get; set; }
        public string Email { get; set; }

        public Role Role { get; set; }
        public string Key { get; set; }

        public User()
        {
        }
        public User(string userName, string fullName, string password, Role role, string email,string key)
        {
            if (!KiemTra.KiemTraTen(fullName))
            {
                throw new AggregateException("Tên đầy đủ không hợp lệ");
            }
            else FullName = fullName;

            Role = role;
            if (!KiemTra.IsEmail(email))
            {
                throw new AggregateException("Email không hợp lệ");
            }
            else Email = email;

            if (!KiemTra.KiemTraChuoi(userName))
            {
                throw new AggregateException("Tên đăng nhập không hợp lệ");
            }
            else UserName = userName;

            Password = password;

            if (!KiemTra.KiemTraChuoi(key))
            {
                throw new AggregateException("Key không chứa kí tự đặc biệt");
            }
            else Key = key;
        }

        public User(string userName, string fullName, string password, Role role, string email)
        {
            if (!KiemTra.KiemTraTen(fullName))
            {
                throw new AggregateException("Tên đầy đủ không hợp lệ");
            }
            else FullName = fullName;

            Role = role;
            if (!KiemTra.IsEmail(email))
            {
                throw new AggregateException("Email không hợp lệ");
            }
            else Email = email;

            if (!KiemTra.KiemTraChuoi(userName))
            {
                throw new AggregateException("Tên đăng nhập không hợp lệ");
            }
            else UserName = userName;

            if (!KiemTra.KiemTraChuoi(password))
            {
                throw new AggregateException("Mật khẩu không hợp lệ");
            }
            else Password = password;
        }
    }
}
