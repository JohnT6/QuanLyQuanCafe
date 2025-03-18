using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class frmTableManager: Form
    {
        public frmTableManager()
        {
            InitializeComponent();
        }

        // xử lí mở form con
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

        

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnSanPham.Height;
            panelSlide.Top = btnSanPham.Top;
            openChildForm(new SanPham());
        }

        

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnNhanVien.Height;
            panelSlide.Top = btnNhanVien.Top;
            openChildForm(new NhanVien());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnThongKe.Height;
            panelSlide.Top = btnThongKe.Top;
            openChildForm(new ThongKe());
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

        private void frmTableManager_Load(object sender, EventArgs e)
        {
            btnSanPham.PerformClick();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnBan.Height;
            panelSlide.Top = btnBan.Top;
            openChildForm(new Ban());
        }
    }
}
