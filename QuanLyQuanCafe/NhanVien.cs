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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using QuanLyQuanCafe.Report;

namespace QuanLyQuanCafe
{
    public partial class NhanVien: Form
    {
        private SqlConnection conn;


        public NhanVien()
        {
            InitializeComponent();
            conn = DatabaseConnection.GetConnection();
            LoadDanhSach();
        }

        private void LoadDanhSach()
        {
            
            String queryTaiKhoan = "SELECT * FROM dbo.TaiKhoan";
            String queryNhanVien = "SELECT * FROM dbo.NhanVien";



            // Load dữ liệu vào dgvTaiKhoan
            SqlCommand cmdTaiKhoan = new SqlCommand(queryTaiKhoan, conn);
            DataTable dtTaiKhoan = new DataTable();
            SqlDataAdapter daTaiKhoan = new SqlDataAdapter(cmdTaiKhoan);
            daTaiKhoan.Fill(dtTaiKhoan);
            dgvTaiKhoan.DataSource = dtTaiKhoan;

            // Load dữ liệu vào dgv_NV
            SqlCommand cmdNhanVien = new SqlCommand(queryNhanVien, conn);
            DataTable dtNhanVien = new DataTable();
            SqlDataAdapter daNhanVien = new SqlDataAdapter(cmdNhanVien);
            daNhanVien.Fill(dtNhanVien);
            dgv_NV.DataSource = dtNhanVien;

           

            

        }

        private void btn_them_TK_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string TenTaiKhoan = txt_TenTK.Text;
                string TenHienThi = txt_TenHT.Text;
                string MatKhau = txt_MatKhau.Text;
                int LoaiTaiKhoan;

                if (!int.TryParse(txt_LoaiTK.Text, out LoaiTaiKhoan) || (LoaiTaiKhoan != 0 && LoaiTaiKhoan != 1))
                {
                    MessageBox.Show("Loại tài khoản chỉ được phép là 0 hoặc 1.");
                    return;
                }

                if (string.IsNullOrEmpty(TenTaiKhoan) || string.IsNullOrEmpty(TenHienThi) || string.IsNullOrEmpty(MatKhau))
                {
                    MessageBox.Show("Tên tài khoản, Tên hiển thị, Mật khẩu và loại tài khoản không được để trống.");
                    return;
                }

                string insertString = "INSERT INTO dbo.TaiKhoan (TenTaiKhoan, TenHienThi, MatKhau, LoaiTaiKhoan) VALUES (@TenTaiKhoan, @TenHienThi, @MatKhau, @LoaiTaiKhoan)";
                using (SqlCommand cmd = new SqlCommand(insertString, conn))
                {
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", TenTaiKhoan);
                    cmd.Parameters.AddWithValue("@TenHienThi", TenHienThi);
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                    cmd.Parameters.AddWithValue("@LoaiTaiKhoan", LoaiTaiKhoan);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm thành công.");
                        LoadDanhSach();
                        txt_TenTK.Clear();
                        txt_TenHT.Clear();
                        txt_MatKhau.Clear();
                        txt_LoaiTK.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại: Không có dòng nào bị ảnh hưởng.");
                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại: " + ex.Message);
            }
        }

        private void btn_xoa_TK_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                string TenTaiKhoan = dgvTaiKhoan.SelectedRows[0].Cells["TenTaiKhoan"].Value.ToString();
                string LoaiTaiKhoan = dgvTaiKhoan.SelectedRows[0].Cells["LoaiTaiKhoan"].Value.ToString();

                if (LoaiTaiKhoan.Equals("1", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Không thể xóa tài khoản admin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string deleteString = "DELETE FROM dbo.TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                    using (SqlCommand cmd = new SqlCommand(deleteString, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenTaiKhoan", TenTaiKhoan);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa thành công.");
                            LoadDanhSach();
                            txt_TenTK.Clear();
                            txt_TenHT.Clear();
                            txt_MatKhau.Clear();
                            txt_LoaiTK.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại: Không có dòng nào bị ảnh hưởng.");
                        }
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại: " + ex.Message);
                }
            }
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTaiKhoan.SelectedRows[0];
                txt_TenTK.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                txt_TenHT.Text = row.Cells["TenHienThi"].Value.ToString();
                txt_MatKhau.Text = row.Cells["MatKhau"].Value.ToString();
                txt_LoaiTK.Text = row.Cells["LoaiTaiKhoan"].Value.ToString();
            }
        }

        private void btn_sua_TK_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string TenTaiKhoan = txt_TenTK.Text;
                string TenHienThi = txt_TenHT.Text;
                string MatKhau = txt_MatKhau.Text;
                int LoaiTaiKhoan;

                if (!int.TryParse(txt_LoaiTK.Text, out LoaiTaiKhoan) || (LoaiTaiKhoan != 0 && LoaiTaiKhoan != 1))
                {
                    MessageBox.Show("Loại tài khoản chỉ được phép là 0 hoặc 1.");
                    return;
                }

                if (string.IsNullOrEmpty(TenTaiKhoan) || string.IsNullOrEmpty(TenHienThi) || string.IsNullOrEmpty(MatKhau))
                {
                    MessageBox.Show("Tên tài khoản, Tên hiển thị và Mật khẩu không được để trống.");
                    return;
                }

                string updateString = "UPDATE dbo.TaiKhoan SET TenHienThi = @TenHienThi, MatKhau = @MatKhau, LoaiTaiKhoan = @LoaiTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                using (SqlCommand cmd = new SqlCommand(updateString, conn))
                {
                    cmd.Parameters.AddWithValue("@TenTaiKhoan", TenTaiKhoan);
                    cmd.Parameters.AddWithValue("@TenHienThi", TenHienThi);
                    cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
                    cmd.Parameters.AddWithValue("@LoaiTaiKhoan", LoaiTaiKhoan);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa thành công.");
                        LoadDanhSach();
                        txt_TenTK.Clear();
                        txt_TenHT.Clear();
                        txt_MatKhau.Clear();
                        txt_LoaiTK.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại: Không có dòng nào bị ảnh hưởng.");
                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại: " + ex.Message);
            }
        }

        private void btn_xem_TK_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanReport report = new TaiKhoanReport();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.TaiKhoan", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "TaiKhoan");
                    report.SetDataSource(ds.Tables["TaiKhoan"]);
                }

                frmReportViewer reportViewer = new frmReportViewer();
                reportViewer.LoadReport(report);
                reportViewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearNhanVienFields()
        {
            txtBox_manv_NV.Clear();
            txtBox_tennv_NV.Clear();
            txtBox_gioitinh_NV.Clear();
            MTBox_sdt_NV.Clear();
            txtBox_diachi_NV.Clear();
            txtBox_email_NV.Clear();
            txtBox_chucvu_NV.Clear();
        }

        private void btn_them_NV_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string MaNV = txtBox_manv_NV.Text;
                string TenNV = txtBox_tennv_NV.Text;
                string GioiTinh = txtBox_gioitinh_NV.Text;
                string SDT = MTBox_sdt_NV.Text;
                string DiaChi = txtBox_diachi_NV.Text;
                string Email = txtBox_email_NV.Text;
                string ChucVu = txtBox_chucvu_NV.Text;

                if (string.IsNullOrEmpty(MaNV) || string.IsNullOrEmpty(TenNV) || string.IsNullOrEmpty(GioiTinh) || string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(DiaChi) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(ChucVu))
                {
                    MessageBox.Show("Các trường không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertString = "INSERT INTO dbo.NhanVien (MaNhanVien, TenNhanVien, ChucVu, GioiTinh, SoDienThoai, Email, DiaChi) VALUES (@MaNhanVien, @TenNhanVien, @ChucVu, @GioiTinh, @SoDienThoai, @Email, @DiaChi)";
                using (SqlCommand cmd = new SqlCommand(insertString, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNV);
                    cmd.Parameters.AddWithValue("@TenNhanVien", TenNV);
                    cmd.Parameters.AddWithValue("@ChucVu", ChucVu);
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@SoDienThoai", SDT);
                    cmd.Parameters.AddWithValue("@Email", SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChi);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công.");
                        LoadDanhSach();
                        ClearNhanVienFields();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại: Không có dòng nào bị ảnh hưởng.");
                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm nhân viên thất bại: " + ex.Message);
            }
        }

        private void btn_xoa_NV_Click(object sender, EventArgs e)
        {
            if (dgv_NV.SelectedRows.Count > 0)
            {
                string MaNV = dgv_NV.SelectedRows[0].Cells["MaNhanVien"].Value.ToString();

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string deleteString = "DELETE FROM dbo.NhanVien WHERE MaNhanVien = @MaNhanVien";
                    using (SqlCommand cmd = new SqlCommand(deleteString, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", MaNV);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa nhân viên thành công.");
                            LoadDanhSach();
                            ClearNhanVienFields();
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhân viên thất bại: Không có dòng nào bị ảnh hưởng.");
                        }
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa nhân viên thất bại: " + ex.Message);
                }
            }
        }

        private void btn_sua_NV_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string MaNV = txtBox_manv_NV.Text;
                string TenNV = txtBox_tennv_NV.Text;
                string GioiTinh = txtBox_gioitinh_NV.Text;
                string SDT = MTBox_sdt_NV.Text;
                string DiaChi = txtBox_diachi_NV.Text;
                string Email = txtBox_email_NV.Text;
                string ChucVu = txtBox_chucvu_NV.Text;

                if (string.IsNullOrEmpty(MaNV) || string.IsNullOrEmpty(TenNV) || string.IsNullOrEmpty(GioiTinh) || string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(DiaChi) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(ChucVu))
                {
                    MessageBox.Show("Các trường không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string updateString = "UPDATE dbo.NhanVien SET TenNhanVien = @TenNhanVien, ChucVu = @ChucVu, GioiTinh = @GioiTinh, SoDienThoai = @SoDienThoai, Email = @Email, DiaChi = @DiaChi WHERE MaNhanVien = @MaNhanVien";
                using (SqlCommand cmd = new SqlCommand(updateString, conn))
                {
                    cmd.Parameters.AddWithValue("@MaNhanVien", MaNV);
                    cmd.Parameters.AddWithValue("@TenNhanVien", TenNV);
                    cmd.Parameters.AddWithValue("@ChucVu", ChucVu);
                    cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    cmd.Parameters.AddWithValue("@SoDienThoai", SDT);
                    cmd.Parameters.AddWithValue("@Email", SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", DiaChi);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa nhân viên thành công.");
                        LoadDanhSach();
                        ClearNhanVienFields();
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên thất bại: Không có dòng nào bị ảnh hưởng.");
                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa nhân viên thất bại: " + ex.Message);
            }
        }

        private void btn_xem_NV_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVienReport report = new NhanVienReport();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.NhanVien", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "NhanVien");
                    report.SetDataSource(ds.Tables["NhanVien"]);
                }

                frmReportViewer reportViewer = new frmReportViewer();
                reportViewer.LoadReport(report);
                reportViewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_NV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_NV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_NV.SelectedRows[0];
                txtBox_manv_NV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtBox_tennv_NV.Text = row.Cells["TenNhanVien"].Value.ToString();
                txtBox_gioitinh_NV.Text = row.Cells["GioiTinh"].Value.ToString();
                MTBox_sdt_NV.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtBox_diachi_NV.Text = row.Cells["DiaChi"].Value.ToString();
                txtBox_email_NV.Text = row.Cells["Email"].Value.ToString();
                txtBox_chucvu_NV.Text = row.Cells["ChucVu"].Value.ToString();
            }
        }
    }
}
