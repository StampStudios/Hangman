﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {

        string word = null;

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
            button1.Text = "Submit Letter";

            if (word == null)
            {
                word = textBox1.Text;
            }

            else
            {

            }
        }
    }
}
