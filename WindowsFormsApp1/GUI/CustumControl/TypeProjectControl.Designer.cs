using System;

namespace WindowsFormsApp1.GUI.CustumControl
{
    partial class TypeProjectControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenloai = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayThem = new System.Windows.Forms.DateTimePicker();
            this.cmboKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch_Khoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmboLocKhoa = new System.Windows.Forms.ComboBox();
            this.dgvDanhSachLDT = new System.Windows.Forms.DataGridView();
            this.h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBThaoTac = new System.Windows.Forms.GroupBox();
            this.groupB_ChucNang = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLDT)).BeginInit();
            this.groupBThaoTac.SuspendLayout();
            this.groupB_ChucNang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Search.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_32;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(316, 19);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(155, 46);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm Kiếm";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFix.FlatAppearance.BorderSize = 0;
            this.btnFix.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFix.Image = global::WindowsFormsApp1.Properties.Resources.icons8_fix_32;
            this.btnFix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFix.Location = new System.Drawing.Point(359, 17);
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
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Turquoise;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Image = global::WindowsFormsApp1.Properties.Resources.icons8_reset_32;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(535, 17);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(579, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 45);
            this.label2.TabIndex = 15;
            this.label2.Text = "Danh sách loại đề tài";
            // 
            // txtTenloai
            // 
            this.txtTenloai.Location = new System.Drawing.Point(508, 58);
            this.txtTenloai.Multiline = true;
            this.txtTenloai.Name = "txtTenloai";
            this.txtTenloai.Size = new System.Drawing.Size(302, 141);
            this.txtTenloai.TabIndex = 21;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(155, 61);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(196, 28);
            this.txtMa.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên loại";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Image = global::WindowsFormsApp1.Properties.Resources.icons8_addition_32__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(178, 17);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpNgayThem);
            this.groupBox1.Controls.Add(this.cmboKhoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenloai);
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(207, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 223);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin loại đề tài";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ngày thêm";
            // 
            // dtpNgayThem
            // 
            this.dtpNgayThem.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThem.Location = new System.Drawing.Point(151, 161);
            this.dtpNgayThem.MaxDate = new System.DateTime(2024, 12, 25, 11, 14, 30, 408);
            this.dtpNgayThem.Name = "dtpNgayThem";
            this.dtpNgayThem.Size = new System.Drawing.Size(200, 28);
            this.dtpNgayThem.TabIndex = 24;
            // 
            // cmboKhoa
            // 
            this.cmboKhoa.FormattingEnabled = true;
            this.cmboKhoa.Location = new System.Drawing.Point(155, 110);
            this.cmboKhoa.Name = "cmboKhoa";
            this.cmboKhoa.Size = new System.Drawing.Size(196, 28);
            this.cmboKhoa.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Chọn khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã loại đề tài";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.btnSearch_Khoa);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cmboLocKhoa);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dgvDanhSachLDT);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1529, 618);
            this.panel3.TabIndex = 5;
            // 
            // btnSearch_Khoa
            // 
            this.btnSearch_Khoa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch_Khoa.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_32;
            this.btnSearch_Khoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Khoa.Location = new System.Drawing.Point(1358, 171);
            this.btnSearch_Khoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch_Khoa.Name = "btnSearch_Khoa";
            this.btnSearch_Khoa.Size = new System.Drawing.Size(155, 46);
            this.btnSearch_Khoa.TabIndex = 38;
            this.btnSearch_Khoa.Text = "Tìm Kiếm";
            this.btnSearch_Khoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Khoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch_Khoa.UseVisualStyleBackColor = true;
            this.btnSearch_Khoa.Click += new System.EventHandler(this.btnSearch_Khoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label8.Location = new System.Drawing.Point(1146, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 26);
            this.label8.TabIndex = 37;
            this.label8.Text = "Lọc theo khoa";
            // 
            // cmboLocKhoa
            // 
            this.cmboLocKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboLocKhoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.cmboLocKhoa.Location = new System.Drawing.Point(1151, 176);
            this.cmboLocKhoa.Name = "cmboLocKhoa";
            this.cmboLocKhoa.Size = new System.Drawing.Size(160, 43);
            this.cmboLocKhoa.TabIndex = 36;
            // 
            // dgvDanhSachLDT
            // 
            this.dgvDanhSachLDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDanhSachLDT.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachLDT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachLDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.h,
            this.Khoa,
            this.NgayThem,
            this.TenLoai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachLDT.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachLDT.Location = new System.Drawing.Point(207, 60);
            this.dgvDanhSachLDT.Name = "dgvDanhSachLDT";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachLDT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachLDT.RowHeadersWidth = 51;
            this.dgvDanhSachLDT.RowTemplate.Height = 24;
            this.dgvDanhSachLDT.Size = new System.Drawing.Size(911, 262);
            this.dgvDanhSachLDT.TabIndex = 16;
            this.dgvDanhSachLDT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLDT_CellClick);
            // 
            // h
            // 
            this.h.DataPropertyName = "MaLoai";
            this.h.HeaderText = "Mã loại ";
            this.h.MinimumWidth = 6;
            this.h.Name = "h";
            this.h.ReadOnly = true;
            this.h.Width = 64;
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            this.Khoa.ReadOnly = true;
            this.Khoa.Width = 77;
            // 
            // NgayThem
            // 
            this.NgayThem.DataPropertyName = "NgayThem";
            this.NgayThem.HeaderText = "Ngày thêm đề tài";
            this.NgayThem.MinimumWidth = 6;
            this.NgayThem.Name = "NgayThem";
            this.NgayThem.ReadOnly = true;
            this.NgayThem.Width = 132;
            // 
            // TenLoai
            // 
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên loại ";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            this.TenLoai.Width = 67;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(17, 28);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(259, 30);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Tag = "";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // groupBThaoTac
            // 
            this.groupBThaoTac.Controls.Add(this.btnReset);
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
            // groupB_ChucNang
            // 
            this.groupB_ChucNang.Controls.Add(this.btn_Search);
            this.groupB_ChucNang.Controls.Add(this.txtTimKiem);
            this.groupB_ChucNang.Location = new System.Drawing.Point(3, 4);
            this.groupB_ChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupB_ChucNang.Name = "groupB_ChucNang";
            this.groupB_ChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupB_ChucNang.Size = new System.Drawing.Size(1479, 71);
            this.groupB_ChucNang.TabIndex = 0;
            this.groupB_ChucNang.TabStop = false;
            this.groupB_ChucNang.Text = "Chức năng";
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
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ LOẠI ĐỀ TÀI";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 55);
            this.panel1.TabIndex = 3;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "dat";
            this.saveFileDialog.Filter = "Dat Files (*.dat)|*.dat|All Files (*.*)|*.*";
            this.saveFileDialog.Title = "Chọn tệp dữ liệu";
            // 
            // TypeProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TypeProjectControl";
            this.Size = new System.Drawing.Size(1529, 840);
            this.Load += new System.EventHandler(this.TypeProjectControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLDT)).EndInit();
            this.groupBThaoTac.ResumeLayout(false);
            this.groupB_ChucNang.ResumeLayout(false);
            this.groupB_ChucNang.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenloai;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDanhSachLDT;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBThaoTac;
        private System.Windows.Forms.GroupBox groupB_ChucNang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayThem;
        private System.Windows.Forms.ComboBox cmboKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch_Khoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmboLocKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn h;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
    }
}
