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
            this.Load += new EventHandler(Form4_Load);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            if (form1.ImgBottomImage != null && form1.ImgTopImage !=null)
            {

                string bottomImageName = GetImageName(form1.ImgBottomImage);
                string topImageName = GetImageName(form1.ImgTopImage);

                Console.WriteLine($"Comparing images: Bottom = {bottomImageName}, Top = {topImageName}");

                if (bottomImageName == "BOTTOM1" && topImageName == "SHIRT3__1_")
                {
                    imgUnlockedAccessories.Image = Properties.Resources.glassesV1;
                    Console.WriteLine("Condition met: Images matched.");
                }

                else
                {
                    // Debugging: Log that the condition is not met
                    Console.WriteLine("Condition not met: Images did not match.");
                }
            }
            else
            {
                // Debugging: Log that one or both images are null
                Console.WriteLine("Condition not checked: One or both images are null.");
            
        }

        }
        private string GetImageName(Image image)
        {
            if (image == Properties.Resources.BOTTOM1) return "BOTTOM1";
            if (image == Properties.Resources.SHIRT3__1_) return "SHIRT3__1_";
            // Add other comparisons as needed
            return string.Empty;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
