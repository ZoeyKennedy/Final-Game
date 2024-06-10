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
    public partial class Form1 : Form
    {
        private bool _drawTop = false;

        public Form1()
        {
            InitializeComponent();
            

        }

        private void imgTop_Click(object sender, EventArgs e)
        {
            

        }

        private void btnButton_Click(object sender, EventArgs e)
        {
             imgTop.Image = Properties.Resources.top2;
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgTop.Parent = imgPerson;
            imgPerson.BackColor = Color.Transparent;
            

            // Load the image with a transparent background

        } 
    }
}
