using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace HangmanGameDesktop
{
    public partial class Form1 : Form
    {
        Mylogic mylogic = new Mylogic();
        int test = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxShowWord.Text = mylogic.getTheWord();
            textBoxShowHiddenWord.Text = mylogic.makeWordHidden();
            updateDisplay();
        }
        private void button_Click(object sender, EventArgs e)
        {
            test++;
            updateDisplay();
        }
        public void updateDisplay()
        {
            //switch (mylogic.getThisIsnrWrongGuess())
                  switch (test)
            {
                case 0:
                    pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert0.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 1:
                    pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert1.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 2:
                    pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert2.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 3:
                    pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert3.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 4:
                    pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert4.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 5:
                    pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert5.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 6:
                    pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert6.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

            }
        }

    }
}
