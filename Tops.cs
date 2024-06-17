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
          
        }

        private void radShirt1_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgTop.Image  = Properties.Resources.SHIRT1__1_;
            form1.imgTop.Visible = true;
            form1.imgShirt2.Visible = false; 
        }

        private void radShirt2_CheckedChanged(object sender, EventArgs e)
        {
           form1.imgShirt2.Visible = true;
            form1.imgTop.Visible = false;
            form1.imgShirt2.Image = Properties.Resources.shirt2;
            

        }

        private void radShirt3_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgTop.Visible= true;
            form1.imgShirt2.Visible= false;
            form1.imgTop.Image = Properties.Resources.SHIRT3__1_;
        }

        private void tadShirt4_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgTop.Visible= true;
            form1.imgShirt2.Visible = false;
            form1.imgTop.Image = Properties.Resources.SHIRT4__1_;
        }
    }
}
