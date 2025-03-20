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
    public partial class ThongKe: Form
    {
        private SqlConnection conn;
        public ThongKe()
        {
            InitializeComponent();
            conn = DatabaseConnection.GetConnection();
            
        }

        private void CustomizeDataGridViewHeaders()
        {
            dgv_ThongKe.Columns[0].HeaderText = "Ngày Check In";
            dgv_ThongKe.Columns[1].HeaderText = "Ngày Check Out";
            dgv_ThongKe.Columns[2].HeaderText = "Tên Bàn";
            dgv_ThongKe.Columns[3].HeaderText = "Thành Tiền";


            // Customize phần Header của dgv_Ban
            dgv_ThongKe.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#44291d");
            dgv_ThongKe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_ThongKe.EnableHeadersVisualStyles = false;

            // Cho thanh cuộn xuất hiện khi cần thiết
            dgv_ThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ThongKe.ScrollBars = ScrollBars.Both;


        }

        private void LoadThongKe(DateTime fromDate, DateTime toDate)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"
                    SELECT hd.NgayCheckIn, hd.NgayCheckOut, b.TenBan, hd.TongTien
                    FROM dbo.ChiTietHoaDon cthd
                    JOIN dbo.HoaDon hd ON cthd.MaHoaDon = hd.MaHoaDon
                    JOIN dbo.Ban b ON hd.MaBan = b.MaBan
                    JOIN dbo.ThucPham tp ON cthd.MaThucPham = tp.MaThucPham
                    WHERE hd.NgayCheckIn >= @FromDate AND hd.NgayCheckOut <= @ToDate
                    GROUP BY hd.NgayCheckIn, hd.NgayCheckOut, b.TenBan, hd.TongTien";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);
                DataTable dtThongKe = new DataTable();
                SqlDataAdapter daThongKe = new SqlDataAdapter(cmd);
                daThongKe.Fill(dtThongKe);
                dgv_ThongKe.DataSource = dtThongKe;

                CustomizeDataGridViewHeaders();

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thongke_DT_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker_CheckIn.Value;
            DateTime toDate = dateTimePicker_CheckOut.Value;
            LoadThongKe(fromDate, toDate);
        }

        private void btn_xem_DT_Click(object sender, EventArgs e)
        {
            try
            {
                ThongKeReport report = new ThongKeReport();
                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT hd.NgayCheckIn, hd.NgayCheckOut, b.TenBan, hd.TongTien
                    FROM dbo.ChiTietHoaDon cthd
                    JOIN dbo.HoaDon hd ON cthd.MaHoaDon = hd.MaHoaDon
                    JOIN dbo.Ban b ON hd.MaBan = b.MaBan
                    JOIN dbo.ThucPham tp ON cthd.MaThucPham = tp.MaThucPham
                    WHERE hd.NgayCheckIn >= @FromDate AND hd.NgayCheckOut <= @ToDate
                    GROUP BY hd.NgayCheckIn, hd.NgayCheckOut, b.TenBan, hd.TongTien", conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", dateTimePicker_CheckIn.Value);
                    cmd.Parameters.AddWithValue("@ToDate", dateTimePicker_CheckOut.Value);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "ThongKe");
                    report.SetDataSource(ds.Tables["ThongKe"]);
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
