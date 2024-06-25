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
            secretNumber = generator.Next(1, 51);

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
                        lblPrompt.Text = "You guessed the secret number! Click the 'Guess' button again to reveal your unlocked item!";
                        unlockedItem = generator.Next(1, 5);

                      

                        switch (unlockedItem)
                        {
                            case 1:
                                imgPrizeLong.Image = Properties.Resources.UNLOCKABLE_BOTTOMS1;
                                imgPrizeLong.Visible = true;
                                imgPrizeSquare.Visible = false;
                                break;
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
            form1.Update();
            {
                if (unlockedItem == 1)
                {
                    form1.imgTest1.Image = Properties.Resources.UNLOCKABLE_BOTTOMS1;
                }
                if (unlockedItem ==2)
                {
                    form1.imgTest1.Image = Properties.Resources.BOW2_5;
                }
                if (unlockedItem == 3)
                {
                    form1.imgTest2.Image = Properties.Resources.handbag;
                }
                if (unlockedItem == 4)
                {
                    form1.imgTest2.Image = Properties.Resources.glassesV1;
                }
            }
            this.Close();
            
        }
    }
}