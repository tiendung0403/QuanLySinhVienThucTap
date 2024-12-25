namespace WindowsFormsApp1.GUI.CustumControl
{
    partial class ResultProjectControl
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
            this.btnaAdd = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBThaoTac = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupB_ChucNang = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtChiTietTenDT = new System.Windows.Forms.TextBox();
            this.txtChiTietBaoCao = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtChiTietNhanXet = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtChiTietDiem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtChiTietHoTenSV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtChiTietMaSV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChiTietMaDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChiTietTuan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChiTietMaDG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.txtLinkBaoCao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNhanXet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDanhSachDeTai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBThaoTac.SuspendLayout();
            this.groupB_ChucNang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDeTai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaAdd
            // 
            this.btnaAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnaAdd.FlatAppearance.BorderSize = 0;
            this.btnaAdd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnaAdd.Image = global::WindowsFormsApp1.Properties.Resources.icons8_addition_32__1_;
            this.btnaAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaAdd.Location = new System.Drawing.Point(73, 190);
            this.btnaAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaAdd.Name = "btnaAdd";
            this.btnaAdd.Size = new System.Drawing.Size(126, 48);
            this.btnaAdd.TabIndex = 0;
            this.btnaAdd.Text = "  Thêm";
            this.btnaAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnaAdd.UseVisualStyleBackColor = false;
            this.btnaAdd.Click += new System.EventHandler(this.btnaAdd_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "dat";
            this.saveFileDialog.Filter = "Dat Files (*.dat)|*.dat|All Files (*.*)|*.*";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Turquoise;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Image = global::WindowsFormsApp1.Properties.Resources.icons8_reset_32;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(561, 17);
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
            this.btnDelete.Location = new System.Drawing.Point(401, 190);
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
            this.btnFix.Location = new System.Drawing.Point(243, 190);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ ĐÁNH GIÁ ";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Search.Image = global::WindowsFormsApp1.Properties.Resources.icons8_search_32;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(316, 19);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(202, 46);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm theo mã SV";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            this.panel2.TabIndex = 7;
            // 
            // groupBThaoTac
            // 
            this.groupBThaoTac.Controls.Add(this.label2);
            this.groupBThaoTac.Location = new System.Drawing.Point(3, 82);
            this.groupBThaoTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBThaoTac.Name = "groupBThaoTac";
            this.groupBThaoTac.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBThaoTac.Size = new System.Drawing.Size(1479, 82);
            this.groupBThaoTac.TabIndex = 2;
            this.groupBThaoTac.TabStop = false;
            this.groupBThaoTac.Text = "đánh giá đề tài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(530, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 41);
            this.label2.TabIndex = 15;
            this.label2.Text = "DANH SÁCH ĐÁNH GIÁ CHI TIẾT";
            // 
            // groupB_ChucNang
            // 
            this.groupB_ChucNang.Controls.Add(this.btnReset);
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
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimkiem.Location = new System.Drawing.Point(17, 28);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(259, 30);
            this.txtTimkiem.TabIndex = 0;
            this.txtTimkiem.Tag = "";
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 55);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.groupBoxInput);
            this.panel3.Controls.Add(this.dgvDanhSachDeTai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1529, 622);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Controls.Add(this.txtChiTietTenDT);
            this.panel4.Controls.Add(this.txtChiTietBaoCao);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txtChiTietNhanXet);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtChiTietDiem);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtChiTietHoTenSV);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtChiTietMaSV);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtChiTietMaDT);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtChiTietTuan);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtChiTietMaDG);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(945, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(563, 565);
            this.panel4.TabIndex = 18;
            // 
            // txtChiTietTenDT
            // 
            this.txtChiTietTenDT.Location = new System.Drawing.Point(175, 156);
            this.txtChiTietTenDT.Multiline = true;
            this.txtChiTietTenDT.Name = "txtChiTietTenDT";
            this.txtChiTietTenDT.ReadOnly = true;
            this.txtChiTietTenDT.Size = new System.Drawing.Size(308, 61);
            this.txtChiTietTenDT.TabIndex = 57;
            // 
            // txtChiTietBaoCao
            // 
            this.txtChiTietBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChiTietBaoCao.Location = new System.Drawing.Point(175, 232);
            this.txtChiTietBaoCao.Name = "txtChiTietBaoCao";
            this.txtChiTietBaoCao.ReadOnly = true;
            this.txtChiTietBaoCao.Size = new System.Drawing.Size(308, 30);
            this.txtChiTietBaoCao.TabIndex = 56;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(12, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 25);
            this.label18.TabIndex = 55;
            this.label18.Text = "Link báo cáo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(169, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(220, 31);
            this.label16.TabIndex = 54;
            this.label16.Text = "CHI TIẾT ĐÁNH GIÁ";
            // 
            // txtChiTietNhanXet
            // 
            this.txtChiTietNhanXet.Location = new System.Drawing.Point(9, 407);
            this.txtChiTietNhanXet.Multiline = true;
            this.txtChiTietNhanXet.Name = "txtChiTietNhanXet";
            this.txtChiTietNhanXet.ReadOnly = true;
            this.txtChiTietNhanXet.Size = new System.Drawing.Size(308, 140);
            this.txtChiTietNhanXet.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(384, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 25);
            this.label14.TabIndex = 53;
            this.label14.Text = "Điểm";
            // 
            // txtChiTietDiem
            // 
            this.txtChiTietDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChiTietDiem.Location = new System.Drawing.Point(389, 407);
            this.txtChiTietDiem.Name = "txtChiTietDiem";
            this.txtChiTietDiem.ReadOnly = true;
            this.txtChiTietDiem.Size = new System.Drawing.Size(148, 30);
            this.txtChiTietDiem.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(12, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 25);
            this.label13.TabIndex = 50;
            this.label13.Text = "Nhận xét";
            // 
            // txtChiTietHoTenSV
            // 
            this.txtChiTietHoTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChiTietHoTenSV.Location = new System.Drawing.Point(175, 333);
            this.txtChiTietHoTenSV.Name = "txtChiTietHoTenSV";
            this.txtChiTietHoTenSV.ReadOnly = true;
            this.txtChiTietHoTenSV.Size = new System.Drawing.Size(308, 30);
            this.txtChiTietHoTenSV.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.Location = new System.Drawing.Point(12, 336);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 25);
            this.label12.TabIndex = 48;
            this.label12.Text = "Họ tên sinh viên";
            // 
            // txtChiTietMaSV
            // 
            this.txtChiTietMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChiTietMaSV.Location = new System.Drawing.Point(175, 281);
            this.txtChiTietMaSV.Name = "txtChiTietMaSV";
            this.txtChiTietMaSV.ReadOnly = true;
            this.txtChiTietMaSV.Size = new System.Drawing.Size(308, 30);
            this.txtChiTietMaSV.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(12, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 46;
            this.label11.Text = "Mã sinh viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(12, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "Tên đề tài";
            // 
            // txtChiTietMaDT
            // 
            this.txtChiTietMaDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChiTietMaDT.Location = new System.Drawing.Point(175, 114);
            this.txtChiTietMaDT.Name = "txtChiTietMaDT";
            this.txtChiTietMaDT.ReadOnly = true;
            this.txtChiTietMaDT.Size = new System.Drawing.Size(308, 30);
            this.txtChiTietMaDT.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(15, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 42;
            this.label9.Text = "Mã đề tài";
            // 
            // txtChiTietTuan
            // 
            this.txtChiTietTuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChiTietTuan.Location = new System.Drawing.Point(70, 38);
            this.txtChiTietTuan.Name = "txtChiTietTuan";
            this.txtChiTietTuan.ReadOnly = true;
            this.txtChiTietTuan.Size = new System.Drawing.Size(87, 30);
            this.txtChiTietTuan.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(12, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Tuần";
            // 
            // txtChiTietMaDG
            // 
            this.txtChiTietMaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChiTietMaDG.Location = new System.Drawing.Point(175, 73);
            this.txtChiTietMaDG.Name = "txtChiTietMaDG";
            this.txtChiTietMaDG.ReadOnly = true;
            this.txtChiTietMaDG.Size = new System.Drawing.Size(308, 30);
            this.txtChiTietMaDG.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mã đánh giá";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.BackColor = System.Drawing.Color.Silver;
            this.groupBoxInput.Controls.Add(this.txtLinkBaoCao);
            this.groupBoxInput.Controls.Add(this.label17);
            this.groupBoxInput.Controls.Add(this.txtDiem);
            this.groupBoxInput.Controls.Add(this.label15);
            this.groupBoxInput.Controls.Add(this.txtNhanXet);
            this.groupBoxInput.Controls.Add(this.label7);
            this.groupBoxInput.Controls.Add(this.txtMaDT);
            this.groupBoxInput.Controls.Add(this.btnaAdd);
            this.groupBoxInput.Controls.Add(this.label6);
            this.groupBoxInput.Controls.Add(this.txtTuan);
            this.groupBoxInput.Controls.Add(this.label5);
            this.groupBoxInput.Controls.Add(this.txtMa);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.btnFix);
            this.groupBoxInput.Controls.Add(this.btnDelete);
            this.groupBoxInput.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInput.Location = new System.Drawing.Point(76, 348);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(840, 246);
            this.groupBoxInput.TabIndex = 17;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Nhập thông tin đánh giá";
            // 
            // txtLinkBaoCao
            // 
            this.txtLinkBaoCao.Location = new System.Drawing.Point(208, 116);
            this.txtLinkBaoCao.Name = "txtLinkBaoCao";
            this.txtLinkBaoCao.Size = new System.Drawing.Size(237, 28);
            this.txtLinkBaoCao.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(95, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = "Link báo cáo ";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(643, 190);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(89, 28);
            this.txtDiem.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(566, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 42;
            this.label15.Text = "Điểm";
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Location = new System.Drawing.Point(581, 37);
            this.txtNhanXet.Multiline = true;
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.Size = new System.Drawing.Size(237, 131);
            this.txtNhanXet.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Nhận xét";
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(208, 157);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(237, 28);
            this.txtMaDT.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mã đề tài";
            // 
            // txtTuan
            // 
            this.txtTuan.Location = new System.Drawing.Point(208, 70);
            this.txtTuan.Name = "txtTuan";
            this.txtTuan.Size = new System.Drawing.Size(237, 28);
            this.txtTuan.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tuần";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(208, 31);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(237, 28);
            this.txtMa.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã đánh giá";
            // 
            // dgvDanhSachDeTai
            // 
            this.dgvDanhSachDeTai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDanhSachDeTai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDanhSachDeTai.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDeTai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Tuan1,
            this.Column2,
            this.TenDT,
            this.MaSV,
            this.Diem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachDeTai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachDeTai.Location = new System.Drawing.Point(76, 24);
            this.dgvDanhSachDeTai.Name = "dgvDanhSachDeTai";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachDeTai.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachDeTai.RowHeadersWidth = 51;
            this.dgvDanhSachDeTai.RowTemplate.Height = 24;
            this.dgvDanhSachDeTai.Size = new System.Drawing.Size(840, 298);
            this.dgvDanhSachDeTai.TabIndex = 16;
            this.dgvDanhSachDeTai.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachDeTai_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDG";
            this.Column1.HeaderText = "Mã Đánh giá";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 131;
            // 
            // Tuan1
            // 
            this.Tuan1.HeaderText = "Tuần ";
            this.Tuan1.MinimumWidth = 6;
            this.Tuan1.Name = "Tuan1";
            this.Tuan1.ReadOnly = true;
            this.Tuan1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaDT";
            this.Column2.HeaderText = "Mã đề tài";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 106;
            // 
            // TenDT
            // 
            this.TenDT.HeaderText = "Tên đề tài";
            this.TenDT.MinimumWidth = 6;
            this.TenDT.Name = "TenDT";
            this.TenDT.ReadOnly = true;
            this.TenDT.Width = 111;
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 131;
            // 
            // Diem
            // 
            this.Diem.HeaderText = "Điểm";
            this.Diem.MinimumWidth = 6;
            this.Diem.Name = "Diem";
            this.Diem.ReadOnly = true;
            this.Diem.Width = 77;
            // 
            // ResultProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ResultProjectControl";
            this.Size = new System.Drawing.Size(1529, 844);
            this.panel2.ResumeLayout(false);
            this.groupBThaoTac.ResumeLayout(false);
            this.groupBThaoTac.PerformLayout();
            this.groupB_ChucNang.ResumeLayout(false);
            this.groupB_ChucNang.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachDeTai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaAdd;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBThaoTac;
        private System.Windows.Forms.GroupBox groupB_ChucNang;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDanhSachDeTai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNhanXet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtChiTietNhanXet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtChiTietDiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtChiTietHoTenSV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtChiTietMaSV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChiTietMaDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtChiTietTuan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChiTietMaDG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtChiTietBaoCao;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtLinkBaoCao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtChiTietTenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
    }
}
