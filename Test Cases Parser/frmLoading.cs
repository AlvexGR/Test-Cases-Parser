using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Cases_Generator
{
    public partial class frmLoading : Form
    {
        public frmLoading(int curLang)
        {
            InitializeComponent();
            if (curLang == 1)
            {
                lblDownload.Text = "Downloading";
            }
            else
            {
                lblDownload.Text = "Đang tải";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
