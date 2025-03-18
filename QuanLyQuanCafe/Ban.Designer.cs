namespace QuanLyQuanCafe
{
    partial class Ban
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
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_ban = new System.Windows.Forms.TabPage();
            this.dgv_Ban = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_sua_Ban = new System.Windows.Forms.Button();
            this.btn_xoa_Ban = new System.Windows.Forms.Button();
            this.btn_xem_Ban = new System.Windows.Forms.Button();
            this.btn_them_Ban = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBox_trangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_tenBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_maBan = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_ban.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_ban);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1298, 701);
            this.tabControl_Main.TabIndex = 2;
            // 
            // tabPage_ban
            // 
            this.tabPage_ban.Controls.Add(this.dgv_Ban);
            this.tabPage_ban.Controls.Add(this.panel8);
            this.tabPage_ban.Controls.Add(this.panel7);
            this.tabPage_ban.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_ban.Location = new System.Drawing.Point(4, 35);
            this.tabPage_ban.Name = "tabPage_ban";
            this.tabPage_ban.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ban.Size = new System.Drawing.Size(1290, 662);
            this.tabPage_ban.TabIndex = 3;
            this.tabPage_ban.Text = " Bàn";
            this.tabPage_ban.UseVisualStyleBackColor = true;
            // 
            // dgv_Ban
            // 
            this.dgv_Ban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Ban.Location = new System.Drawing.Point(3, 202);
            this.dgv_Ban.Name = "dgv_Ban";
            this.dgv_Ban.RowHeadersWidth = 51;
            this.dgv_Ban.RowTemplate.Height = 24;
            this.dgv_Ban.Size = new System.Drawing.Size(1284, 309);
            this.dgv_Ban.TabIndex = 2;
            this.dgv_Ban.SelectionChanged += new System.EventHandler(this.dgv_Ban_SelectionChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_sua_Ban);
            this.panel8.Controls.Add(this.btn_xoa_Ban);
            this.panel8.Controls.Add(this.btn_xem_Ban);
            this.panel8.Controls.Add(this.btn_them_Ban);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(3, 511);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1284, 148);
            this.panel8.TabIndex = 1;
            // 
            // btn_sua_Ban
            // 
            this.btn_sua_Ban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_sua_Ban.FlatAppearance.BorderSize = 0;
            this.btn_sua_Ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua_Ban.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua_Ban.ForeColor = System.Drawing.Color.White;
            this.btn_sua_Ban.Location = new System.Drawing.Point(568, 30);
            this.btn_sua_Ban.Name = "btn_sua_Ban";
            this.btn_sua_Ban.Size = new System.Drawing.Size(150, 50);
            this.btn_sua_Ban.TabIndex = 23;
            this.btn_sua_Ban.Text = "Sửa";
            this.btn_sua_Ban.UseVisualStyleBackColor = false;
            this.btn_sua_Ban.Click += new System.EventHandler(this.btn_sua_Ban_Click);
            // 
            // btn_xoa_Ban
            // 
            this.btn_xoa_Ban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_xoa_Ban.FlatAppearance.BorderSize = 0;
            this.btn_xoa_Ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa_Ban.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa_Ban.ForeColor = System.Drawing.Color.White;
            this.btn_xoa_Ban.Location = new System.Drawing.Point(311, 30);
            this.btn_xoa_Ban.Name = "btn_xoa_Ban";
            this.btn_xoa_Ban.Size = new System.Drawing.Size(150, 50);
            this.btn_xoa_Ban.TabIndex = 22;
            this.btn_xoa_Ban.Text = "Xóa";
            this.btn_xoa_Ban.UseVisualStyleBackColor = false;
            this.btn_xoa_Ban.Click += new System.EventHandler(this.btn_xoa_Ban_Click);
            // 
            // btn_xem_Ban
            // 
            this.btn_xem_Ban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_xem_Ban.FlatAppearance.BorderSize = 0;
            this.btn_xem_Ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xem_Ban.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xem_Ban.ForeColor = System.Drawing.Color.White;
            this.btn_xem_Ban.Location = new System.Drawing.Point(825, 30);
            this.btn_xem_Ban.Name = "btn_xem_Ban";
            this.btn_xem_Ban.Size = new System.Drawing.Size(150, 50);
            this.btn_xem_Ban.TabIndex = 25;
            this.btn_xem_Ban.Text = "Xem";
            this.btn_xem_Ban.UseVisualStyleBackColor = false;
            this.btn_xem_Ban.Click += new System.EventHandler(this.btn_xem_Ban_Click);
            // 
            // btn_them_Ban
            // 
            this.btn_them_Ban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_them_Ban.FlatAppearance.BorderSize = 0;
            this.btn_them_Ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them_Ban.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them_Ban.ForeColor = System.Drawing.Color.White;
            this.btn_them_Ban.Location = new System.Drawing.Point(54, 30);
            this.btn_them_Ban.Name = "btn_them_Ban";
            this.btn_them_Ban.Size = new System.Drawing.Size(150, 50);
            this.btn_them_Ban.TabIndex = 21;
            this.btn_them_Ban.Text = "Thêm";
            this.btn_them_Ban.UseVisualStyleBackColor = false;
            this.btn_them_Ban.Click += new System.EventHandler(this.btn_them_Ban_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.comboBox_trangThai);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtBox_tenBan);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.txtBox_maBan);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1284, 199);
            this.panel7.TabIndex = 0;
            // 
            // comboBox_trangThai
            // 
            this.comboBox_trangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.comboBox_trangThai.FormattingEnabled = true;
            this.comboBox_trangThai.Location = new System.Drawing.Point(929, 76);
            this.comboBox_trangThai.Name = "comboBox_trangThai";
            this.comboBox_trangThai.Size = new System.Drawing.Size(187, 39);
            this.comboBox_trangThai.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(195)))), ((int)(((byte)(189)))));
            this.label2.Location = new System.Drawing.Point(800, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trạng Thái";
            // 
            // txtBox_tenBan
            // 
            this.txtBox_tenBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.txtBox_tenBan.Location = new System.Drawing.Point(516, 76);
            this.txtBox_tenBan.Name = "txtBox_tenBan";
            this.txtBox_tenBan.Size = new System.Drawing.Size(210, 39);
            this.txtBox_tenBan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(195)))), ((int)(((byte)(189)))));
            this.label1.Location = new System.Drawing.Point(425, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Bàn";
            // 
            // txtBox_maBan
            // 
            this.txtBox_maBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.txtBox_maBan.Location = new System.Drawing.Point(138, 76);
            this.txtBox_maBan.Name = "txtBox_maBan";
            this.txtBox_maBan.Size = new System.Drawing.Size(210, 39);
            this.txtBox_maBan.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(195)))), ((int)(((byte)(189)))));
            this.label17.Location = new System.Drawing.Point(49, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 22);
            this.label17.TabIndex = 1;
            this.label17.Text = "Mã Bàn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.label16.Location = new System.Drawing.Point(475, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(240, 33);
            this.label16.TabIndex = 0;
            this.label16.Text = "DANH SÁCH BÀN";
            // 
            // Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 701);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "Ban";
            this.Text = "Ban";
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_ban.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ban)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_ban;
        private System.Windows.Forms.DataGridView dgv_Ban;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtBox_maBan;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox_trangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_tenBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sua_Ban;
        private System.Windows.Forms.Button btn_xoa_Ban;
        private System.Windows.Forms.Button btn_xem_Ban;
        private System.Windows.Forms.Button btn_them_Ban;
    }
}