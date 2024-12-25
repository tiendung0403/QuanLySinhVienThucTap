using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1.GUI.MainForm
{
    public partial class frmLogin : Form
    {
        private QuanLyUser quanLy;

        string filePath = "datasystem.bin";

        public frmLogin()
        {
            TruyCapDuLieu.docFile(filePath);
            InitializeComponent();
            quanLy = new QuanLyUser();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSign frmSign = new frmSign();
            frmSign.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string password = txtPass.Text;
            if (userName == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (quanLy.CheckLogin(userName, password))
            {
                MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                form_QuanLySinhVien form_QuanLySinhVien = new form_QuanLySinhVien(quanLy.Tim(userName));
                txtUser.Clear();
                txtPass.Clear();
                this.Hide();
                if (form_QuanLySinhVien.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }

        private void txtForgetPass_Click(object sender, EventArgs e)
        {
            txtForgetPass.ForeColor = Color.Red;
            if(quanLy.QuenMatKhau(txtUser.Text))
            {
                MessageBox.Show("Mật khẩu đã được gửi về mail của bạn");
            }
            else
            {
                MessageBox.Show("Tên tài khoản không tồn tại vui lòng kiểm tra lại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.PasswordChar = '*';
            }
            else txtPass.PasswordChar = '\0';
        }
    }
}
