using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.GUI.CustumControl;

namespace WindowsFormsApp1.GUI.MainForm
{
    public partial class form_QuanLySinhVien : Form
    {
        bool sidepartExpant = true;
        string filePath = "datasystem.bin";
        public form_QuanLySinhVien()
        {
            InitializeComponent();
            updateSidepanel(btn_Home);
            addUserControl(new HomeControl());
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

        private void form_QuanLySinhVien_Load(object sender, EventArgs e)
        {
            TruyCapDuLieu.docFile(filePath);
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
    }
}
