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
            sidepanel.Height = btn_Home.Height;
            sidepanel.Top = btn_Home.Top;
            addUserControl(new HomeControl());

        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_Home.Height;
            sidepanel.Top = btn_Home.Top;
            addUserControl(new HomeControl());


        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_Student.Height;
            sidepanel.Top = btn_Student.Top;
            addUserControl(new StudentControl());
        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_Teacher.Height;
            sidepanel.Top = btn_Teacher.Top;

        }

        private void btn_Company_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_Company.Height;
            sidepanel.Top = btn_Company.Top;

        }

        private void btn_Project_Click(object sender, EventArgs e)
        {
            sidepanel.Top = btn_Project.Top;
            sidepanel.Height = btn_Project.Height;
        }

        private void Form2_Load(object sender, EventArgs e)
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
