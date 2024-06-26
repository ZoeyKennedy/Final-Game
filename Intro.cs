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
    public partial class Intro : Form
    {
        Form1 Form1;
        public Intro(Form1 form1)
        {

            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
