using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Game
{
    public partial class Form5 : Form
    {
        Form1 form1;
        int GuessesRemaining;
        int secretNumber;
        public int unlockedItem;
        Random generator;
        public int Prize;
        private Timer animationTimer;
        private int currentFrame;
        private Image[] frames;

        public Form5(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            generator = new Random();
            imgPrizeSquare.Visible = false;
            imgPrizeLong.Visible = false;
        }

        public int UnlockedItem
        {
            get { return unlockedItem; }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            secretNumber = generator.Next(1, 31);

            GuessesRemaining = 5;
            lblPrompt.Text = "Enter your guess!";
            lblGuessesRemaining.Text = "Guesses remaining: " + GuessesRemaining;
            lblSecretNumber.Text = secretNumber.ToString();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int GuessedNumber))
            {
                GuessesRemaining--;
                lblGuessesRemaining.Text = "Guesses remaining: " + GuessesRemaining;

                if (GuessesRemaining == 0 && GuessedNumber != secretNumber)
                {
                    lblGuessesRemaining.Text = "You're out of guesses!";
                    btnClose.Visible = true;
                    btnGuess.Visible = false; 
                    lblLine2.Text = "The secret number was " + secretNumber.ToString();
                }
                else
                {
                    if (GuessedNumber > secretNumber)
                    {
                        lblPrompt.Text = "Guess a lower number";
                    }
                    else if (GuessedNumber < secretNumber)
                    {
                        lblPrompt.Text = "Guess a higher number";
                    }

                    else
                    {
                        lblPrompt.Text = "You guessed the secret number!";
                     //   lblLine2.Visible = true;
                     //   lblLine2.Text = "Click the 'Guess' button again to reveal your unlocked item!";
                        unlockedItem = generator.Next(2, 5);

                      

                        switch (unlockedItem)
                        {
                           // case 1:
                          //      imgPrizeLong.Image = Properties.Resources.UNLOCKABLE_BOTTOMS1;
                         //       imgPrizeLong.Visible = true;
                            //    imgPrizeSquare.Visible = false;
                               // break;
                            case 2:
                                imgPrizeLong.Image = Properties.Resources.BOW2_5;
                                imgPrizeLong.Visible = true;
                                imgPrizeSquare.Visible = false;
                                break;
                            case 3:
                                imgPrizeSquare.Image = Properties.Resources.handbag;
                                imgPrizeSquare.Visible = true;
                                imgPrizeLong.Visible = false;
                                break;
                            case 4:
                                imgPrizeSquare.Image = Properties.Resources.glassesV1;
                                imgPrizeSquare.Visible = true;
                                imgPrizeLong.Visible = false;
                                break;
                        }
                        btnClose.Visible = true;
                    }
                    if (imgPrizeLong.Visible || imgPrizeSquare.Visible)
                    {
                        btnGuess.Visible = false;
                    }
                }
                
            }
          else
            {
                lblPrompt.Text = "Enter a valid number";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            {
             //   if (unlockedItem == 1)
             //   {
              //      form1.imgPrizeItemLong.Image = Properties.Resources.UNLOCKABLE_BOTTOMS1;
             //       form1.imgPrizeItemLong.Visible = true;
            //        form1.imgPrizeItemShort.Visible = false;
             //   }
                if (unlockedItem ==2)
                {
                    form1.imgPrizeItemLong.Image = Properties.Resources.BOW2_5;
                    form1.imgPrizeItemLong.Visible = true;
                    form1.imgPrizeItemShort.Visible = false;
                    form1.chkWearNewItem.Visible = true;
                }
                if (unlockedItem == 3)
                {
                    form1.imgPrizeItemShort.Image = Properties.Resources.handbag;
                    form1.imgPrizeItemLong.Visible = false;
                    form1.imgPrizeItemShort.Visible = true;
                    form1.chkWearNewItem.Visible = true;
                }
                if (unlockedItem == 4)
                {
                    form1.imgPrizeItemShort.Image = Properties.Resources.glassesV1;
                    form1.imgPrizeItemLong.Visible = false;
                    form1.imgPrizeItemShort.Visible = true;
                    form1.chkWearNewItem.Visible = true;
                }
            }
            this.Close();
            if (form1.imgPrizeItemLong.Visible == true)
            {
                form1.imgPrizeItemShort.Visible = false;
            }
            else
            {
                form1.imgPrizeItemLong.Visible = false;
            }

        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {

        }
    }
}