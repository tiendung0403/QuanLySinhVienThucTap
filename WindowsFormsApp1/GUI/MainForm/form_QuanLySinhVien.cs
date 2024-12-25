using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.DTO;
using WindowsFormsApp1.GUI.CustumControl;

namespace WindowsFormsApp1.GUI.MainForm
{
    public partial class form_QuanLySinhVien : Form
    {
        private static Role roleMain;
        bool sidepartExpant = true;
        string filePath = "datasystem.bin";
        private User user ;
        public form_QuanLySinhVien(User user)
        {
            this.user = user;

            InitializeComponent();
            updateSidepanel(btn_Home);
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void updateSidepanel(Button button)
        {
            sidepanel.Height = button.Height;
            sidepanel.Top = button.Top;

            foreach (Control ctrl in panelmenubtns.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.ForeColor = Color.White;
                }
            }
            button.ForeColor = Color.Black;
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Home);
            addUserControl(new HomeControl());
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Student);
            addUserControl(new StudentControl());
        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Teacher);
            addUserControl(new TeacherControl());

        }

        private void btn_Company_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Company);
            addUserControl(new CompanyControl());
        }

        private void btn_Project_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Project);
            addUserControl(new ProjectControl());

        }

        private void btnTypeProject_Click(object sender, EventArgs e)
        {
            updateSidepanel(btnTypeProject);
            addUserControl(new TypeProjectControl());
        }

        private void btnResultProject_Click(object sender, EventArgs e)
        {
            updateSidepanel(btnResultProject);
            addUserControl(new ResultProjectControl());
        }

        private void btnResuit_Click(object sender, EventArgs e)
        {
            updateSidepanel(btnResuit);
            addUserControl(new ResultControl());
        }

        private void btn_Department_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Department);
            addUserControl(new DepartmentControl());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            updateSidepanel(btnUser);
            addUserControl(new AccountUserControl());
        }

        //private void dangnhapTK()
        //{
        //    frmLogin frmLogin = new frmLogin();
        //    if (frmLogin.ShowDialog() == DialogResult.OK)
        //    {
        //        User userFind = new QuanLyUser().Tim(frmLogin.UserName);

        //        if (userFind != null)
        //        {
        //            this.Show();
        //            txtChucVu.Text = userFind.Role.ToString();
        //            roleMain = userFind.Role;
        //            if (userFind.Role == Role.Admin)
        //            {
        //                txtChucVu.ForeColor = Color.Red;
        //                addUserControl(new HomeControl());
        //            }
        //            else
        //            {
        //                updateSidepanel(btnResultProject);
        //                addUserControl(new ResultProjectControl());
        //                btn_Home.Hide();
        //                btn_Student.Hide();
        //                btn_Teacher.Hide();
        //                btn_Company.Hide();
        //                btn_Project.Hide();
        //                btnTypeProject.Hide();
        //                btnUser.Hide();
        //                btn_Department.Hide();
        //            }
        //            txtUserName.Text = userFind.FullName;
        //        }
        //        else { MessageBox.Show("Không tìm thấy tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
        //    }
        //    else
        //    {
        //        frmLogin.Close();
        //        this.Close();
        //    }
        //}

        private void form_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            txtUserName.Text = user.FullName;
            txtUserName.ForeColor = Color.Red;
            txtChucVu.Text = user.Role.ToString();
            updateSidepanel(btn_Home);
            addUserControl(new HomeControl());
        }

        private void sidepartTime_Tick(object sender, EventArgs e)
        {
            if (sidepartExpant)
            {
                panel_listMenu.Width -= 10;
                if (panel_listMenu.Width == panel_listMenu.MinimumSize.Width)
                {
                    sidepartExpant = false;
                    sidepartTime.Stop();
                }
            }
            else
            {
                panel_listMenu.Width += 10;
                if (panel_listMenu.Width == panel_listMenu.MaximumSize.Width)
                {
                    sidepartExpant = true;
                    sidepartTime.Stop();
                }
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sidepartTime.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                bool result = TruyCapDuLieu.ghiFile(filePath);
                if (result)
                {
                    MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu tệp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {

            bool result = TruyCapDuLieu.docFile(filePath);
            if (result)
            {
                MessageBox.Show("Dữ liệu đã được tải thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể đọc tệp dữ liệu hoặc tệp không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void form_QuanLySinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            TruyCapDuLieu.ghiFile(filePath);
            this.Close();
            this.DialogResult = DialogResult.OK;   
        }
    }
}
