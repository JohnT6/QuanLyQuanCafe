namespace QuanLyQuanCafe
{
    partial class MuaHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBox_TotalPrice = new System.Windows.Forms.TextBox();
            this.comboBoxSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.comboBoxFoodItems = new System.Windows.Forms.ComboBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelTables = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBox_Discount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(829, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 513);
            this.panel2.TabIndex = 10;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(520, 513);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 133;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 54;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 81;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtBox_Discount);
            this.panel3.Controls.Add(this.txtBox_TotalPrice);
            this.panel3.Controls.Add(this.comboBoxSwitchTable);
            this.panel3.Controls.Add(this.btnSwitchTable);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(829, 577);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 105);
            this.panel3.TabIndex = 11;
            // 
            // txtBox_TotalPrice
            // 
            this.txtBox_TotalPrice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBox_TotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtBox_TotalPrice.Location = new System.Drawing.Point(219, 4);
            this.txtBox_TotalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_TotalPrice.Name = "txtBox_TotalPrice";
            this.txtBox_TotalPrice.ReadOnly = true;
            this.txtBox_TotalPrice.Size = new System.Drawing.Size(119, 29);
            this.txtBox_TotalPrice.TabIndex = 7;
            this.txtBox_TotalPrice.Text = "0";
            this.txtBox_TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBoxSwitchTable
            // 
            this.comboBoxSwitchTable.FormattingEnabled = true;
            this.comboBoxSwitchTable.Location = new System.Drawing.Point(4, 34);
            this.comboBoxSwitchTable.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSwitchTable.Name = "comboBoxSwitchTable";
            this.comboBoxSwitchTable.Size = new System.Drawing.Size(99, 24);
            this.comboBoxSwitchTable.TabIndex = 6;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Location = new System.Drawing.Point(4, 4);
            this.btnSwitchTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(100, 32);
            this.btnSwitchTable.TabIndex = 5;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(347, 4);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(100, 57);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDownQuantity);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.comboBoxFoodItems);
            this.panel4.Controls.Add(this.comboBoxCategories);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(829, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 64);
            this.panel4.TabIndex = 12;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(395, 23);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownQuantity.TabIndex = 3;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(285, 4);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(100, 57);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // comboBoxFoodItems
            // 
            this.comboBoxFoodItems.FormattingEnabled = true;
            this.comboBoxFoodItems.Location = new System.Drawing.Point(4, 34);
            this.comboBoxFoodItems.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFoodItems.Name = "comboBoxFoodItems";
            this.comboBoxFoodItems.Size = new System.Drawing.Size(272, 24);
            this.comboBoxFoodItems.TabIndex = 1;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(4, 4);
            this.comboBoxCategories.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(272, 24);
            this.comboBoxCategories.TabIndex = 0;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // flowLayoutPanelTables
            // 
            this.flowLayoutPanelTables.AutoScroll = true;
            this.flowLayoutPanelTables.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelTables.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTables.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelTables.Name = "flowLayoutPanelTables";
            this.flowLayoutPanelTables.Size = new System.Drawing.Size(829, 682);
            this.flowLayoutPanelTables.TabIndex = 13;
            // 
            // txtBox_Discount
            // 
            this.txtBox_Discount.Location = new System.Drawing.Point(219, 39);
            this.txtBox_Discount.Name = "txtBox_Discount";
            this.txtBox_Discount.Size = new System.Drawing.Size(119, 22);
            this.txtBox_Discount.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giảm giá";
            // 
            // MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.flowLayoutPanelTables);
            this.Name = "MuaHang";
            this.Text = "MuaHang";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBox_TotalPrice;
        private System.Windows.Forms.ComboBox comboBoxSwitchTable;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox comboBoxFoodItems;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTables;
        private System.Windows.Forms.TextBox txtBox_Discount;
        private System.Windows.Forms.Label label1;
    }
}