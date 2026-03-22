using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        
        List<string> words = new List<string>()
        {
            "computer", "science", "program", "network", "monitor"
        };

        string correctWord;
        StringBuilder displayWord = new StringBuilder();
        int attemptsLeft = 5;

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            Random rnd = new Random();
            correctWord = words[rnd.Next(words.Count)];

            displayWord.Clear();
            lstWrong.Items.Clear();
            attemptsLeft = 5;

            for (int i = 0; i < correctWord.Length; i++)
            {
                if (i == 0 || i == correctWord.Length - 1)
                    displayWord.Append(correctWord[i]);
                else
                    displayWord.Append('?');
            }

            lblWord.Text = displayWord.ToString();
            lblAttempts.Text = "Attempts Left: " + attemptsLeft;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.ToLower();

            if (string.IsNullOrWhiteSpace(guess))
                return;

            
            if (lstWrong.Items.Contains(guess))
            {
                MessageBox.Show("Already guessed!");
                return;
            }

            if (guess == correctWord)
            {
                lblWord.Text = correctWord;
                MessageBox.Show("Correct guess!");
                StartGame();
            }
            else
            {
                lstWrong.Items.Add(guess);
                attemptsLeft--;

                lblAttempts.Text = "Attempts Left: " + attemptsLeft;

                if (attemptsLeft == 0)
                {
                    MessageBox.Show("Game Over! The word was: " + correctWord);
                    StartGame();
                }
                else
                {
                    MessageBox.Show("Wrong guess! Try again.");
                }
            }

            txtGuess.Clear();
        }
    }
}