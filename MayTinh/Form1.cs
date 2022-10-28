using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MayTinh
{
    public partial class fTinhToan : Form
    {
        public fTinhToan()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a + b;
            txtKQ.Text = c.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = a - b;
            txtKQ.Text = c.ToString();
        }
    }
}
