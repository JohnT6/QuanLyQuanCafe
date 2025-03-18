namespace QuanLyQuanCafe
{
    partial class ThongKe
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
            this.tabPage_thongke = new System.Windows.Forms.TabPage();
            this.dgv_ThongKe = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_xem_DT = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker_CheckIn = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_CheckOut = new System.Windows.Forms.DateTimePicker();
            this.btn_thongke_DT = new System.Windows.Forms.Button();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_thongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_thongke);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1357, 758);
            this.tabControl_Main.TabIndex = 3;
            // 
            // tabPage_thongke
            // 
            this.tabPage_thongke.Controls.Add(this.dgv_ThongKe);
            this.tabPage_thongke.Controls.Add(this.panel8);
            this.tabPage_thongke.Controls.Add(this.panel7);
            this.tabPage_thongke.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage_thongke.Location = new System.Drawing.Point(4, 35);
            this.tabPage_thongke.Name = "tabPage_thongke";
            this.tabPage_thongke.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_thongke.Size = new System.Drawing.Size(1349, 719);
            this.tabPage_thongke.TabIndex = 3;
            this.tabPage_thongke.Text = "Doanh Thu";
            this.tabPage_thongke.UseVisualStyleBackColor = true;
            // 
            // dgv_ThongKe
            // 
            this.dgv_ThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ThongKe.Location = new System.Drawing.Point(3, 202);
            this.dgv_ThongKe.Name = "dgv_ThongKe";
            this.dgv_ThongKe.RowHeadersWidth = 51;
            this.dgv_ThongKe.RowTemplate.Height = 24;
            this.dgv_ThongKe.Size = new System.Drawing.Size(1343, 366);
            this.dgv_ThongKe.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_xem_DT);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(3, 568);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1343, 148);
            this.panel8.TabIndex = 1;
            // 
            // btn_xem_DT
            // 
            this.btn_xem_DT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_xem_DT.FlatAppearance.BorderSize = 0;
            this.btn_xem_DT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xem_DT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xem_DT.ForeColor = System.Drawing.Color.White;
            this.btn_xem_DT.Location = new System.Drawing.Point(498, 15);
            this.btn_xem_DT.Name = "btn_xem_DT";
            this.btn_xem_DT.Size = new System.Drawing.Size(150, 50);
            this.btn_xem_DT.TabIndex = 25;
            this.btn_xem_DT.Text = "Xem";
            this.btn_xem_DT.UseVisualStyleBackColor = false;
            this.btn_xem_DT.Click += new System.EventHandler(this.btn_xem_DT_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_thongke_DT);
            this.panel7.Controls.Add(this.dateTimePicker_CheckOut);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.dateTimePicker_CheckIn);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1343, 199);
            this.panel7.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.label16.Location = new System.Drawing.Point(492, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 33);
            this.label16.TabIndex = 0;
            this.label16.Text = "DOANH THU";
            // 
            // dateTimePicker_CheckIn
            // 
            this.dateTimePicker_CheckIn.Location = new System.Drawing.Point(54, 93);
            this.dateTimePicker_CheckIn.Name = "dateTimePicker_CheckIn";
            this.dateTimePicker_CheckIn.Size = new System.Drawing.Size(340, 39);
            this.dateTimePicker_CheckIn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "đến";
            // 
            // dateTimePicker_CheckOut
            // 
            this.dateTimePicker_CheckOut.Location = new System.Drawing.Point(568, 93);
            this.dateTimePicker_CheckOut.Name = "dateTimePicker_CheckOut";
            this.dateTimePicker_CheckOut.Size = new System.Drawing.Size(340, 39);
            this.dateTimePicker_CheckOut.TabIndex = 3;
            // 
            // btn_thongke_DT
            // 
            this.btn_thongke_DT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(41)))), ((int)(((byte)(29)))));
            this.btn_thongke_DT.FlatAppearance.BorderSize = 0;
            this.btn_thongke_DT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke_DT.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thongke_DT.ForeColor = System.Drawing.Color.White;
            this.btn_thongke_DT.Location = new System.Drawing.Point(976, 92);
            this.btn_thongke_DT.Name = "btn_thongke_DT";
            this.btn_thongke_DT.Size = new System.Drawing.Size(150, 50);
            this.btn_thongke_DT.TabIndex = 26;
            this.btn_thongke_DT.Text = "Thống kê";
            this.btn_thongke_DT.UseVisualStyleBackColor = false;
            this.btn_thongke_DT.Click += new System.EventHandler(this.btn_thongke_DT_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 758);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_thongke.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKe)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_thongke;
        private System.Windows.Forms.DataGridView dgv_ThongKe;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_xem_DT;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_thongke_DT;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_CheckIn;
    }
}