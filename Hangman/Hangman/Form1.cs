using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {

        string textBox;
        string word = null;
        int wordLength;
        string letter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by ItsTenchy and Tinsley_ for release on GitHub.");
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox = textBox1.Text;

            if (textBox.Any(char.IsDigit))
            {
                MessageBox.Show("Please don't submit any numbers.");
            }

            else
            {
                if (word == null)
                {
                    word = textBox;
                    wordLength = word.Length;
                    button1.Text = "Submit Letter";
                    label1.Text = string.Concat(Enumerable.Repeat("_ ", wordLength));
                }

                else
                {
                    if (textBox.Length == 1)
                    {
                        letter = textBox;
                    }

                    else
                    {
                        MessageBox.Show("Please submit a letter.");
                    }
                }
            }
        }
    }
}
