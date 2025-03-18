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
using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class frmLogin : Form
    {

        private SqlConnection conn;
        public frmLogin()
        {
            InitializeComponent(); 
            conn = DatabaseConnection.GetConnection();
        }

        

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string TenTaiKhoan = txtUserName.Text;
            string MatKhau = txtPassWord.Text;

            if (string.IsNullOrEmpty(TenTaiKhoan) || string.IsNullOrEmpty(MatKhau))
            {
                MessageBox.Show("Tên tài khoản và mật khẩu không được để trống.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? loaiTaiKhoan = ValidateLogin(TenTaiKhoan, MatKhau);
            if (loaiTaiKhoan.HasValue)
            {
                if (loaiTaiKhoan.Value == 1)
                {
                    frmTableManager frmTableManager = new frmTableManager();
                    this.Hide();
                    frmTableManager.ShowDialog();
                    this.Show();
                }
                else if (loaiTaiKhoan.Value == 0)
                {
                    frmTableNhanVien frmTableNhanVien = new frmTableNhanVien();
                    this.Hide();
                    frmTableNhanVien.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? ValidateLogin(string TenTaiKhoan, string MatKhau)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT LoaiTaiKhoan FROM dbo.TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", TenTaiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassWord.Clear();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void checkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkShowPassword.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }
        }
    }
}
