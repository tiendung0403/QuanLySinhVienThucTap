using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.MainForm
{
    public partial class frmSign : Form
    {
        private QuanLyUser quanLy;

        public frmSign()
        {
            InitializeComponent();
            quanLy = new QuanLyUser();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            try
            {
                string key = RC4.GenerateRandomString(10);
                if (!KiemTra.KiemTraChuoi(txtPass.Text))
                {
                    MessageBox.Show("Mật khẩu không chứa Kí tự đặc biệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string password = RC4.Encrypt(key, txtPass.Text);

                User addUser = new User(txtUser.Text, txtFullName.Text, password, Role.Admin, txtEmail.Text,key);
                if (quanLy.Tim(txtUser.Text) != null)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại");
                    return;
                }
                else
                {
                    quanLy.Them(addUser);
                    MessageBox.Show("Đăng ký thành công");
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông báo", MessageBoxButtons.OK);
            }
      
        }

        private void txtSign_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
