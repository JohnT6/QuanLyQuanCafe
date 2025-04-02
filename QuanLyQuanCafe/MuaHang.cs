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
    public partial class MuaHang : Form
    {

        private SqlConnection conn;
        private string selectedTableID;
        public MuaHang()
        {
            InitializeComponent();
            conn = DatabaseConnection.GetConnection();
            LoadTables();
            LoadCategories();
            LoadSwitchTableComboBox();

            comboBoxCategories.SelectedIndexChanged += comboBoxCategories_SelectedIndexChanged;

        }

        private void LoadCategories()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM DanhMuc";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxCategories.DataSource = dt;
                comboBoxCategories.DisplayMember = "TenDanhMuc";
                comboBoxCategories.ValueMember = "MaDanhMuc";

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTables()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM Ban";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Clear existing table buttons
                flowLayoutPanelTables.Controls.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    Button btn = new Button() { Width = 100, Height = 100 };
                    btn.Text = row["TenBan"].ToString() + Environment.NewLine + row["TrangThai"].ToString();
                    btn.Click += Btn_Click;
                    btn.Tag = row["MaBan"];
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Arial", 10, FontStyle.Bold); // Chỉnh Font hỗ trợ tiếng Việt

                    switch (row["TrangThai"].ToString())
                    {
                        case "Trống":
                            btn.BackColor = ColorTranslator.FromHtml("#d6c3bd");
                            break;
                        default:
                            btn.BackColor = ColorTranslator.FromHtml("#44291d");
                            break;
                    }

                    flowLayoutPanelTables.Controls.Add(btn);
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void LoadSwitchTableComboBox()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM Ban";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxSwitchTable.DataSource = dt;
                comboBoxSwitchTable.DisplayMember = "TenBan";
                comboBoxSwitchTable.ValueMember = "MaBan";

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null && clickedButton.Tag != null)
            {
                selectedTableID = clickedButton.Tag.ToString();
                lsvBill.Tag = clickedButton.Tag;
                LoadBill(selectedTableID);
            }
        }

        private void CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (ListViewItem item in lsvBill.Items)
            {
                decimal thanhTien;
                if (decimal.TryParse(item.SubItems[3].Text, out thanhTien))
                {
                    totalPrice += thanhTien;
                }
            }

            decimal discount;
            if (!decimal.TryParse(txtBox_Discount.Text, out discount))
            {
                discount = 0;
            }
            decimal finalPrice = totalPrice - discount;

            txtBox_TotalPrice.Text = finalPrice.ToString("N0") + " đ";
        }

        private void LoadBill(string maBan)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"
            SELECT tp.TenThucPham, cthd.SoLuong, tp.Gia, (cthd.SoLuong * tp.Gia) AS ThanhTien
            FROM ChiTietHoaDon cthd
            JOIN HoaDon hd ON cthd.MaHoaDon = hd.MaHoaDon
            JOIN ThucPham tp ON cthd.MaThucPham = tp.MaThucPham
            WHERE hd.MaBan = @MaBan AND hd.NgayCheckOut IS NULL";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBan", maBan);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lsvBill.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row["TenThucPham"].ToString());
                    item.SubItems.Add(row["SoLuong"].ToString());
                    item.SubItems.Add(row["Gia"].ToString());
                    item.SubItems.Add(row["ThanhTien"].ToString());
                    lsvBill.Items.Add(item);
                }

                CalculateTotalPrice(); // Calculate and display total price

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadFoodItems(string maDanhMuc = null)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT * FROM ThucPham";
                if (!string.IsNullOrEmpty(maDanhMuc))
                {
                    query += " WHERE MaDanhMuc = @MaDanhMuc";
                }

                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(maDanhMuc))
                {
                    cmd.Parameters.AddWithValue("@MaDanhMuc", maDanhMuc);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxFoodItems.DataSource = dt;
                comboBoxFoodItems.DisplayMember = "TenThucPham";
                comboBoxFoodItems.ValueMember = "MaThucPham";

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thực phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private string GetSelectedTable()
        {
            return selectedTableID;
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string maBan = GetSelectedTable();
            if (string.IsNullOrEmpty(maBan))
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thêm món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maThucPham = comboBoxFoodItems.SelectedValue.ToString();
            int soLuong = (int)numericUpDownQuantity.Value;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"
                    DECLARE @MaHoaDon NVARCHAR(10)
                    IF EXISTS (SELECT 1 FROM HoaDon WHERE MaBan = @MaBan AND NgayCheckOut IS NULL)
                    BEGIN
                        SELECT @MaHoaDon = MaHoaDon FROM HoaDon WHERE MaBan = @MaBan AND NgayCheckOut IS NULL

                        IF EXISTS (SELECT 1 FROM ChiTietHoaDon WHERE MaHoaDon = @MaHoaDon AND MaThucPham = @MaThucPham)
                        BEGIN
                            UPDATE ChiTietHoaDon SET SoLuong = SoLuong + @SoLuong WHERE MaHoaDon = @MaHoaDon AND MaThucPham = @MaThucPham
                        END
                        ELSE
                        BEGIN
                            INSERT INTO ChiTietHoaDon (MaCT, MaHoaDon, MaThucPham, SoLuong) VALUES (@MaCT, @MaHoaDon, @MaThucPham, @SoLuong)
                        END
                    END
                    ELSE
                    BEGIN
                        SET @MaHoaDon = 'HD' + RIGHT('000000' + CAST(ABS(CHECKSUM(NEWID())) % 1000000 AS VARCHAR(6)), 6)
                        INSERT INTO HoaDon (MaHoaDon, MaBan, NgayCheckIn) VALUES (@MaHoaDon, @MaBan, GETDATE())
                        INSERT INTO ChiTietHoaDon (MaCT, MaHoaDon, MaThucPham, SoLuong) VALUES (@MaCT, @MaHoaDon, @MaThucPham, @SoLuong)
                    END
                            UPDATE Ban SET TrangThai = N'Có người' WHERE MaBan = @MaBan";
        

        SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBan", maBan);
                cmd.Parameters.AddWithValue("@MaThucPham", maThucPham);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                // Generate unique IDs for MaCT and MaHoaDon
                string maCT = "CT" + new Random().Next(100000, 999999).ToString();
                cmd.Parameters.AddWithValue("@MaCT", maCT);

                cmd.ExecuteNonQuery();

                LoadBill(maBan);
                LoadTables(); // Refresh the table status

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            string maBanCu = GetSelectedTable();
            string maBanMoi = comboBoxSwitchTable.SelectedValue.ToString();

            if (string.IsNullOrEmpty(maBanCu) || string.IsNullOrEmpty(maBanMoi))
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi chuyển.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"
            UPDATE HoaDon SET MaBan = @MaBanMoi WHERE MaBan = @MaBanCu AND NgayCheckOut IS NULL;
            UPDATE Ban SET TrangThai = N'Trống' WHERE MaBan = @MaBanCu;
            UPDATE Ban SET TrangThai = N'Có người' WHERE MaBan = @MaBanMoi;";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBanCu", maBanCu);
                cmd.Parameters.AddWithValue("@MaBanMoi", maBanMoi);

                cmd.ExecuteNonQuery();

                LoadTables();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuyển bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string maBan = GetSelectedTable();
            if (string.IsNullOrEmpty(maBan))
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị MessageBox xác nhận thanh toán
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Lấy giá trị tổng tiền từ txtBox_TotalPrice
                decimal tongTien;
                if (!decimal.TryParse(txtBox_TotalPrice.Text.Replace(" đ", "").Replace(",", ""), out tongTien))
                {
                    tongTien = 0;
                }

                // Cập nhật giá trị TongTien và NgayCheckOut trong bảng HoaDon
                string query = @"
            UPDATE HoaDon 
            SET TongTien = @TongTien, NgayCheckOut = GETDATE() 
            WHERE MaBan = @MaBan AND NgayCheckOut IS NULL;
            UPDATE Ban 
            SET TrangThai = N'Trống' 
            WHERE MaBan = @MaBan";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaBan", maBan);
                cmd.Parameters.AddWithValue("@TongTien", tongTien);

                cmd.ExecuteNonQuery();

                LoadTables();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategories.SelectedValue != null)
            {
                string maDanhMuc = comboBoxCategories.SelectedValue.ToString();
                LoadFoodItems(maDanhMuc);
            }
        }
    }
}
