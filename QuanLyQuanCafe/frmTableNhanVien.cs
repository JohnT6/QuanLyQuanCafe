using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyQuanCafe
{
    public partial class frmTableNhanVien: Form
    {
        public frmTableNhanVien(string TenHienThi)
        {
            InitializeComponent();
            label_Name.Text = TenHienThi;
        }

        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm_AD.Controls.Add(childForm);
            panelChildForm_AD.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnMuaHang.Height;
            panelSlide.Top = btnMuaHang.Top;
            openChildForm(new MuaHang());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnDangXuat.Height;
            panelSlide.Top = btnDangXuat.Top;
            if (MessageBox.Show("Bạn có muốn đăng xuất", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
                this.Close();
            }
        }

        private void frmTableNhanVien_Load(object sender, EventArgs e)
        {
            btnMuaHang.PerformClick();
        }
    }
}
