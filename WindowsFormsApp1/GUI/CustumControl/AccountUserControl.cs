using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.GUI.CustumControl
{
    public partial class AccountUserControl : UserControl
    {
        private QuanLyUser quanly;

        public AccountUserControl()
        {
            InitializeComponent();
            quanly = new QuanLyUser();
            LoadUserData(dgvTaiKhoan, quanly.GetDS());
        }

        private void btnaAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User newUser = new User(txtUser.Text, txtFullName.Text, txtPass.Text, DTO.Role.Admin, txtEmail.Text);
                if (quanly.Them(newUser))
                {
                    MessageBox.Show("Thêm tài khoản thành công ! ");
                    LoadUserData(dgvTaiKhoan, quanly.GetDS());
                }
                else
                {
                    MessageBox.Show("Thêm không thành công. Tên đăng nhập bị trùng ", "Thồng báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception err)
            {
                MessageBox.Show(err.Message, "Thồng báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            try
            {
                User updatedUser = new User(txtUser.Text, txtFullName.Text, txtPass.Text, DTO.Role.Admin, txtEmail.Text);
                if (quanly.Sua(updatedUser))
                {
                    MessageBox.Show("cập nhật thành công !");
                    LoadUserData(dgvTaiKhoan, quanly.GetDS());
                }
                else
                {
                    MessageBox.Show("cập nhật không thành công.");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Thông báo",MessageBoxButtons.OK);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtUser.Enabled = true;

            if (quanly.Xoa(txtUser.Text))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                LoadUserData(dgvTaiKhoan, quanly.GetDS());
            }
            else
            {
                MessageBox.Show("Xóa tài khoản không thành công.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtFullName.Clear();
            txtPass.Clear();
            cmboRole.SelectedIndex = -1;
        }

        private void dgvDanhSachDeTai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && e.RowIndex < dgvTaiKhoan.RowCount - 1 )
            {
                User userFind = quanly.Tim(dgvTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString());
                if (userFind != null) {
                    txtUser.Text = userFind.UserName;
                    txtFullName.Text = userFind.FullName;
                    txtPass.Text = userFind.Password;
                    txtEmail.Text = userFind.Email;
                    cmboRole.Text = userFind.Role.ToString();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            User user = quanly.Tim(txtTimkiem.Text);
            if (user != null)
            {
                txtUser.Text = user.UserName;
                txtFullName.Text = user.FullName;
                txtPass.Text = user.Password;
                cmboRole.SelectedItem = user.Role;
            }
            else
            {
                MessageBox.Show("Không tìm thấy user.");
            }
        }

        private void LoadUserData(DataGridView dgv,List<User>ds)
        {
            foreach(User a in ds)
            {
                dgv.Rows.Add(a.FullName,a.Role, a.UserName,a.Email, a.Password);
            }
        }
    }


}
