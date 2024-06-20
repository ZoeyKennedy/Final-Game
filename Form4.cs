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
    public partial class Form4 : Form
    {
        Form1 form1;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void radGlassesV2_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgHead.Image = Properties.Resources.glassesV2;
            form1.imgHead.Visible = true;
        }

        private void radHat_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgHead.Image = Properties.Resources.hat;
            form1.imgHead.Visible = true;
        }

        private void radHairClip_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgHead.Image = Properties.Resources.hairclip;
            form1.imgHead.Visible = true;
        }

        private void radNoAccessories_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgHead.Visible = false;
        }
    }
}
