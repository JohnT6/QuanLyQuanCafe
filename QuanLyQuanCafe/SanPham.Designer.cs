namespace QuanLyQuanCafe
{
    partial class SanPham
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
            this.tabControl_sub_SanPham = new System.Windows.Forms.TabControl();
            this.tabPage_hangdienthoai = new System.Windows.Forms.TabPage();
            this.dgv_DMSP = new System.Windows.Forms.DataGridView();
            this.panel_HangDienThoai = new System.Windows.Forms.Panel();
            this.lb_them_HDT = new System.Windows.Forms.Label();
            this.txtBox_tendanhmuc_DM = new System.Windows.Forms.TextBox();
            this.txtBox_madanhmuc_DM = new System.Windows.Forms.TextBox();
            this.label_tenhang_hangdienthoai = new System.Windows.Forms.Label();
            this.label_mahang_hangdienthoai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sua_DM = new System.Windows.Forms.Button();
            this.btn_xoa_DM = new System.Windows.Forms.Button();
            this.btn_xem_DM = new System.Windows.Forms.Button();
            this.btn_them_DM = new System.Windows.Forms.Button();
            this.tabPage_dienthoai = new System.Windows.Forms.TabPage();
            this.dgv_ThucPham = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_sua_SP = new System.Windows.Forms.Button();
            this.btn_xoa_SP = new System.Windows.Forms.Button();
            this.btn_xem_SP = new System.Windows.Forms.Button();
            this.btn_Them_SP = new System.Windows.Forms.Button();
            this.panel_DienThoai = new System.Windows.Forms.Panel();
            this.lb_them_DT = new System.Windows.Forms.Label();
            this.btn_timkiem_DT = new System.Windows.Forms.Button();
            this.txtBox_giaThucPham = new System.Windows.Forms.TextBox();
            this.comboBox_danhMucMonAnThucUong = new System.Windows.Forms.ComboBox();
            this.txtBox_tenThucPham = new System.Windows.Forms.TextBox();
            this.txtBox_maThucPham = new System.Windows.Forms.TextBox();
            this.label_Gia = new System.Windows.Forms.Label();
            this.label_tendienthoai_dienthoai = new System.Windows.Forms.Label();
            this.label_MaMATU = new System.Windows.Forms.Label();
            this.label__DanhMuc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl_sub_SanPham.SuspendLayout();
            this.tabPage_hangdienthoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMSP)).BeginInit();
            this.panel_HangDienThoai.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage_dienthoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucPham)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel_DienThoai.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_sub_SanPham
            // 
            this.tabControl_sub_SanPham.Controls.Add(this.tabPage_hangdienthoai);
            this.tabControl_sub_SanPham.Controls.Add(this.tabPage_dienthoai);
            this.tabControl_sub_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_sub_SanPham.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_sub_SanPham.Location = new System.Drawing.Point(0, 0);
            this.tabControl_sub_SanPham.Name = "tabControl_sub_SanPham";
            this.tabControl_sub_SanPham.SelectedIndex = 0;
            this.tabControl_sub_SanPham.Size = new System.Drawing.Size(1277, 662);
            this.tabControl_sub_SanPham.TabIndex = 2;
            // 
            // tabPage_hangdienthoai
            // 
            this.tabPage_hangdienthoai.Controls.Add(this.dgv_DMSP);
            this.tabPage_hangdienthoai.Controls.Add(this.panel_HangDienThoai);
            this.tabPage_hangdienthoai.Controls.Add(this.panel1);
            this.tabPage_hangdienthoai.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_hangdienthoai.Location = new System.Drawing.Point(4, 34);
            this.tabPage_hangdienthoai.Name = "tabPage_hangdienthoai";
            this.tabPage_hangdienthoai.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_hangdienthoai.Size = new System.Drawing.Size(1269, 624);
            this.tabPage_hangdienthoai.TabIndex = 0;
            this.tabPage_hangdienthoai.Text = "   Danh Mục";
            this.tabPage_hangdienthoai.UseVisualStyleBackColor = true;
            // 
            // dgv_DMSP
            // 
            this.dgv_DMSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DMSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DMSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DMSP.Location = new System.Drawing.Point(3, 284);
            this.dgv_DMSP.Name = "dgv_DMSP";
            this.dgv_DMSP.RowHeadersWidth = 51;
            this.dgv_DMSP.RowTemplate.Height = 24;
            this.dgv_DMSP.Size = new System.Drawing.Size(1263, 246);
            this.dgv_DMSP.TabIndex = 1;
            this.dgv_DMSP.SelectionChanged += new System.EventHandler(this.dgv_DMSP_SelectionChanged);
            // 
            // panel_HangDienThoai
            // 
            this.panel_HangDienThoai.Controls.Add(this.lb_them_HDT);
            this.panel_HangDienThoai.Controls.Add(this.txtBox_tendanhmuc_DM);
            this.panel_HangDienThoai.Controls.Add(this.txtBox_madanhmuc_DM);
            this.panel_HangDienThoai.Controls.Add(this.label_tenhang_hangdienthoai);
            this.panel_HangDienThoai.Controls.Add(this.label_mahang_hangdienthoai);
            this.panel_HangDienThoai.Controls.Add(this.label1);
            this.panel_HangDienThoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_HangDienThoai.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel_HangDienThoai.Location = new System.Drawing.Point(3, 3);
            this.panel_HangDienThoai.Name = "panel_HangDienThoai";
            this.panel_HangDienThoai.Size = new System.Drawing.Size(1263, 281);
            this.panel_HangDienThoai.TabIndex = 0;
            // 
            // lb_them_HDT
            // 
            this.lb_them_HDT.AutoSize = true;
            this.lb_them_HDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_them_HDT.ForeColor = System.Drawing.Color.Red;
            this.lb_them_HDT.Location = new System.Drawing.Point(15, 181);
            this.lb_them_HDT.Name = "lb_them_HDT";
            this.lb_them_HDT.Size = new System.Drawing.Size(0, 22);
            this.lb_them_HDT.TabIndex = 3;
            // 
            // txtBox_tendanhmuc_DM
            // 
            this.txtBox_tendanhmuc_DM.Location = new System.Drawing.Point(491, 195);
            this.txtBox_tendanhmuc_DM.Name = "txtBox_tendanhmuc_DM";
            this.txtBox_tendanhmuc_DM.Size = new System.Drawing.Size(300, 39);
            this.txtBox_tendanhmuc_DM.TabIndex = 1;
            // 
            // txtBox_madanhmuc_DM
            // 
            this.txtBox_madanhmuc_DM.Location = new System.Drawing.Point(491, 132);
            this.txtBox_madanhmuc_DM.Name = "txtBox_madanhmuc_DM";
            this.txtBox_madanhmuc_DM.Size = new System.Drawing.Size(300, 39);
            this.txtBox_madanhmuc_DM.TabIndex = 0;
            // 
            // label_tenhang_hangdienthoai
            // 
            this.label_tenhang_hangdienthoai.AutoSize = true;
            this.label_tenhang_hangdienthoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_tenhang_hangdienthoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(195)))), ((int)(((byte)(189)))));
            this.label_tenhang_hangdienthoai.Location = new System.Drawing.Point(351, 212);
            this.label_tenhang_hangdienthoai.Name = "label_tenhang_hangdienthoai";
            this.label_tenhang_hangdienthoai.Size = new System.Drawing.Size(126, 22);
            this.label_tenhang_hangdienthoai.TabIndex = 2;
            this.label_tenhang_hangdienthoai.Text = "Tên Danh Mục";
            // 
            // label_mahang_hangdienthoai
            // 
            this.label_mahang_hangdienthoai.AutoSize = true;
            this.label_mahang_hangdienthoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_mahang_hangdienthoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(195)))), ((int)(((byte)(189)))));
            this.label_mahang_hangdienthoai.Location = new System.Drawing.Point(355, 149);
            this.label_mahang_hangdienthoai.Name = "label_mahang_hangdienthoai";
            this.label_mahang_hangdienthoai.Size = new System.Drawing.Size(122, 22);
            this.label_mahang_hangdienthoai.TabIndex = 1;
            this.label_mahang_hangdienthoai.Text = "Mã Danh Mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(420, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH DANH MỤC SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_sua_DM);
            this.panel1.Controls.Add(this.btn_xoa_DM);
            this.panel1.Controls.Add(this.btn_xem_DM);
            this.panel1.Controls.Add(this.btn_them_DM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 91);
            this.panel1.TabIndex = 2;
            // 
            // btn_sua_DM
            // 
            this.btn_sua_DM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_sua_DM.FlatAppearance.BorderSize = 0;
            this.btn_sua_DM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua_DM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua_DM.ForeColor = System.Drawing.Color.White;
            this.btn_sua_DM.Location = new System.Drawing.Point(686, 21);
            this.btn_sua_DM.Name = "btn_sua_DM";
            this.btn_sua_DM.Size = new System.Drawing.Size(150, 50);
            this.btn_sua_DM.TabIndex = 2;
            this.btn_sua_DM.Text = "Sửa";
            this.btn_sua_DM.UseVisualStyleBackColor = false;
            this.btn_sua_DM.Click += new System.EventHandler(this.btn_sua_DM_Click);
            // 
            // btn_xoa_DM
            // 
            this.btn_xoa_DM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_xoa_DM.FlatAppearance.BorderSize = 0;
            this.btn_xoa_DM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa_DM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_DM.ForeColor = System.Drawing.Color.White;
            this.btn_xoa_DM.Location = new System.Drawing.Point(429, 21);
            this.btn_xoa_DM.Name = "btn_xoa_DM";
            this.btn_xoa_DM.Size = new System.Drawing.Size(150, 50);
            this.btn_xoa_DM.TabIndex = 1;
            this.btn_xoa_DM.Text = "Xóa";
            this.btn_xoa_DM.UseVisualStyleBackColor = false;
            this.btn_xoa_DM.Click += new System.EventHandler(this.btn_xoa_DM_Click);
            // 
            // btn_xem_DM
            // 
            this.btn_xem_DM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_xem_DM.FlatAppearance.BorderSize = 0;
            this.btn_xem_DM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xem_DM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xem_DM.ForeColor = System.Drawing.Color.White;
            this.btn_xem_DM.Location = new System.Drawing.Point(947, 21);
            this.btn_xem_DM.Name = "btn_xem_DM";
            this.btn_xem_DM.Size = new System.Drawing.Size(150, 50);
            this.btn_xem_DM.TabIndex = 4;
            this.btn_xem_DM.Text = "Xem";
            this.btn_xem_DM.UseVisualStyleBackColor = false;
            this.btn_xem_DM.Click += new System.EventHandler(this.btn_xem_DM_Click);
            // 
            // btn_them_DM
            // 
            this.btn_them_DM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_them_DM.FlatAppearance.BorderSize = 0;
            this.btn_them_DM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them_DM.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_DM.ForeColor = System.Drawing.Color.White;
            this.btn_them_DM.Location = new System.Drawing.Point(172, 21);
            this.btn_them_DM.Name = "btn_them_DM";
            this.btn_them_DM.Size = new System.Drawing.Size(150, 50);
            this.btn_them_DM.TabIndex = 0;
            this.btn_them_DM.Text = "Thêm";
            this.btn_them_DM.UseVisualStyleBackColor = false;
            this.btn_them_DM.Click += new System.EventHandler(this.btn_them_DM_Click);
            // 
            // tabPage_dienthoai
            // 
            this.tabPage_dienthoai.Controls.Add(this.dgv_ThucPham);
            this.tabPage_dienthoai.Controls.Add(this.panel4);
            this.tabPage_dienthoai.Controls.Add(this.panel_DienThoai);
            this.tabPage_dienthoai.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_dienthoai.Location = new System.Drawing.Point(4, 34);
            this.tabPage_dienthoai.Name = "tabPage_dienthoai";
            this.tabPage_dienthoai.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_dienthoai.Size = new System.Drawing.Size(1269, 624);
            this.tabPage_dienthoai.TabIndex = 1;
            this.tabPage_dienthoai.Text = "Món ăn, Thức uống";
            this.tabPage_dienthoai.UseVisualStyleBackColor = true;
            // 
            // dgv_ThucPham
            // 
            this.dgv_ThucPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThucPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThucPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThucPham.Location = new System.Drawing.Point(3, 272);
            this.dgv_ThucPham.Name = "dgv_ThucPham";
            this.dgv_ThucPham.RowHeadersWidth = 51;
            this.dgv_ThucPham.RowTemplate.Height = 24;
            this.dgv_ThucPham.Size = new System.Drawing.Size(1263, 256);
            this.dgv_ThucPham.TabIndex = 2;
            this.dgv_ThucPham.SelectionChanged += new System.EventHandler(this.dgv_ThucPham_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_sua_SP);
            this.panel4.Controls.Add(this.btn_xoa_SP);
            this.panel4.Controls.Add(this.btn_xem_SP);
            this.panel4.Controls.Add(this.btn_Them_SP);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 528);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1263, 93);
            this.panel4.TabIndex = 1;
            // 
            // btn_sua_SP
            // 
            this.btn_sua_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_sua_SP.FlatAppearance.BorderSize = 0;
            this.btn_sua_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua_SP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua_SP.ForeColor = System.Drawing.Color.White;
            this.btn_sua_SP.Location = new System.Drawing.Point(557, 22);
            this.btn_sua_SP.Name = "btn_sua_SP";
            this.btn_sua_SP.Size = new System.Drawing.Size(150, 50);
            this.btn_sua_SP.TabIndex = 8;
            this.btn_sua_SP.Text = "Sửa";
            this.btn_sua_SP.UseVisualStyleBackColor = false;
            this.btn_sua_SP.Click += new System.EventHandler(this.btn_sua_SP_Click);
            // 
            // btn_xoa_SP
            // 
            this.btn_xoa_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_xoa_SP.FlatAppearance.BorderSize = 0;
            this.btn_xoa_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa_SP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_SP.ForeColor = System.Drawing.Color.White;
            this.btn_xoa_SP.Location = new System.Drawing.Point(303, 22);
            this.btn_xoa_SP.Name = "btn_xoa_SP";
            this.btn_xoa_SP.Size = new System.Drawing.Size(150, 50);
            this.btn_xoa_SP.TabIndex = 7;
            this.btn_xoa_SP.Text = "Xóa";
            this.btn_xoa_SP.UseVisualStyleBackColor = false;
            this.btn_xoa_SP.Click += new System.EventHandler(this.btn_xoa_SP_Click);
            // 
            // btn_xem_SP
            // 
            this.btn_xem_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_xem_SP.FlatAppearance.BorderSize = 0;
            this.btn_xem_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xem_SP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xem_SP.ForeColor = System.Drawing.Color.White;
            this.btn_xem_SP.Location = new System.Drawing.Point(801, 23);
            this.btn_xem_SP.Name = "btn_xem_SP";
            this.btn_xem_SP.Size = new System.Drawing.Size(150, 50);
            this.btn_xem_SP.TabIndex = 10;
            this.btn_xem_SP.Text = "Xem";
            this.btn_xem_SP.UseVisualStyleBackColor = false;
            this.btn_xem_SP.Click += new System.EventHandler(this.btn_xem_SP_Click);
            // 
            // btn_Them_SP
            // 
            this.btn_Them_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_Them_SP.FlatAppearance.BorderSize = 0;
            this.btn_Them_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them_SP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them_SP.ForeColor = System.Drawing.Color.White;
            this.btn_Them_SP.Location = new System.Drawing.Point(49, 23);
            this.btn_Them_SP.Name = "btn_Them_SP";
            this.btn_Them_SP.Size = new System.Drawing.Size(150, 50);
            this.btn_Them_SP.TabIndex = 6;
            this.btn_Them_SP.Text = "Thêm";
            this.btn_Them_SP.UseVisualStyleBackColor = false;
            this.btn_Them_SP.Click += new System.EventHandler(this.btn_Them_SP_Click);
            // 
            // panel_DienThoai
            // 
            this.panel_DienThoai.Controls.Add(this.lb_them_DT);
            this.panel_DienThoai.Controls.Add(this.btn_timkiem_DT);
            this.panel_DienThoai.Controls.Add(this.txtBox_giaThucPham);
            this.panel_DienThoai.Controls.Add(this.comboBox_danhMucMonAnThucUong);
            this.panel_DienThoai.Controls.Add(this.txtBox_tenThucPham);
            this.panel_DienThoai.Controls.Add(this.txtBox_maThucPham);
            this.panel_DienThoai.Controls.Add(this.label_Gia);
            this.panel_DienThoai.Controls.Add(this.label_tendienthoai_dienthoai);
            this.panel_DienThoai.Controls.Add(this.label_MaMATU);
            this.panel_DienThoai.Controls.Add(this.label__DanhMuc);
            this.panel_DienThoai.Controls.Add(this.label4);
            this.panel_DienThoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_DienThoai.Location = new System.Drawing.Point(3, 3);
            this.panel_DienThoai.Name = "panel_DienThoai";
            this.panel_DienThoai.Size = new System.Drawing.Size(1263, 269);
            this.panel_DienThoai.TabIndex = 0;
            // 
            // lb_them_DT
            // 
            this.lb_them_DT.AutoSize = true;
            this.lb_them_DT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_them_DT.ForeColor = System.Drawing.Color.Red;
            this.lb_them_DT.Location = new System.Drawing.Point(14, 360);
            this.lb_them_DT.Name = "lb_them_DT";
            this.lb_them_DT.Size = new System.Drawing.Size(0, 22);
            this.lb_them_DT.TabIndex = 24;
            // 
            // btn_timkiem_DT
            // 
            this.btn_timkiem_DT.BackColor = System.Drawing.Color.White;
            this.btn_timkiem_DT.Location = new System.Drawing.Point(531, 113);
            this.btn_timkiem_DT.Name = "btn_timkiem_DT";
            this.btn_timkiem_DT.Size = new System.Drawing.Size(46, 40);
            this.btn_timkiem_DT.TabIndex = 23;
            this.btn_timkiem_DT.UseVisualStyleBackColor = false;
            // 
            // txtBox_giaThucPham
            // 
            this.txtBox_giaThucPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.txtBox_giaThucPham.Location = new System.Drawing.Point(905, 168);
            this.txtBox_giaThucPham.Name = "txtBox_giaThucPham";
            this.txtBox_giaThucPham.Size = new System.Drawing.Size(181, 39);
            this.txtBox_giaThucPham.TabIndex = 19;
            // 
            // comboBox_danhMucMonAnThucUong
            // 
            this.comboBox_danhMucMonAnThucUong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.comboBox_danhMucMonAnThucUong.FormattingEnabled = true;
            this.comboBox_danhMucMonAnThucUong.Location = new System.Drawing.Point(283, 115);
            this.comboBox_danhMucMonAnThucUong.Name = "comboBox_danhMucMonAnThucUong";
            this.comboBox_danhMucMonAnThucUong.Size = new System.Drawing.Size(242, 39);
            this.comboBox_danhMucMonAnThucUong.TabIndex = 17;
            // 
            // txtBox_tenThucPham
            // 
            this.txtBox_tenThucPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.txtBox_tenThucPham.Location = new System.Drawing.Point(905, 108);
            this.txtBox_tenThucPham.Name = "txtBox_tenThucPham";
            this.txtBox_tenThucPham.Size = new System.Drawing.Size(242, 39);
            this.txtBox_tenThucPham.TabIndex = 15;
            // 
            // txtBox_maThucPham
            // 
            this.txtBox_maThucPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.txtBox_maThucPham.Location = new System.Drawing.Point(283, 178);
            this.txtBox_maThucPham.Name = "txtBox_maThucPham";
            this.txtBox_maThucPham.Size = new System.Drawing.Size(242, 39);
            this.txtBox_maThucPham.TabIndex = 14;
            // 
            // label_Gia
            // 
            this.label_Gia.AutoSize = true;
            this.label_Gia.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_Gia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_Gia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(195)))), ((int)(((byte)(189)))));
            this.label_Gia.Location = new System.Drawing.Point(860, 185);
            this.label_Gia.Name = "label_Gia";
            this.label_Gia.Size = new System.Drawing.Size(39, 22);
            this.label_Gia.TabIndex = 12;
            this.label_Gia.Text = "Giá";
            // 
            // label_tendienthoai_dienthoai
            // 
            this.label_tendienthoai_dienthoai.AutoSize = true;
            this.label_tendienthoai_dienthoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_tendienthoai_dienthoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(195)))), ((int)(((byte)(189)))));
            this.label_tendienthoai_dienthoai.Location = new System.Drawing.Point(712, 125);
            this.label_tendienthoai_dienthoai.Name = "label_tendienthoai_dienthoai";
            this.label_tendienthoai_dienthoai.Size = new System.Drawing.Size(187, 22);
            this.label_tendienthoai_dienthoai.TabIndex = 9;
            this.label_tendienthoai_dienthoai.Text = "Tên món ăn, thức uống";
            // 
            // label_MaMATU
            // 
            this.label_MaMATU.AutoSize = true;
            this.label_MaMATU.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MaMATU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(195)))), ((int)(((byte)(189)))));
            this.label_MaMATU.Location = new System.Drawing.Point(69, 195);
            this.label_MaMATU.Name = "label_MaMATU";
            this.label_MaMATU.Size = new System.Drawing.Size(183, 22);
            this.label_MaMATU.TabIndex = 8;
            this.label_MaMATU.Text = "Mã món ăn, thức uống";
            // 
            // label__DanhMuc
            // 
            this.label__DanhMuc.AutoSize = true;
            this.label__DanhMuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label__DanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(195)))), ((int)(((byte)(189)))));
            this.label__DanhMuc.Location = new System.Drawing.Point(164, 125);
            this.label__DanhMuc.Name = "label__DanhMuc";
            this.label__DanhMuc.Size = new System.Drawing.Size(88, 22);
            this.label__DanhMuc.TabIndex = 1;
            this.label__DanhMuc.Text = "Danh mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.label4.Location = new System.Drawing.Point(376, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(466, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "DANH SÁCH MÓN ĂN, THỨC UỐNG";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 662);
            this.Controls.Add(this.tabControl_sub_SanPham);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.tabControl_sub_SanPham.ResumeLayout(false);
            this.tabPage_hangdienthoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DMSP)).EndInit();
            this.panel_HangDienThoai.ResumeLayout(false);
            this.panel_HangDienThoai.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage_dienthoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThucPham)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel_DienThoai.ResumeLayout(false);
            this.panel_DienThoai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_sub_SanPham;
        private System.Windows.Forms.TabPage tabPage_hangdienthoai;
        private System.Windows.Forms.DataGridView dgv_DMSP;
        private System.Windows.Forms.Panel panel_HangDienThoai;
        private System.Windows.Forms.Label lb_them_HDT;
        private System.Windows.Forms.TextBox txtBox_tendanhmuc_DM;
        private System.Windows.Forms.TextBox txtBox_madanhmuc_DM;
        private System.Windows.Forms.Label label_tenhang_hangdienthoai;
        private System.Windows.Forms.Label label_mahang_hangdienthoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sua_DM;
        private System.Windows.Forms.Button btn_xoa_DM;
        private System.Windows.Forms.Button btn_xem_DM;
        private System.Windows.Forms.Button btn_them_DM;
        private System.Windows.Forms.TabPage tabPage_dienthoai;
        private System.Windows.Forms.DataGridView dgv_ThucPham;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_sua_SP;
        private System.Windows.Forms.Button btn_xoa_SP;
        private System.Windows.Forms.Button btn_xem_SP;
        private System.Windows.Forms.Button btn_Them_SP;
        private System.Windows.Forms.Panel panel_DienThoai;
        private System.Windows.Forms.Label lb_them_DT;
        private System.Windows.Forms.Button btn_timkiem_DT;
        private System.Windows.Forms.TextBox txtBox_giaThucPham;
        private System.Windows.Forms.ComboBox comboBox_danhMucMonAnThucUong;
        private System.Windows.Forms.TextBox txtBox_tenThucPham;
        private System.Windows.Forms.TextBox txtBox_maThucPham;
        private System.Windows.Forms.Label label_Gia;
        private System.Windows.Forms.Label label_tendienthoai_dienthoai;
        private System.Windows.Forms.Label label_MaMATU;
        private System.Windows.Forms.Label label__DanhMuc;
        private System.Windows.Forms.Label label4;
    }
}