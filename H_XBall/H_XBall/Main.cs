using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_XBall
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            InitializeGUI();
        }

        private void InitializeGUI()
        {
            lbl_Period1.ForeColor = Color.Gray;
            lbl_Period2.ForeColor = Color.Gray;
            lbl_Overtime.ForeColor = Color.Gray;
        }

        private void lbl_Period1_Click(object sender, EventArgs e)
        {
            lbl_Period1.ForeColor = Color.Yellow;
            lbl_Period2.ForeColor = Color.Gray;
            lbl_Overtime.ForeColor = Color.Gray;
        }

        private void lbl_Period2_Click(object sender, EventArgs e)
        {
            lbl_Period1.ForeColor = Color.Gray;
            lbl_Period2.ForeColor = Color.Yellow;
            lbl_Overtime.ForeColor = Color.Gray;
        }

        private void lbl_Overtime_Click(object sender, EventArgs e)
        {
            lbl_Period1.ForeColor = Color.Gray;
            lbl_Period2.ForeColor = Color.Gray;
            lbl_Overtime.ForeColor = Color.Yellow;
        }

    }
}
