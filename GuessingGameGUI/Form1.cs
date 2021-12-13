using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameGUI
{
    public partial class Form1 : Form
    {
        // Initialize variables
        const int max = 100;
        const int min = 1;
        int randomNumber;
        public Form1()
        {
            InitializeComponent();
            // Generate initial random number from given range.
            Random rand = new Random();
            randomNumber = rand.Next(min, max);
            // The label uses placeholder text for easier viewing in design view in VS.
            // This clears the placeholder text while the program starts.
            lblResult.Text = "";
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            
            int guess;

            guess = Convert.ToInt32(txtGuessBox.Text);

            if (guess != randomNumber)
            {
                if (guess < randomNumber)
                {
                    // Guess lower than the generated number.
                    lblResult.Text = "Guess Higher...";
                }
                else if (guess > randomNumber)
                {
                    // Guess higher than generated number.
                    lblResult.Text = "Guess Lower...";
                }
            }
            else if (guess == randomNumber)
            {
                lblResult.Text = "CORRECT!";
            }

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            // Restarts the random number generator to generate a new number within the given range
            Random rand = new Random();
            randomNumber = rand.Next(min, max);
            txtGuessBox.Clear();
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
