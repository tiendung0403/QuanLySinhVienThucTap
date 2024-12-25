using System;
using System.Collections.Generic;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace WindowsFormsApp1.BUS
{
    [Serializable]
    public class QuanLyUser
    {
        private List<User> dsUser;

        public QuanLyUser()
        {
            this.dsUser = TruyCapDuLieu.khoitao().getDanhSachUser();
        }

        public List<User> GetDS()
        {
            return this.dsUser;
        }

        public User Tim(string userName)
        {
           foreach(User us in this.dsUser)
            {
                if (us.UserName == userName)
                {
                    return us;
                }
            }
            return null;
        }

        public bool CheckLogin(string userName, string password)
        {
            foreach (User user in this.dsUser)
            {
                if (user.UserName == userName && RC4.Decrypt(user.Key,user.Password) == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Them(User user)
        {
            if (Tim(user.UserName) == null)
            {
                this.dsUser.Add(user);
                return true;
            }
            return false;
        }

        public bool Xoa(string userName)
        {
            var user = Tim(userName);
            if (user != null)
            {
                this.dsUser.Remove(user);
                return true;
            }
            return false;
        }

        public bool Sua(User user)
        {
            User ketQuaTim = Tim(user.UserName);
            if (ketQuaTim != null)
            {
                ketQuaTim.FullName = user.FullName;
                ketQuaTim.Password = user.Password;
                ketQuaTim.Email = user.Email;
                ketQuaTim.Role = user.Role;
                return true;
            }
            return false;
        }
        
        public bool QuenMatKhau(string userName)
        {
            User user = Tim(userName);
            if (user != null)
            {
                string subject = "Quên mật khẩu";
                string body = $"Xin chào {user.FullName},\n\nMật khẩu của bạn là: {RC4.Decrypt(user.Key, user.Password)}\n\nTrân trọng,\nĐội ngũ hỗ trợ.";
                return PushMail.GuiEmail(user.Email, subject, body);
            }
            return false;
        }
    }
}
