using System;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {

        string word = null;
        bool guessingWord = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by ItsTenchy and Tinsley_ for release on GitHub.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (word == null)
            {
                word = textBox1.Text;
                int uselessint;
                bool isDigitTextBox = int.TryParse(word, out uselessint);
                if (isDigitTextBox)
                {
                    MessageBox.Show("Please enter a word, " + uselessint.ToString() + " is not a word.");
                    button1.PerformClick();
                }
                else
                {
                    // Here for debug.
                    Console.WriteLine(word);
                    button1.Text = "Submit Letter";
                    guessingWord = true;
                }
            }

            else
            {

            }
        }
    }
}
