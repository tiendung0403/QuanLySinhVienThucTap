using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GUI.CustumControl;

namespace WindowsFormsApp1.GUI.MainForm
{
    public partial class form_QuanLySinhVien : Form
    {
        bool sidepartExpant = true;
        public form_QuanLySinhVien()
        {
            InitializeComponent();
            updateSidepanel(btn_Home);
            addUserControl(homeControl1);

            studentControl1.ExitButtonClicked += ExitControl_btnExit_Click;
            teacherControl1.ExitButtonClicked += ExitControl_btnExit_Click;
            companyControl1.ExitButtonClicked += ExitControl_btnExit_Click;
            projectControl1.ExitButtonClicked += ExitControl_btnExit_Click;
            typeProjectControl1.ExitButtonClicked += ExitControl_btnExit_Click;

        }

        private void ExitControl_btnExit_Click(object sender, EventArgs e)
        {
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
            addUserControl(homeControl1);

        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Student);
            addUserControl(studentControl1);

        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Teacher);
            addUserControl(teacherControl1);

        }

        private void btn_Company_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Company);
            addUserControl(companyControl1);
        }

        private void btn_Project_Click(object sender, EventArgs e)
        {
            updateSidepanel(btn_Project);
            addUserControl(projectControl1);

        }
        private void btnTypeProject_Click(object sender, EventArgs e)
        {
            updateSidepanel(btnTypeProject);
            addUserControl(typeProjectControl1);


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
