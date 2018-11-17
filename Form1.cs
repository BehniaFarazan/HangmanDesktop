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
      
        public Form1()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            mylogic.reset();

         
            mylogic.updateWord();

            textBoxShowWord.Text = mylogic.getTheWord();
            textBoxShowHiddenWord.Text = mylogic.getxWord();
            textBoxShowScore.Text = Convert.ToString(mylogic.getwordScore());
            updateDisplay();

        }
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            //textBoxShowWord.Text = button.Text;

            String guessLetter = button.Text;
            mylogic.guess(guessLetter);
           
            if (mylogic.isItIsCorrectGuess())
            {
                button.BackColor = Color.Green;
            }
            else
            {
                button.BackColor = Color.Red;
            }
            button.Enabled = false;
            mylogic.showXWord();

            updateDisplay();
        }
        public void updateDisplay()
        {
          
            //textBoxShowWord.Text = mylogic.getTheWord();
            textBoxShowHiddenWord.Text = mylogic.getxWord();
            textBoxShowScore.Text = Convert.ToString(mylogic.getwordScore());
            // switch (test)
            switch (mylogic.getThisIsnrWrongGuess())
            {
                case 0:
                    //pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert0.png";
                    pictureBoxGalge.ImageLocation = "C:\\Users\\bf.it\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert0.png";

                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 1:
                    //   pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert1.png";
                    pictureBoxGalge.ImageLocation = "C:\\Users\\bf.it\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert1.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 2:
                    // pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert2.png";
                    pictureBoxGalge.ImageLocation = "C:\\Users\\bf.it\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert2.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 3:
                    //  pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert3.png";
                    pictureBoxGalge.ImageLocation = "C:\\Users\\bf.it\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert3.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 4:
                    // pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert4.png";
                    pictureBoxGalge.ImageLocation = "C:\\Users\\bf.it\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert4.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 5:
                    //  pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert5.png";
                    pictureBoxGalge.ImageLocation = "C:\\Users\\bf.it\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert5.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case 6:
                    //    pictureBoxGalge.ImageLocation = "C:\\Users\\Behnia\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert6.png";
                    pictureBoxGalge.ImageLocation = "C:\\Users\\bf.it\\source\\repos\\BehniaFarazan\\HangmanDesktop\\res\\drawable\\forkert6.png";
                    pictureBoxGalge.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;

            }
        }

    }
}
