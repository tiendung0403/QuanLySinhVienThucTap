﻿using System;

namespace WindowsFormsApp1.GUI.CustumControl
{
    partial class StudentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBThaoTac = new System.Windows.Forms.GroupBox();
            this.cmboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.btnDetailStudent = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupB_ChucNang = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.cmboKhoa = new System.Windows.Forms.ComboBox();
            this.cmboLop = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmboChonLop = new System.Windows.Forms.ComboBox();
            this.comboChonKhoa = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch_Khoa = new System.Windows.Forms.Button();
            this.btnSearh_Lop = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtGioitinh = new System.Windows.Forms.ComboBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDSSinhvien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBThaoTac.SuspendLayout();
            this.groupB_ChucNang.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.groupBThaoTac);
            this.panel2.Controls.Add(this.groupB_ChucNang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1529, 167);
            this.panel2.TabIndex = 1;
            // 
            // groupBThaoTac
            // 
            this.groupBThaoTac.Controls.Add(this.cmboLocTrangThai);
            this.groupBThaoTac.Controls.Add(this.btnDetailStudent);
            this.groupBThaoTac.Controls.Add(this.btnReset);
            this.groupBThaoTac.Controls.Add(this.btnDelete);
            this.groupBThaoTac.Controls.Add(this.btnFix);
            this.groupBThaoTac.Controls.Add(this.btnAdd);
            this.groupBThaoTac.Location = new System.Drawing.Point(3, 82);
            this.groupBThaoTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBThaoTac.Name = "groupBThaoTac";
            this.groupBThaoTac.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBThaoTac.Size = new System.Drawing.Size(1479, 82);
            this.groupBThaoTac.TabIndex = 2;
            this.groupBThaoTac.TabStop = false;
            this.groupBThaoTac.Text = "Thao tác";
            // 
            // cmboLocTrangThai
            // 
            this.cmboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboLocTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold);
            this.cmboLocTrangThai.Items.AddRange(new object[] {
            "Chưa thực tập",
            "Đang thực tập",
            "Kết thúc thực tập"});
            this.cmboLocTrangThai.Location = new System.Drawing.Point(1035, 25);
            this.cmboLocTrangThai.Name = "cmboLocTrangThai";
            this.cmboLocTrangThai.Size = new System.Drawing.Size(249, 36);
            this.cmboLocTrangThai.TabIndex = 38;
            this.cmboLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.cmboLocTrangThai_SelectedIndexChanged);
            // 
            // btnDetailStudent
            // 
            this.btnDetailStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDetailStudent.FlatAppearance.BorderSize = 0;
            this.btnDetailStudent.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDetailStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDetailStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailStudent.Location = new System.Drawing.Point(859, 21);
            this.btnDetailStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetailStudent.Name = "btnDetailStudent";
            this.btnDetailStudent.Size = new System.Drawing.Size(134, 48);
            this.btnDetailStudent.TabIndex = 5;
            this.btnDetailStudent.Text = "   Xem chi tiết ";
            this.btnDetailStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetailStudent.UseVisualStyleBackColor = false;
            this.btnDetailStudent.Click += new System.EventHandler(this.btnDetailStudent_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Turquoise;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Image = global::WindowsFormsApp1.Properties.Resources.icons8_reset_32;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(638, 21);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 48);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "  Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Image = global::WindowsFormsApp1.Properties.Resources.icons8_delete_32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(445, 21);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 48);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "  Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFix.FlatAppearance.BorderSize = 0;
            this.btnFix.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFix.Image = global::WindowsFormsApp1.Properties.Resources.icons8_fix_32;
            this.btnFix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFix.Location = new System.Drawing.Point(259, 21);
            this.btnFix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(126, 48);
            this.btnFix.TabIndex = 1;
            this.btnFix.Text = "   Sửa";
            this.btnFix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Image = global::WindowsFormsApp1.Properties.Resources.icons8_addition_32__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(73, 21);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 48);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "  Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupB_ChucNang
            // 
            this.groupB_ChucNang.Controls.Add(this.btn_Search);
            this.groupB_ChucNang.Controls.Add(this.txtTimkiem);
            this.groupB_ChucNang.Location = new System.Drawing.Point(3, 4);
            this.groupB_ChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupB_ChucNang.Name = "groupB_ChucNang";
            this.groupB_ChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupB_ChucNang.Size = new System.Drawing.Size(1479, 71);
            this.groupB_ChucNang.TabIndex = 0;
            this.groupB_ChucNang.TabStop = false;
            this.groupB_ChucNang.Text = "Chức năng";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Search.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_32;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(301, 19);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(155, 46);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimkiem.Location = new System.Drawing.Point(36, 19);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(259, 46);
            this.txtTimkiem.TabIndex = 0;
            this.txtTimkiem.Tag = "";
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // cmboKhoa
            // 
            this.cmboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboKhoa.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.cmboKhoa.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmboKhoa.Location = new System.Drawing.Point(28, 141);
            this.cmboKhoa.Name = "cmboKhoa";
            this.cmboKhoa.Size = new System.Drawing.Size(202, 39);
            this.cmboKhoa.TabIndex = 32;
            // 
            // cmboLop
            // 
            this.cmboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboLop.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.cmboLop.Location = new System.Drawing.Point(26, 58);
            this.cmboLop.Name = "cmboLop";
            this.cmboLop.Size = new System.Drawing.Size(204, 39);
            this.cmboLop.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dgvDSSinhvien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1529, 618);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.cmboChonLop);
            this.groupBox1.Controls.Add(this.comboChonKhoa);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateNgaySinh);
            this.groupBox1.Controls.Add(this.txtGioitinh);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1478, 223);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin sinh viên";
            // 
            // cmboChonLop
            // 
            this.cmboChonLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboChonLop.Location = new System.Drawing.Point(651, 159);
            this.cmboChonLop.Name = "cmboChonLop";
            this.cmboChonLop.Size = new System.Drawing.Size(196, 28);
            this.cmboChonLop.TabIndex = 37;
            // 
            // comboChonKhoa
            // 
            this.comboChonKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboChonKhoa.Location = new System.Drawing.Point(651, 117);
            this.comboChonKhoa.Name = "comboChonKhoa";
            this.comboChonKhoa.Size = new System.Drawing.Size(196, 28);
            this.comboChonKhoa.TabIndex = 36;
            this.comboChonKhoa.SelectedIndexChanged += new System.EventHandler(this.comboChonKhoa_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(542, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Khoa";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSearch_Khoa);
            this.groupBox2.Controls.Add(this.btnSearh_Lop);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmboLop);
            this.groupBox2.Controls.Add(this.cmboKhoa);
            this.groupBox2.Location = new System.Drawing.Point(990, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 190);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc thông tin";
            // 
            // btnSearch_Khoa
            // 
            this.btnSearch_Khoa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch_Khoa.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_32;
            this.btnSearch_Khoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Khoa.Location = new System.Drawing.Point(275, 134);
            this.btnSearch_Khoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch_Khoa.Name = "btnSearch_Khoa";
            this.btnSearch_Khoa.Size = new System.Drawing.Size(155, 46);
            this.btnSearch_Khoa.TabIndex = 37;
            this.btnSearch_Khoa.Text = "Lọc khoa";
            this.btnSearch_Khoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Khoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch_Khoa.UseVisualStyleBackColor = true;
            this.btnSearch_Khoa.Click += new System.EventHandler(this.btnSearch_Khoa_Click);
            // 
            // btnSearh_Lop
            // 
            this.btnSearh_Lop.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearh_Lop.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_32;
            this.btnSearh_Lop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearh_Lop.Location = new System.Drawing.Point(275, 53);
            this.btnSearh_Lop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearh_Lop.Name = "btnSearh_Lop";
            this.btnSearh_Lop.Size = new System.Drawing.Size(155, 46);
            this.btnSearh_Lop.TabIndex = 2;
            this.btnSearh_Lop.Text = "Lọc lớp";
            this.btnSearh_Lop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearh_Lop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearh_Lop.UseVisualStyleBackColor = true;
            this.btnSearh_Lop.Click += new System.EventHandler(this.btnSearh_Lop_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Lọc theo khoa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 35;
            this.label8.Text = "Lọc theo lớp";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(651, 71);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(274, 28);
            this.txtSDT.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(651, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 28);
            this.txtEmail.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Lớp học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(542, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(542, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Email";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaySinh.Location = new System.Drawing.Point(228, 161);
            this.dateNgaySinh.MaxDate = new System.DateTime(2024, 12, 25, 15, 17, 35, 6);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(196, 28);
            this.dateNgaySinh.TabIndex = 23;
            this.dateNgaySinh.Value = new System.DateTime(2024, 12, 25, 15, 17, 35, 6);
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGioitinh.Location = new System.Drawing.Point(228, 117);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(196, 28);
            this.txtGioitinh.TabIndex = 22;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(228, 73);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(279, 28);
            this.txtHoten.TabIndex = 21;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(228, 34);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(279, 28);
            this.txtMa.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Họ tên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sinh viên";
            // 
            // dgvDSSinhvien
            // 
            this.dgvDSSinhvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSSinhvien.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSSinhvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Khoa,
            this.Column8,
            this.TrangThaiSV,
            this.Column7});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSSinhvien.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSSinhvien.Location = new System.Drawing.Point(47, 60);
            this.dgvDSSinhvien.Name = "dgvDSSinhvien";
            this.dgvDSSinhvien.RowHeadersWidth = 51;
            this.dgvDSSinhvien.RowTemplate.Height = 24;
            this.dgvDSSinhvien.Size = new System.Drawing.Size(1479, 262);
            this.dgvDSSinhvien.TabIndex = 16;
            this.dgvDSSinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSinhvien_CellClick);
            this.dgvDSSinhvien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDSSinhvien_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(498, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 45);
            this.label2.TabIndex = 15;
            this.label2.Text = "Danh sách sinh viên";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSinhVien";
            this.Column1.HeaderText = "Mã sinh viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 161;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 102;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Giới tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 123;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 134;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 94;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SoDienThoai";
            this.Column6.HeaderText = "Số điện thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 164;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            this.Khoa.Width = 91;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Lop";
            this.Column8.HeaderText = "Lớp";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 78;
            // 
            // TrangThaiSV
            // 
            this.TrangThaiSV.DataPropertyName = "TrangThaiSV";
            this.TrangThaiSV.HeaderText = "Trang thái ";
            this.TrangThaiSV.MinimumWidth = 6;
            this.TrangThaiSV.Name = "TrangThaiSV";
            this.TrangThaiSV.ReadOnly = true;
            this.TrangThaiSV.Width = 141;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Kết quả thực tập";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 151;
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(1529, 840);
            this.Load += new System.EventHandler(this.StudentControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBThaoTac.ResumeLayout(false);
            this.groupB_ChucNang.ResumeLayout(false);
            this.groupB_ChucNang.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupB_ChucNang;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox groupBThaoTac;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSSinhvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.ComboBox txtGioitinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboKhoa;
        private System.Windows.Forms.ComboBox cmboLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmboChonLop;
        private System.Windows.Forms.ComboBox comboChonKhoa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearch_Khoa;
        private System.Windows.Forms.Button btnSearh_Lop;
        private System.Windows.Forms.Button btnDetailStudent;
        private System.Windows.Forms.ComboBox cmboLocTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
