using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kórházi_betegkezelő_XAICMP
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Black;
            lbl2nyil.ForeColor = System.Drawing.Color.Red;
            lbl3nyil.ForeColor = System.Drawing.Color.Black;
            lbl4nyil.ForeColor = System.Drawing.Color.Black;
        }

        private void btnPáciens_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Red;
            lbl2nyil.ForeColor = System.Drawing.Color.Black;
            lbl3nyil.ForeColor = System.Drawing.Color.Black;
            lbl4nyil.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;
        }

        private void btnÖsszesPáciens_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Black;
            lbl2nyil.ForeColor = System.Drawing.Color.Black;
            lbl3nyil.ForeColor = System.Drawing.Color.Red;
            lbl4nyil.ForeColor = System.Drawing.Color.Black;
        }

        private void btnRandomTipp_Click(object sender, EventArgs e)
        {
            lbl1nyil.ForeColor = System.Drawing.Color.Black;
            lbl2nyil.ForeColor = System.Drawing.Color.Black;
            lbl3nyil.ForeColor = System.Drawing.Color.Black;
            lbl4nyil.ForeColor = System.Drawing.Color.Red;
        }

        private void btnKilépés_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
