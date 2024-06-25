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
        Form5 form5;
        Form4 form4;
        private bool _drawTop = false;
        private Timer animationTimer;
        private int currentFrame;
        private Image[] frames;
        public Image ImgBottomImage { get; private set; }
        public Image ImgTopImage { get; private set; }

        public Form1()
        {
            InitializeComponent();
            InitializeAnimation();
        }

        // Event handler for when an item is unlocked in Form5
        public void ItemUnlockedFromMiniGame(int unlockedItem)
        {
            // Check if checkbox is checked before updating images
          //  if (chkWearNewItem.Checked)
          //  {
              //  switch (unlockedItem)
             //   {
              //      case 1:
             //           imgTest1.Image = Properties.Resources.UNLOCKABLE_BOTTOMS1;
              //         break;
               //     case 2:
               //         imgTest1.Image = Properties.Resources.BOW2_5;
              //          break;
                //    case 3:
                //        imgTest2.Image = Properties.Resources.handbag;
              //          break;
                //    case 4:
                //       imgTest2.Image = Properties.Resources.glassesV1;
              //          break;
               //     default:
               //         imgTest1.Image = null;
              //          imgTest2.Image = null;
              //          break;
               // }
           // }
        }

        public void chkWearNewItem_CheckedChanged(object sender, EventArgs e)
        {
           if (form5.unlockedItem == 1)
            {
                imgBottom.Image = Properties.Resources.UNLOCKABLE_BOTTOMS1;
            }
           else if (form5.unlockedItem ==2)
            {
                imgHead.Image = Properties.Resources.hiarbow;
            }
           else if (form5.unlockedItem == 3)
            {
               // img
            }
        }

        private void InitializeAnimation()
        {
            frames = new Image[]
            {
                Properties.Resources.BOW1,
                Properties.Resources.BOW1_1,
                Properties.Resources.BOW1_5,
                Properties.Resources.BOW2,
                Properties.Resources.BOW2_5,
                Properties.Resources.BOW3,
                Properties.Resources.BOW3_5,
                Properties.Resources.BOW4_5,
                Properties.Resources.BOW4_7,
                Properties.Resources.BOW5,
                Properties.Resources.BOW4_7,
                Properties.Resources.BOW4_5,
                Properties.Resources.BOW3_5,
                Properties.Resources.BOW3,
                Properties.Resources.BOW2_5,
                Properties.Resources.BOW2,
                Properties.Resources.BOW1_5,
                Properties.Resources.BOW1_1,
            };

            currentFrame = 0;
            imgBow.Image = frames[currentFrame];

            animationTimer = new Timer();
            animationTimer.Interval = 200;
            animationTimer.Tick += new EventHandler(OnAnimationTick);
            animationTimer.Start();
        }

        private void OnAnimationTick(object sender, EventArgs e)
        {
            currentFrame = (currentFrame + 1) % frames.Length;
            imgBow.Image = frames[currentFrame];
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            imgTop.Visible = true;
            imgBottom.Visible = true;
            imgTop.Image = Properties.Resources.SHIRT3__1_;
            imgBottom.Image = Properties.Resources.BOTTOM3;
        }

        private void btnAccessories_Click(object sender, EventArgs e)
        {
            ImgTopImage = Properties.Resources.SHIRT3__1_;
            ImgBottomImage = Properties.Resources.BOTTOM3;

            imgTop.Image = ImgTopImage;
            imgBottom.Image = ImgBottomImage;

            Form4 form4 = new Form4(this);
            form4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgTop.Parent = imgPerson;
            imgPerson.BackColor = Color.Transparent;
            imgBottom.Parent = imgPerson;
            imgBottom.BackColor = Color.Transparent;
            imgShirt2.Parent = imgPerson;
            imgShirt2.BackColor = Color.Transparent;
            imgHead.Parent = imgPerson;
            imgHead.BackColor = Color.Transparent;
        }

        private void btnViewTops_Click(object sender, EventArgs e)
        {
            var myForm = new Tops(this);
            myForm.Show();
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            var myForm = new Bottoms(this);
            myForm.Show();
        }

        private void btnShoes_Click(object sender, EventArgs e)
        {
            var myForm = new Shoes(this);
            myForm.Show();
        }

        private void btnMiniGame_Click(object sender, EventArgs e)
        {
            form5 = new Form5(this);
            form5.Show();
        }
    }
}