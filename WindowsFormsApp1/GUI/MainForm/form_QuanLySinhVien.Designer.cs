﻿namespace WindowsFormsApp1.GUI.MainForm
{
    partial class form_QuanLySinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.Panel_InforUser = new System.Windows.Forms.Panel();
            this.btnDocFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtChucVu = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.labChucVu = new System.Windows.Forms.Label();
            this.labUserName = new System.Windows.Forms.Label();
            this.panel_listMenu = new System.Windows.Forms.Panel();
            this.panelmenubtns = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btn_Department = new System.Windows.Forms.Button();
            this.btnResuit = new System.Windows.Forms.Button();
            this.btnResultProject = new System.Windows.Forms.Button();
            this.btnTypeProject = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.btn_Project = new System.Windows.Forms.Button();
            this.btn_Company = new System.Windows.Forms.Button();
            this.btn_Teacher = new System.Windows.Forms.Button();
            this.btn_Student = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Menu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidepartTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.Panel_InforUser.SuspendLayout();
            this.panel_listMenu.SuspendLayout();
            this.panelmenubtns.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelContainer);
            this.panel1.Controls.Add(this.Panel_InforUser);
            this.panel1.Controls.Add(this.panel_listMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 820);
            this.panel1.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(300, 112);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1092, 708);
            this.panelContainer.TabIndex = 2;
            // 
            // Panel_InforUser
            // 
            this.Panel_InforUser.BackColor = System.Drawing.Color.Navy;
            this.Panel_InforUser.Controls.Add(this.btnDocFile);
            this.Panel_InforUser.Controls.Add(this.btnSave);
            this.Panel_InforUser.Controls.Add(this.txtChucVu);
            this.Panel_InforUser.Controls.Add(this.txtUserName);
            this.Panel_InforUser.Controls.Add(this.labChucVu);
            this.Panel_InforUser.Controls.Add(this.labUserName);
            this.Panel_InforUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_InforUser.Location = new System.Drawing.Point(300, 0);
            this.Panel_InforUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panel_InforUser.Name = "Panel_InforUser";
            this.Panel_InforUser.Size = new System.Drawing.Size(1092, 112);
            this.Panel_InforUser.TabIndex = 1;
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDocFile.FlatAppearance.BorderSize = 0;
            this.btnDocFile.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDocFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDocFile.Image = global::WindowsFormsApp1.Properties.Resources.icons8_print_file_32;
            this.btnDocFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocFile.Location = new System.Drawing.Point(791, 32);
            this.btnDocFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(148, 48);
            this.btnDocFile.TabIndex = 14;
            this.btnDocFile.Text = "   Đọc File";
            this.btnDocFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocFile.UseVisualStyleBackColor = false;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Image = global::WindowsFormsApp1.Properties.Resources.icons8_save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(647, 32);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 48);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "  Ghi";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtChucVu
            // 
            this.txtChucVu.AutoSize = true;
            this.txtChucVu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChucVu.ForeColor = System.Drawing.Color.White;
            this.txtChucVu.Location = new System.Drawing.Point(147, 64);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(125, 20);
            this.txtChucVu.TabIndex = 12;
            this.txtChucVu.Text = "SuperAdmin";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(150, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(70, 20);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.Text = "Admin";
            // 
            // labChucVu
            // 
            this.labChucVu.AutoSize = true;
            this.labChucVu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labChucVu.ForeColor = System.Drawing.Color.White;
            this.labChucVu.Location = new System.Drawing.Point(19, 64);
            this.labChucVu.Name = "labChucVu";
            this.labChucVu.Size = new System.Drawing.Size(98, 20);
            this.labChucVu.TabIndex = 10;
            this.labChucVu.Text = "Chức vụ :";
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labUserName.ForeColor = System.Drawing.Color.White;
            this.labUserName.Location = new System.Drawing.Point(19, 28);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(117, 20);
            this.labUserName.TabIndex = 8;
            this.labUserName.Text = "Full Name :";
            // 
            // panel_listMenu
            // 
            this.panel_listMenu.BackColor = System.Drawing.Color.Navy;
            this.panel_listMenu.Controls.Add(this.panelmenubtns);
            this.panel_listMenu.Controls.Add(this.panel4);
            this.panel_listMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_listMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_listMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_listMenu.MaximumSize = new System.Drawing.Size(300, 0);
            this.panel_listMenu.MinimumSize = new System.Drawing.Size(60, 0);
            this.panel_listMenu.Name = "panel_listMenu";
            this.panel_listMenu.Size = new System.Drawing.Size(300, 820);
            this.panel_listMenu.TabIndex = 0;
            // 
            // panelmenubtns
            // 
            this.panelmenubtns.BackColor = System.Drawing.Color.Navy;
            this.panelmenubtns.Controls.Add(this.btnUser);
            this.panelmenubtns.Controls.Add(this.btn_Department);
            this.panelmenubtns.Controls.Add(this.btnResuit);
            this.panelmenubtns.Controls.Add(this.btnResultProject);
            this.panelmenubtns.Controls.Add(this.btnTypeProject);
            this.panelmenubtns.Controls.Add(this.sidepanel);
            this.panelmenubtns.Controls.Add(this.btn_Project);
            this.panelmenubtns.Controls.Add(this.btn_Company);
            this.panelmenubtns.Controls.Add(this.btn_Teacher);
            this.panelmenubtns.Controls.Add(this.btn_Student);
            this.panelmenubtns.Controls.Add(this.btn_Home);
            this.panelmenubtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmenubtns.Location = new System.Drawing.Point(0, 182);
            this.panelmenubtns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelmenubtns.Name = "panelmenubtns";
            this.panelmenubtns.Size = new System.Drawing.Size(300, 638);
            this.panelmenubtns.TabIndex = 5;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::WindowsFormsApp1.Properties.Resources.icons8_user_32;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(9, 540);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(291, 60);
            this.btnUser.TabIndex = 10;
            this.btnUser.Text = "      Tài khoản";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btn_Department
            // 
            this.btn_Department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Department.FlatAppearance.BorderSize = 0;
            this.btn_Department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Department.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Department.ForeColor = System.Drawing.Color.White;
            this.btn_Department.Image = global::WindowsFormsApp1.Properties.Resources.icons8_department_32;
            this.btn_Department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Department.Location = new System.Drawing.Point(9, 60);
            this.btn_Department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Department.Name = "btn_Department";
            this.btn_Department.Size = new System.Drawing.Size(291, 60);
            this.btn_Department.TabIndex = 9;
            this.btn_Department.Text = "      Khoa";
            this.btn_Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Department.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Department.UseVisualStyleBackColor = false;
            this.btn_Department.Click += new System.EventHandler(this.btn_Department_Click);
            // 
            // btnResuit
            // 
            this.btnResuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnResuit.FlatAppearance.BorderSize = 0;
            this.btnResuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResuit.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnResuit.ForeColor = System.Drawing.Color.White;
            this.btnResuit.Image = global::WindowsFormsApp1.Properties.Resources.icons8_result_32;
            this.btnResuit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResuit.Location = new System.Drawing.Point(9, 420);
            this.btnResuit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResuit.Name = "btnResuit";
            this.btnResuit.Size = new System.Drawing.Size(291, 60);
            this.btnResuit.TabIndex = 8;
            this.btnResuit.Text = "      Kết Quả";
            this.btnResuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResuit.UseVisualStyleBackColor = false;
            this.btnResuit.Click += new System.EventHandler(this.btnResuit_Click);
            // 
            // btnResultProject
            // 
            this.btnResultProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnResultProject.FlatAppearance.BorderSize = 0;
            this.btnResultProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultProject.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnResultProject.ForeColor = System.Drawing.Color.White;
            this.btnResultProject.Image = global::WindowsFormsApp1.Properties.Resources.icons8_circle_chart_32;
            this.btnResultProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultProject.Location = new System.Drawing.Point(9, 360);
            this.btnResultProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResultProject.Name = "btnResultProject";
            this.btnResultProject.Size = new System.Drawing.Size(291, 60);
            this.btnResultProject.TabIndex = 7;
            this.btnResultProject.Text = "      Đánh giá";
            this.btnResultProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResultProject.UseVisualStyleBackColor = false;
            this.btnResultProject.Click += new System.EventHandler(this.btnResultProject_Click);
            // 
            // btnTypeProject
            // 
            this.btnTypeProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTypeProject.FlatAppearance.BorderSize = 0;
            this.btnTypeProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeProject.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTypeProject.ForeColor = System.Drawing.Color.White;
            this.btnTypeProject.Image = global::WindowsFormsApp1.Properties.Resources.icons8_diversity_32;
            this.btnTypeProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypeProject.Location = new System.Drawing.Point(9, 480);
            this.btnTypeProject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTypeProject.Name = "btnTypeProject";
            this.btnTypeProject.Size = new System.Drawing.Size(291, 60);
            this.btnTypeProject.TabIndex = 5;
            this.btnTypeProject.Text = "      Loại đề tài";
            this.btnTypeProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypeProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTypeProject.UseVisualStyleBackColor = false;
            this.btnTypeProject.Click += new System.EventHandler(this.btnTypeProject_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidepanel.BackColor = System.Drawing.Color.White;
            this.sidepanel.Location = new System.Drawing.Point(3, -1);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(5, 60);
            this.sidepanel.TabIndex = 2;
            // 
            // btn_Project
            // 
            this.btn_Project.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Project.FlatAppearance.BorderSize = 0;
            this.btn_Project.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Project.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Project.ForeColor = System.Drawing.Color.White;
            this.btn_Project.Image = global::WindowsFormsApp1.Properties.Resources.icons8_projects_32;
            this.btn_Project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Project.Location = new System.Drawing.Point(9, 300);
            this.btn_Project.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Project.Name = "btn_Project";
            this.btn_Project.Size = new System.Drawing.Size(291, 60);
            this.btn_Project.TabIndex = 4;
            this.btn_Project.Text = "      Đề tài";
            this.btn_Project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Project.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Project.UseVisualStyleBackColor = false;
            this.btn_Project.Click += new System.EventHandler(this.btn_Project_Click);
            // 
            // btn_Company
            // 
            this.btn_Company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Company.FlatAppearance.BorderSize = 0;
            this.btn_Company.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Company.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Company.ForeColor = System.Drawing.Color.White;
            this.btn_Company.Image = global::WindowsFormsApp1.Properties.Resources.icons8_company_32;
            this.btn_Company.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Company.Location = new System.Drawing.Point(9, 240);
            this.btn_Company.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Company.Name = "btn_Company";
            this.btn_Company.Size = new System.Drawing.Size(291, 60);
            this.btn_Company.TabIndex = 3;
            this.btn_Company.Text = "      Công ty";
            this.btn_Company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Company.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Company.UseVisualStyleBackColor = false;
            this.btn_Company.Click += new System.EventHandler(this.btn_Company_Click);
            // 
            // btn_Teacher
            // 
            this.btn_Teacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Teacher.FlatAppearance.BorderSize = 0;
            this.btn_Teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Teacher.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Teacher.ForeColor = System.Drawing.Color.White;
            this.btn_Teacher.Image = global::WindowsFormsApp1.Properties.Resources.icons8_teacher_32;
            this.btn_Teacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Teacher.Location = new System.Drawing.Point(9, 180);
            this.btn_Teacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Teacher.Name = "btn_Teacher";
            this.btn_Teacher.Size = new System.Drawing.Size(291, 60);
            this.btn_Teacher.TabIndex = 2;
            this.btn_Teacher.Text = "      Giảng viên";
            this.btn_Teacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Teacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Teacher.UseVisualStyleBackColor = false;
            this.btn_Teacher.Click += new System.EventHandler(this.btn_Teacher_Click);
            // 
            // btn_Student
            // 
            this.btn_Student.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Student.FlatAppearance.BorderSize = 0;
            this.btn_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Student.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Student.ForeColor = System.Drawing.Color.White;
            this.btn_Student.Image = global::WindowsFormsApp1.Properties.Resources.icons8_student_male_32;
            this.btn_Student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Student.Location = new System.Drawing.Point(9, 120);
            this.btn_Student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Size = new System.Drawing.Size(291, 60);
            this.btn_Student.TabIndex = 1;
            this.btn_Student.Text = "      Sinh viên";
            this.btn_Student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Student.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Student.UseVisualStyleBackColor = false;
            this.btn_Student.Click += new System.EventHandler(this.btn_student_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Image = global::WindowsFormsApp1.Properties.Resources.icons8_home_32;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(9, 0);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(291, 60);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.Text = "      Trang chủ";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.Controls.Add(this.btn_Menu);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 182);
            this.panel4.TabIndex = 4;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Image = global::WindowsFormsApp1.Properties.Resources.icons8_menu_squared_48;
            this.btn_Menu.Location = new System.Drawing.Point(-1, 0);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(48, 48);
            this.btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_Menu.TabIndex = 2;
            this.btn_Menu.TabStop = false;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Logo_STU;
            this.pictureBox1.Location = new System.Drawing.Point(3, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sinh viên thực tập";
            // 
            // sidepartTime
            // 
            this.sidepartTime.Interval = 10;
            this.sidepartTime.Tick += new System.EventHandler(this.sidepartTime_Tick);
            // 
            // form_QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 820);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "form_QuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ứng dụng quản lý sinh viên thực tập";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_QuanLySinhVien_FormClosed);
            this.Load += new System.EventHandler(this.form_QuanLySinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.Panel_InforUser.ResumeLayout(false);
            this.Panel_InforUser.PerformLayout();
            this.panel_listMenu.ResumeLayout(false);
            this.panelmenubtns.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_listMenu;
        private System.Windows.Forms.Panel Panel_InforUser;
        private System.Windows.Forms.Timer sidepartTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btn_Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelmenubtns;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button btn_Project;
        private System.Windows.Forms.Button btn_Company;
        private System.Windows.Forms.Button btn_Teacher;
        private System.Windows.Forms.Button btn_Student;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.Label labChucVu;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label txtChucVu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnTypeProject;
        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnResultProject;
        private System.Windows.Forms.Button btnResuit;
        private System.Windows.Forms.Button btn_Department;
        private System.Windows.Forms.Button btnUser;
    }
}