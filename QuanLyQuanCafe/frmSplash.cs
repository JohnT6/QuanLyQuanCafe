using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyQuanCafe
{
    public partial class frmSplash: Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        int startPoint = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            startPoint += 10;
            progressBar.Value = startPoint;
            if (progressBar.Value == 100)
            {
                timer.Stop();
                progressBar.Value = 0;
                frmLogin login = new frmLogin();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
