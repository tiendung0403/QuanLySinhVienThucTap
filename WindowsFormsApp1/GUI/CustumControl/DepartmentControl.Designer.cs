namespace WindowsFormsApp1.GUI.CustumControl
{
    partial class DepartmentControl
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
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.groupBThaoTac = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupB_ChucNang = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDsKhoa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaDsKhoa = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboLop = new System.Windows.Forms.ComboBox();
            this.cmboKhoa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch_Lop = new System.Windows.Forms.Button();
            this.btnSearch_Khoa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmboNam = new System.Windows.Forms.ComboBox();
            this.btnSearch_Nam = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maDsKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBThaoTac.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupB_ChucNang.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKhoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // groupBThaoTac
            // 
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
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Turquoise;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Image = global::WindowsFormsApp1.Properties.Resources.icons8_reset_32;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(631, 21);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.groupBThaoTac);
            this.panel2.Controls.Add(this.groupB_ChucNang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1524, 167);
            this.panel2.TabIndex = 4;
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
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ KHOA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1524, 55);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(498, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 45);
            this.label2.TabIndex = 15;
            this.label2.Text = "Danh sách khoa";
            // 
            // dgvDsKhoa
            // 
            this.dgvDsKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDsKhoa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsKhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDsKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDsKhoa,
            this.MaKhoa,
            this.TenKhoa,
            this.LopHoc,
            this.NamHoc,
            this.SoLuongSV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDsKhoa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDsKhoa.Location = new System.Drawing.Point(76, 60);
            this.dgvDsKhoa.Name = "dgvDsKhoa";
            this.dgvDsKhoa.RowHeadersWidth = 51;
            this.dgvDsKhoa.RowTemplate.Height = 24;
            this.dgvDsKhoa.Size = new System.Drawing.Size(1035, 262);
            this.dgvDsKhoa.TabIndex = 16;
            this.dgvDsKhoa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsKhoa_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.txtMaDsKhoa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNamHoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 223);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khoa";
            // 
            // txtMaDsKhoa
            // 
            this.txtMaDsKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtMaDsKhoa.Location = new System.Drawing.Point(200, 37);
            this.txtMaDsKhoa.Name = "txtMaDsKhoa";
            this.txtMaDsKhoa.Size = new System.Drawing.Size(289, 34);
            this.txtMaDsKhoa.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label10.Location = new System.Drawing.Point(73, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 26);
            this.label10.TabIndex = 25;
            this.label10.Text = "Mã ds";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtNamHoc.Location = new System.Drawing.Point(669, 147);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(289, 34);
            this.txtNamHoc.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label6.Location = new System.Drawing.Point(542, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "Năm học";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtTenLop.Location = new System.Drawing.Point(669, 59);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(289, 34);
            this.txtTenLop.TabIndex = 22;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtTenKhoa.Location = new System.Drawing.Point(200, 147);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(289, 34);
            this.txtTenKhoa.TabIndex = 21;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.txtMaKhoa.Location = new System.Drawing.Point(200, 92);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(289, 34);
            this.txtMaKhoa.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label5.Location = new System.Drawing.Point(542, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label4.Location = new System.Drawing.Point(73, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label3.Location = new System.Drawing.Point(73, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khoa";
            // 
            // cmboLop
            // 
            this.cmboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboLop.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.cmboLop.Location = new System.Drawing.Point(1131, 99);
            this.cmboLop.Name = "cmboLop";
            this.cmboLop.Size = new System.Drawing.Size(160, 43);
            this.cmboLop.TabIndex = 33;
            // 
            // cmboKhoa
            // 
            this.cmboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboKhoa.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.cmboKhoa.Location = new System.Drawing.Point(1131, 192);
            this.cmboKhoa.Name = "cmboKhoa";
            this.cmboKhoa.Size = new System.Drawing.Size(160, 43);
            this.cmboKhoa.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label7.Location = new System.Drawing.Point(1126, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Lọc theo lớp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label8.Location = new System.Drawing.Point(1126, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 26);
            this.label8.TabIndex = 34;
            this.label8.Text = "Lọc theo khoa";
            // 
            // btnSearch_Lop
            // 
            this.btnSearch_Lop.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch_Lop.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_32;
            this.btnSearch_Lop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Lop.Location = new System.Drawing.Point(1338, 94);
            this.btnSearch_Lop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch_Lop.Name = "btnSearch_Lop";
            this.btnSearch_Lop.Size = new System.Drawing.Size(155, 46);
            this.btnSearch_Lop.TabIndex = 2;
            this.btnSearch_Lop.Text = "Tìm Kiếm";
            this.btnSearch_Lop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Lop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch_Lop.UseVisualStyleBackColor = true;
            this.btnSearch_Lop.Click += new System.EventHandler(this.btnSearch_Lop_Click);
            // 
            // btnSearch_Khoa
            // 
            this.btnSearch_Khoa.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch_Khoa.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_32;
            this.btnSearch_Khoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Khoa.Location = new System.Drawing.Point(1338, 187);
            this.btnSearch_Khoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch_Khoa.Name = "btnSearch_Khoa";
            this.btnSearch_Khoa.Size = new System.Drawing.Size(155, 46);
            this.btnSearch_Khoa.TabIndex = 35;
            this.btnSearch_Khoa.Text = "Tìm Kiếm";
            this.btnSearch_Khoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Khoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch_Khoa.UseVisualStyleBackColor = true;
            this.btnSearch_Khoa.Click += new System.EventHandler(this.btnSearch_Khoa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label9.Location = new System.Drawing.Point(1126, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 26);
            this.label9.TabIndex = 36;
            this.label9.Text = "Lọc theo năm";
            // 
            // cmboNam
            // 
            this.cmboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboNam.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.cmboNam.Location = new System.Drawing.Point(1131, 279);
            this.cmboNam.Name = "cmboNam";
            this.cmboNam.Size = new System.Drawing.Size(160, 43);
            this.cmboNam.TabIndex = 37;
            // 
            // btnSearch_Nam
            // 
            this.btnSearch_Nam.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch_Nam.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_32;
            this.btnSearch_Nam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Nam.Location = new System.Drawing.Point(1338, 274);
            this.btnSearch_Nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch_Nam.Name = "btnSearch_Nam";
            this.btnSearch_Nam.Size = new System.Drawing.Size(155, 46);
            this.btnSearch_Nam.TabIndex = 38;
            this.btnSearch_Nam.Text = "Tìm Kiếm";
            this.btnSearch_Nam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch_Nam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch_Nam.UseVisualStyleBackColor = true;
            this.btnSearch_Nam.Click += new System.EventHandler(this.btnSearch_Nam_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.btnSearch_Nam);
            this.panel3.Controls.Add(this.cmboNam);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnSearch_Khoa);
            this.panel3.Controls.Add(this.btnSearch_Lop);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmboKhoa);
            this.panel3.Controls.Add(this.cmboLop);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.dgvDsKhoa);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1524, 618);
            this.panel3.TabIndex = 5;
            // 
            // maDsKhoa
            // 
            this.maDsKhoa.DataPropertyName = "maDsKhoa";
            this.maDsKhoa.HeaderText = "Mã Ds";
            this.maDsKhoa.MinimumWidth = 6;
            this.maDsKhoa.Name = "maDsKhoa";
            this.maDsKhoa.ReadOnly = true;
            this.maDsKhoa.Width = 109;
            // 
            // MaKhoa
            // 
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Width = 130;
            // 
            // TenKhoa
            // 
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên khoa";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            this.TenKhoa.Width = 135;
            // 
            // LopHoc
            // 
            this.LopHoc.DataPropertyName = "LopHoc";
            this.LopHoc.HeaderText = "Lớp học";
            this.LopHoc.MinimumWidth = 6;
            this.LopHoc.Name = "LopHoc";
            this.LopHoc.ReadOnly = true;
            this.LopHoc.Width = 126;
            // 
            // NamHoc
            // 
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Năm thực tập";
            this.NamHoc.MinimumWidth = 6;
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.ReadOnly = true;
            this.NamHoc.Width = 179;
            // 
            // SoLuongSV
            // 
            this.SoLuongSV.DataPropertyName = "SoLuongSV";
            this.SoLuongSV.HeaderText = "Số lượng sv";
            this.SoLuongSV.MinimumWidth = 6;
            this.SoLuongSV.Name = "SoLuongSV";
            this.SoLuongSV.ReadOnly = true;
            this.SoLuongSV.Width = 161;
            // 
            // DepartmentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DepartmentControl";
            this.Size = new System.Drawing.Size(1524, 840);
            this.Load += new System.EventHandler(this.DepartmentControl_Load);
            this.groupBThaoTac.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupB_ChucNang.ResumeLayout(false);
            this.groupB_ChucNang.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsKhoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.GroupBox groupBThaoTac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupB_ChucNang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDsKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaDsKhoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboLop;
        private System.Windows.Forms.ComboBox cmboKhoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch_Lop;
        private System.Windows.Forms.Button btnSearch_Khoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmboNam;
        private System.Windows.Forms.Button btnSearch_Nam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDsKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSV;
    }
}
