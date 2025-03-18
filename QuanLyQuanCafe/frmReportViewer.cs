using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class frmReportViewer: Form
    {
        public frmReportViewer()
        {
            InitializeComponent();
        }

        public void LoadReport(ReportDocument report)
        {
            crystalReportViewer.ReportSource = report;
            crystalReportViewer.Refresh();
        }
    }
}
