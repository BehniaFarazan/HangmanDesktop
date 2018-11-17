using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGameDesktop
{
   
    class Mylogic
    {
       private static String  theWord;
       private static String xWord;
       private int thisIsnrWrongGuess, thisIsnrCorrectGuess, thisIsnrTotGuess;
       private int letterScore = 1000;
        private Boolean thisGameIsWon;
        private Boolean theGameIsLost;
        private Random random = new Random();
        private int wordScore;
        private int round;
        char thisLetter;
        private int highScore;
        private Boolean IsCorrectGuess = false;
        private List<String> possibleWord = new List<String>();

        public void add()
        {
            possibleWord.Add("BUSTICKET");
            possibleWord.Add("DTU");
            possibleWord.Add("MATCH");
            possibleWord.Add("COPENHAGEN");
            possibleWord.Add("KEYBOARD");
        }
        private  String getRandomPossibleWord()
        {
           add();
           return possibleWord[random.Next(possibleWord.Count)];
        }


        public void updateChoosenWord()
        {
            wordScore = theWord.Length * 1000;
            getxWord();
            round++;
        }
        public void updateWord()
        {
           // add();
          //  theWord = getRandomPossibleWord();
          //  wordScore = theWord.Length * 1000;
            getxWord();
            round++;
        }






        public String getTheWord() {
            theWord = getRandomPossibleWord();
            return theWord ;
        }


        public int getwordScore()
        {
            wordScore = theWord.Length * 1000;
            return wordScore;
        }

        public String getxWord()
        {
         
            for (int i =0; i< theWord.Length ; i++)
            {
                xWord = xWord + "#";
            }

            return xWord;
        }


        public int getThisIsnrWrongGuess()
        {
            return thisIsnrWrongGuess;
        }


        public void reset()
        {
            thisIsnrWrongGuess = 0;
            wordScore = 0;
            thisIsnrCorrectGuess = 0;
            thisIsnrTotGuess = 0;
            thisGameIsWon = false;
            theGameIsLost = false;
            IsCorrectGuess = false;
        }

        public void guessLetter(String letter)
        {
            thisIsnrTotGuess++;
            if (theWord.Contains(letter))
            {
                IsCorrectGuess = true;
                updateXWord(letter);
                if (thisIsnrCorrectGuess == theWord.Length)
                {
                    thisGameIsWon = true;
                }

            }
            else
            {
                IsCorrectGuess = false;
                wordScore -= letterScore;
                if (wordScore < 0)
                {
                    wordScore = 0;
                }
                thisIsnrWrongGuess = thisIsnrWrongGuess + 1;
                if (thisIsnrWrongGuess > 6)
                {
                    theGameIsLost = true;
                }
            }
        }

        public void updateXWord(String letter)
        {
            StringBuilder replacement = new StringBuilder(xWord);
            for (int n = 0; n < theWord.Length; n++)
            {
                thisLetter = theWord[0];
                if (thisLetter == letter[0])
                {
                    //  replacement.setCharAt(n, thisLetter);
                    replacement[n] = thisLetter;
                    // xWord = String.valueOf(replacement);
                    xWord = replacement.ToString();
                    thisIsnrCorrectGuess++;
                }
            }
        }

       public void guess(String guess)
        {

          guessLetter(guess);

          // updateDisplay();

        }

        public Boolean isItIsCorrectGuess()
        {
            return IsCorrectGuess;
        }

    }
}
