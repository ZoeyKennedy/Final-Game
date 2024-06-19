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
    public partial class Shoes : Form
    {
        Form1 form1;
        public Shoes(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Shoes_Load(object sender, EventArgs e)
        {

        }

        private void radShoe1_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgPerson.Image = Properties.Resources.shoes1;
        }

        private void radshoe2_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgPerson.Image = Properties.Resources.shoes2;
        }

        private void radshoe3_CheckedChanged(object sender, EventArgs e)
        {
            form1.imgPerson.Image= Properties.Resources.shoes3;
        }
    }
}
