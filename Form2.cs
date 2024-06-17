using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Game
{ 
    public partial class Bottoms : Form
    {
        Form1 form1;
        public Bottoms(Form1 form1)
        {
            
            InitializeComponent();
            this.form1 = form1;
        }

        private void imgbtm1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgBottom.Visible = true;
            form1.imgBottom.Image = Properties.Resources.BOTTOM1;
        }

        private void radbtm2_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgBottom.Visible = true;
            form1.imgBottom.Image = Properties.Resources.BOTTOM2;
        }

        private void radbtm3_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgBottom.Visible = true;
            form1.imgBottom.Image = Properties.Resources.BOTTOM3;
        }

        private void radbtn1_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgBottom.Visible = true;
            form1.imgBottom.Image = Properties.Resources.BOTTOM4;
        }
    }
}
