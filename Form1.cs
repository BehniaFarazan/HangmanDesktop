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
    public partial class BehniasHangmanGame : Form
    {
        private static List<String> usedLetters = new List<String>();
        private Mylogic mylogic = Mylogic.getInstance();
      //  private int BTN_AMOUNT = 26;
        private Button[] btnArray = new Button[26];
        Image galgePic;
        TextBox theWordShow, theScoreShow, theRoundShow;
        public BehniasHangmanGame()
        {
            InitializeComponent();
            mylogic.reset();
            mylogic.updateWord();
            galgePic = pictureBoxGalge.Image;
            theWordShow = textBoxShowWord;

            theScoreShow = textBoxShowScore;

            theRoundShow = textBoxRoundShow;
            theWordShow.Text=mylogic.getxWord();
            theScoreShow.Text = Convert.ToString(mylogic.getwordScore()); 
            theRoundShow.Text= Convert.ToString(mylogic.getRound());
        }
        public void updateDisplay()
        {
            theWordShow.Text = mylogic.getxWord();

            theScoreShow.Text= Convert.ToString(mylogic.getwordScore());

            switch (mylogic.getThisIsnrWrongGuess())
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
private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void guess(String guessLetter)
        {

            mylogic.guessLetter(guessLetter);

            updateDisplay();

        }
        private void button_Click(object sender, EventArgs e)
        {
           //Do something when a char button isc clicked test!
           Button button = (Button)sender;
           textBoxShowWord.Text = button.Text;
           
                String guessLetter = button.Text;
                guess(guessLetter);
                if (mylogic.isItIsCorrectGuess())
                {
                button.BackColor = Color.Green;
            }
                else
                {
                button.BackColor = Color.Red;
            }
              
            
            //button.Text = usedLetters[0];


        }
       

        private void textBoxShowHiddenWord_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void textBoxShowWord_TextChanged(object sender, EventArgs e)
        {

        }


    private void showUsedLetters(object sender, EventArgs e)
        {
           
            for (int i = 0; i < usedLetters.Count; i++) {

                textBoxShowUsedLetters.Text = usedLetters[i];

               
            }
        }

       

       
    }
}
