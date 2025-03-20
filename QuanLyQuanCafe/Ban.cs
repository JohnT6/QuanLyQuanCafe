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
    public partial class Ban: Form
    {
        private SqlConnection conn;
        public Ban()
        {
            InitializeComponent();
            conn = DatabaseConnection.GetConnection();
            LoadDanhSachBan();
            LoadTrangThaiComboBox();
            CustomizeDataGridViewHeaders();
        }

        private void CustomizeDataGridViewHeaders()
        {
            dgv_Ban.Columns[0].HeaderText = "Mã Bàn";
            dgv_Ban.Columns[1].HeaderText = "Tên Bàn";
            dgv_Ban.Columns[2].HeaderText = "Trạng Thái";

            // Customize phần Header của dgv_Ban
            dgv_Ban.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#44291d");
            dgv_Ban.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Ban.EnableHeadersVisualStyles = false;

            // Cho thanh cuộn xuất hiện khi cần thiết
            dgv_Ban.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Ban.ScrollBars = ScrollBars.Both;

           
        }

        private void LoadDanhSachBan()
        {
            String queryBan = "SELECT * FROM dbo.Ban";
            SqlCommand cmdBan = new SqlCommand(queryBan, conn);
            DataTable dtBan = new DataTable();
            SqlDataAdapter daBan = new SqlDataAdapter(cmdBan);
            daBan.Fill(dtBan);
            dgv_Ban.DataSource = dtBan;
        }

        private void LoadTrangThaiComboBox()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT DISTINCT TrangThai FROM dbo.Ban";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                comboBox_trangThai.Items.Clear();
                while (reader.Read())
                {
                    comboBox_trangThai.Items.Add(reader["TrangThai"].ToString());
                }

                reader.Close();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu trạng thái: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBanFields()
        {
            txtBox_maBan.Clear();
            txtBox_tenBan.Clear();
            comboBox_trangThai.SelectedIndex = -1;
        }

        private void btn_them_Ban_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string MaBan = txtBox_maBan.Text;
                string TenBan = txtBox_tenBan.Text;
                string TrangThai = comboBox_trangThai.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(MaBan) || string.IsNullOrEmpty(TenBan) || string.IsNullOrEmpty(TrangThai))
                {
                    MessageBox.Show("Các trường không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertString = "INSERT INTO dbo.Ban (MaBan, TenBan, TrangThai) VALUES (@MaBan, @TenBan, @TrangThai)";
                using (SqlCommand cmd = new SqlCommand(insertString, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBan", MaBan);
                    cmd.Parameters.AddWithValue("@TenBan", TenBan);
                    cmd.Parameters.AddWithValue("@TrangThai", TrangThai);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm bàn thành công.");
                        LoadDanhSachBan();
                        ClearBanFields();
                    }
                    else
                    {
                        MessageBox.Show("Thêm bàn thất bại: Không có dòng nào bị ảnh hưởng.");
                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm bàn thất bại: " + ex.Message);
            }
        }

        private void dgv_Ban_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_Ban.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_Ban.SelectedRows[0];
                txtBox_maBan.Text = row.Cells["MaBan"].Value.ToString();
                txtBox_tenBan.Text = row.Cells["TenBan"].Value.ToString();
                comboBox_trangThai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
            }
        }

        private void btn_xoa_Ban_Click(object sender, EventArgs e)
        {
            if (dgv_Ban.SelectedRows.Count > 0)
            {
                string MaBan = dgv_Ban.SelectedRows[0].Cells["MaBan"].Value.ToString();

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string deleteString = "DELETE FROM dbo.Ban WHERE MaBan = @MaBan";
                    using (SqlCommand cmd = new SqlCommand(deleteString, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaBan", MaBan);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa bàn thành công.");
                            LoadDanhSachBan();
                            ClearBanFields();
                        }
                        else
                        {
                            MessageBox.Show("Xóa bàn thất bại: Không có dòng nào bị ảnh hưởng.");
                        }
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa bàn thất bại: " + ex.Message);
                }
            }
        }

        private void btn_sua_Ban_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string MaBan = txtBox_maBan.Text;
                string TenBan = txtBox_tenBan.Text;
                string TrangThai = comboBox_trangThai.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(MaBan) || string.IsNullOrEmpty(TenBan) || string.IsNullOrEmpty(TrangThai))
                {
                    MessageBox.Show("Các trường không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string updateString = "UPDATE dbo.Ban SET TenBan = @TenBan, TrangThai = @TrangThai WHERE MaBan = @MaBan";
                using (SqlCommand cmd = new SqlCommand(updateString, conn))
                {
                    cmd.Parameters.AddWithValue("@MaBan", MaBan);
                    cmd.Parameters.AddWithValue("@TenBan", TenBan);
                    cmd.Parameters.AddWithValue("@TrangThai", TrangThai);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa bàn thành công.");
                        LoadDanhSachBan();
                        ClearBanFields();
                    }
                    else
                    {
                        MessageBox.Show("Sửa bàn thất bại: Không có dòng nào bị ảnh hưởng.");
                    }
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa bàn thất bại: " + ex.Message);
            }
        }

        private void btn_xem_Ban_Click(object sender, EventArgs e)
        {
            try
            {
                BanReport report = new BanReport();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Ban", conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Ban");
                    report.SetDataSource(ds.Tables["Ban"]);
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
    }
}
