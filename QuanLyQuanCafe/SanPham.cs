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
using QuanLyQuanCafe.Report;

namespace QuanLyQuanCafe
{
    public partial class SanPham: Form
    {
        private SqlConnection conn;
        public SanPham()
        {
            InitializeComponent();
            conn = DatabaseConnection.GetConnection();
            LoadDanhSachDanhMuc();
            LoadDanhSachThucPham();
            LoadDanhMucComboBox();
        }

        private void LoadDanhSachDanhMuc()
        {
            String queryDanhMuc = "SELECT * FROM dbo.DanhMuc";
            SqlCommand cmdDanhMuc = new SqlCommand(queryDanhMuc, conn);
            DataTable dtDanhMuc = new DataTable();
            SqlDataAdapter daDanhMuc = new SqlDataAdapter(cmdDanhMuc);
            daDanhMuc.Fill(dtDanhMuc);
            dgv_DMSP.DataSource = dtDanhMuc;
        }

        private void ClearDanhMucFields()
        {
            txtBox_madanhmuc_DM.Clear();
            txtBox_tendanhmuc_DM.Clear();
        }

        private void LoadDanhSachThucPham()
        {
            String queryThucPham = "SELECT tp.MaThucPham, tp.TenThucPham, tp.Gia, dm.TenDanhMuc FROM dbo.ThucPham tp JOIN dbo.DanhMuc dm ON tp.MaDanhMuc = dm.MaDanhMuc";
            SqlCommand cmdThucPham = new SqlCommand(queryThucPham, conn);
            DataTable dtThucPham = new DataTable();
            SqlDataAdapter daThucPham = new SqlDataAdapter(cmdThucPham);
            daThucPham.Fill(dtThucPham);
            dgv_ThucPham.DataSource = dtThucPham;
        }

        private void LoadDanhMucComboBox()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT TenDanhMuc FROM dbo.DanhMuc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                comboBox_danhMucMonAnThucUong.Items.Clear();
                while (reader.Read())
                {
                    comboBox_danhMucMonAnThucUong.Items.Add(reader["TenDanhMuc"].ToString());
                }

                reader.Close();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_them_DM_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string MaDanhMuc = txtBox_madanhmuc_DM.Text;
                string TenDanhMuc = txtBox_tendanhmuc_DM.Text;

                if (string.IsNullOrEmpty(MaDanhMuc) || string.IsNullOrEmpty(TenDanhMuc))
                {
                    MessageBox.Show("Các trường không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertString = "INSERT INTO dbo.DanhMuc (MaDanhMuc, TenDanhMuc) VALUES (@MaDanhMuc, @TenDanhMuc)";
                using (SqlCommand cmd = new SqlCommand(insertString, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDanhMuc", MaDanhMuc);
                    cmd.Parameters.AddWithValue("@TenDanhMuc", TenDanhMuc);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm danh mục thành công.");
                        LoadDanhSachDanhMuc();
                        ClearDanhMucFields();
                    }
                    else
                    {
                        MessageBox.Show("Thêm danh mục thất bại: Không có dòng nào bị ảnh hưởng.");
                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm danh mục thất bại: " + ex.Message);
            }
        }

        private void btn_xoa_DM_Click(object sender, EventArgs e)
        {
            if (dgv_DMSP.SelectedRows.Count > 0)
            {
                string MaDanhMuc = dgv_DMSP.SelectedRows[0].Cells["MaDanhMuc"].Value.ToString();

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string deleteString = "DELETE FROM dbo.DanhMuc WHERE MaDanhMuc = @MaDanhMuc";
                    using (SqlCommand cmd = new SqlCommand(deleteString, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDanhMuc", MaDanhMuc);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa danh mục thành công.");
                            LoadDanhSachDanhMuc();
                            ClearDanhMucFields();
                        }
                        else
                        {
                            MessageBox.Show("Xóa danh mục thất bại: Không có dòng nào bị ảnh hưởng.");
                        }
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa danh mục thất bại: " + ex.Message);
                }
            }
        }

        private void btn_sua_DM_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string MaDanhMuc = txtBox_madanhmuc_DM.Text;
                string TenDanhMuc = txtBox_tendanhmuc_DM.Text;

                if (string.IsNullOrEmpty(MaDanhMuc) || string.IsNullOrEmpty(TenDanhMuc))
                {
                    MessageBox.Show("Các trường không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string updateString = "UPDATE dbo.DanhMuc SET TenDanhMuc = @TenDanhMuc WHERE MaDanhMuc = @MaDanhMuc";
                using (SqlCommand cmd = new SqlCommand(updateString, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDanhMuc", MaDanhMuc);
                    cmd.Parameters.AddWithValue("@TenDanhMuc", TenDanhMuc);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa danh mục thành công.");
                        LoadDanhSachDanhMuc();
                        ClearDanhMucFields();
                    }
                    else
                    {
                        MessageBox.Show("Sửa danh mục thất bại: Không có dòng nào bị ảnh hưởng.");
                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa danh mục thất bại: " + ex.Message);
            }
        }

        private void btn_xem_DM_Click(object sender, EventArgs e)
        {
            try
            {
                DanhMucReport report = new DanhMucReport();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.DanhMuc", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DanhMuc");
                    report.SetDataSource(ds.Tables["DanhMuc"]);
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

        private void dgv_DMSP_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DMSP.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_DMSP.SelectedRows[0];
                txtBox_madanhmuc_DM.Text = row.Cells["MaDanhMuc"].Value.ToString();
                txtBox_tendanhmuc_DM.Text = row.Cells["TenDanhMuc"].Value.ToString();
            }
        }

        private void ClearThucPhamFields()
        {
            txtBox_maThucPham.Clear();
            txtBox_tenThucPham.Clear();
            txtBox_giaThucPham.Clear();
            comboBox_danhMucMonAnThucUong.SelectedIndex = -1;
        }

        private void btn_Them_SP_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string MaThucPham = txtBox_maThucPham.Text;
                string TenThucPham = txtBox_tenThucPham.Text;
                decimal GiaThucPham;
                if (!decimal.TryParse(txtBox_giaThucPham.Text, out GiaThucPham))
                {
                    MessageBox.Show("Giá phải là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string TenDanhMuc = comboBox_danhMucMonAnThucUong.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(MaThucPham) || string.IsNullOrEmpty(TenThucPham) || string.IsNullOrEmpty(TenDanhMuc))
                {
                    MessageBox.Show("Các trường không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string queryMaDanhMuc = "SELECT MaDanhMuc FROM dbo.DanhMuc WHERE TenDanhMuc = @TenDanhMuc";
                SqlCommand cmdMaDanhMuc = new SqlCommand(queryMaDanhMuc, conn);
                cmdMaDanhMuc.Parameters.AddWithValue("@TenDanhMuc", TenDanhMuc);
                string MaDanhMuc = cmdMaDanhMuc.ExecuteScalar().ToString();

                string insertString = "INSERT INTO dbo.ThucPham (MaThucPham, TenThucPham, Gia, MaDanhMuc) VALUES (@MaThucPham, @TenThucPham, @Gia, @MaDanhMuc)";
                using (SqlCommand cmd = new SqlCommand(insertString, conn))
                {
                    cmd.Parameters.AddWithValue("@MaThucPham", MaThucPham);
                    cmd.Parameters.AddWithValue("@TenThucPham", TenThucPham);
                    cmd.Parameters.AddWithValue("@Gia", GiaThucPham);
                    cmd.Parameters.AddWithValue("@MaDanhMuc", MaDanhMuc);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm món ăn/thức uống thành công.");
                        LoadDanhSachThucPham();
                        ClearThucPhamFields();
                    }
                    else
                    {
                        MessageBox.Show("Thêm món ăn/thức uống thất bại: Không có dòng nào bị ảnh hưởng.");
                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm món ăn/thức uống thất bại: " + ex.Message);
            }
        }

        private void dgv_ThucPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_ThucPham.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_ThucPham.SelectedRows[0];
                txtBox_maThucPham.Text = row.Cells["MaThucPham"].Value.ToString();
                txtBox_tenThucPham.Text = row.Cells["TenThucPham"].Value.ToString();
                txtBox_giaThucPham.Text = row.Cells["Gia"].Value.ToString();
                comboBox_danhMucMonAnThucUong.SelectedItem = row.Cells["TenDanhMuc"].Value.ToString();
            }
        }

        private void btn_xoa_SP_Click(object sender, EventArgs e)
        {
            if (dgv_ThucPham.SelectedRows.Count > 0)
            {
                string MaThucPham = dgv_ThucPham.SelectedRows[0].Cells["MaThucPham"].Value.ToString();

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string deleteString = "DELETE FROM dbo.ThucPham WHERE MaThucPham = @MaThucPham";
                    using (SqlCommand cmd = new SqlCommand(deleteString, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaThucPham", MaThucPham);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa món ăn/thức uống thành công.");
                            LoadDanhSachThucPham();
                            ClearThucPhamFields();
                        }
                        else
                        {
                            MessageBox.Show("Xóa món ăn/thức uống thất bại: Không có dòng nào bị ảnh hưởng.");
                        }
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa món ăn/thức uống thất bại: " + ex.Message);
                }
            }
        }

        private void btn_sua_SP_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string MaThucPham = txtBox_maThucPham.Text;
                string TenThucPham = txtBox_tenThucPham.Text;
                decimal GiaThucPham;
                if (!decimal.TryParse(txtBox_giaThucPham.Text, out GiaThucPham))
                {
                    MessageBox.Show("Giá phải là một số hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string TenDanhMuc = comboBox_danhMucMonAnThucUong.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(MaThucPham) || string.IsNullOrEmpty(TenThucPham) || string.IsNullOrEmpty(TenDanhMuc))
                {
                    MessageBox.Show("Các trường không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string queryMaDanhMuc = "SELECT MaDanhMuc FROM dbo.DanhMuc WHERE TenDanhMuc = @TenDanhMuc";
                SqlCommand cmdMaDanhMuc = new SqlCommand(queryMaDanhMuc, conn);
                cmdMaDanhMuc.Parameters.AddWithValue("@TenDanhMuc", TenDanhMuc);
                string MaDanhMuc = cmdMaDanhMuc.ExecuteScalar().ToString();

                string updateString = "UPDATE dbo.ThucPham SET TenThucPham = @TenThucPham, Gia = @Gia, MaDanhMuc = @MaDanhMuc WHERE MaThucPham = @MaThucPham";
                using (SqlCommand cmd = new SqlCommand(updateString, conn))
                {
                    cmd.Parameters.AddWithValue("@MaThucPham", MaThucPham);
                    cmd.Parameters.AddWithValue("@TenThucPham", TenThucPham);
                    cmd.Parameters.AddWithValue("@Gia", GiaThucPham);
                    cmd.Parameters.AddWithValue("@MaDanhMuc", MaDanhMuc);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa món ăn/thức uống thành công.");
                        LoadDanhSachThucPham();
                        ClearThucPhamFields();
                    }
                    else
                    {
                        MessageBox.Show("Sửa món ăn/thức uống thất bại: Không có dòng nào bị ảnh hưởng.");
                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa món ăn/thức uống thất bại: " + ex.Message);
            }
        }

        private void btn_xem_SP_Click(object sender, EventArgs e)
        {
            try
            {
                ThucPhamReport report = new ThucPhamReport();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.ThucPham tp JOIN dbo.DanhMuc dm ON tp.MaDanhMuc = dm.MaDanhMuc", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ThucPham");
                    report.SetDataSource(ds.Tables["ThucPham"]);
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

        private void btn_timkiem_SP_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string searchTerm = txtBox_TimKiem.Text;

                if (string.IsNullOrEmpty(searchTerm))
                {
                    LoadDanhSachThucPham();
                    return;
                }

                string query = "SELECT tp.MaThucPham, tp.TenThucPham, tp.Gia, dm.TenDanhMuc FROM dbo.ThucPham tp JOIN dbo.DanhMuc dm ON tp.MaDanhMuc = dm.MaDanhMuc WHERE tp.TenThucPham LIKE @searchTerm";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                DataTable dtThucPham = new DataTable();
                SqlDataAdapter daThucPham = new SqlDataAdapter(cmd);
                daThucPham.Fill(dtThucPham);
                dgv_ThucPham.DataSource = dtThucPham;

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
