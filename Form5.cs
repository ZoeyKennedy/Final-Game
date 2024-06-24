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
    public partial class Form5 : Form
    {
        Form1 form1;
        int Guess;
        int GuessesRemaining;
        int secretNumber;
        int unlockedItem;

        Random generator;
       

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int GuessedNumber))
            {
                GuessesRemaining = GuessesRemaining - 1;
                lblGuessesRemaining.Text = "Guesses remaining: " + GuessesRemaining;

                if (GuessesRemaining == 0)
                {
                    lblGuessesRemaining.Text = "You're out of guesses!";

                    btnClose.Visible = true;
                }
                else
                {
                    if (Guess > secretNumber)
                    {
                        lblPrompt.Text = "Guess a lower number";

                    }
                    if (Guess < secretNumber)
                    {
                        lblPrompt.Text = "Guess a higher number";
                    }
                    if (Guess == secretNumber)
                    {
                        lblPrompt.Text = "You guessed the secret number!";
                        unlockedItem =generator.Next(1,5);

                        switch (unlockedItem)
                        {
                            case 1:
                                imgPrize.Image = Properties.Resources.BOTTOM2;
                                break;

                        }

                    }
                }
            }
            else
            {
                lblPrompt.Text = "Enter a valid number";
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           secretNumber = generator.Next(1,101);
            GuessesRemaining = 5;
            
        }
        public Form5(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1; 

            
            generator = new Random();
            secretNumber = generator.Next(1, 101);
            lblPrompt.Text = Convert.ToString(secretNumber);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}   





