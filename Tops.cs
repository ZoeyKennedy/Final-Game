using Final_Game.Properties;
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
    public partial class Tops : Form
    {
        Form1 form1;
        public Tops(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            radShirt1.Checked = false;
        }

        private void radShirt1_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgTop.Image  = Properties.Resources.shirt1;

        }

        private void radShirt2_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgTop.Image = Properties.Resources.shirt2;
        }

        private void radShirt3_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgTop.Image = Properties.Resources.shirt3;
        }

        private void tadShirt4_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgTop.Image = Properties.Resources.shirt4;
        }
    }
}
