using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CustumControl;

namespace WindowsFormsApp1
{
    public partial class form_QuanLySinhVien : Form
    {
        bool sidepartExpant = true;
        public form_QuanLySinhVien()
        {
            InitializeComponent();
            updateSidepanel(btn_Home);
            addUserControl(homeControl1);

        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }
        public void updateSidepanel(Button button)
        {
            sidepanel.Height = button.Height;
            sidepanel.Top = button.Top;

        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Home);
            addUserControl(homeControl1);
            //btn_Home.ForeColor = Color.Black;


        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Student);
            addUserControl(studentControl1);
            //btn_Student.ForeColor = Color.Black;

        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Teacher);
            addUserControl(teacherControl1);
           // btn_Teacher.ForeColor = Color.Black;

        }

        private void btn_Company_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Company);
            addUserControl(companyControl1);
            //btn_Company.ForeColor = Color.Black;


        }

        private void btn_Project_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Project);
            addUserControl(projectControl1);
           // btn_Project.ForeColor = Color.Black;

        }
        private void btnTypeProject_Click(object sender, EventArgs e)
        {
            updateSidepanel(btnTypeProject);
            addUserControl(typeProjectControl1);
            //btnTypeProject.ForeColor = Color.Black;


        }

        private void form_QuanLySinhVien_Load(object sender, EventArgs e)
        {

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

    }
}
