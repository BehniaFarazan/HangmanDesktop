using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Globalization;
using System.Net;
using System.Net.Sockets;
namespace HangmanGameDesktop
{
    class Mylogic
    {
        private static Mylogic instance = new Mylogic();
  

        private ArrayList UsedLetters = new ArrayList();
        private IList<String> possibleWord = new List<String>();
        private String theWord;
        private String xWord;
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


        public static Mylogic getInstance()
        {
            return instance;
        }

        public void setPossibleWord(List<String> list)
        {
            this.possibleWord = list;
        }

        public List<String> getPossibleWord(List<String> possibleWord)
        {
        return possibleWord;
        }
            //Find a shuffle method Collections.shuffle(possibleWord);
          

       
        public ArrayList getUsedLetters()
        {
            return UsedLetters;
        }

        public int getHighScore()
        {
            return highScore;
        }

        public String getxWord()
        {
            return xWord;
        }

        public String getTheWord()
        {
            //To Upper
            return theWord;
        }

        public int getRound()
        {
            return round;
        }

        public int getThisIsnrWrongGuess()
        {

            return thisIsnrWrongGuess;
        }

        public int getThisIsnrCorrectGuess()
        {

            return thisIsnrCorrectGuess;
        }

        public int getThisIsnrTotGuess()
        {

            return thisIsnrTotGuess;
        }

        public Boolean isItIsCorrectGuess()
        {
            return IsCorrectGuess;
        }

        public Boolean isThisGameIsWon()
        {

            return thisGameIsWon;
        }

        public Boolean isTheGameLost()
        {

            return theGameIsLost;
        }

        public Boolean isTheGameOver()
        {

            return theGameIsLost || thisGameIsWon;
        }


        public int getwordScore()
        {
            return wordScore;
        }


        private Mylogic()
        {
            UsedLetters = new ArrayList();
        }

        public void add()
        {
            possibleWord.Add("BUSTICKET");
            possibleWord.Add("TRAIN");
            possibleWord.Add("LONDON");
            possibleWord.Add("GOALLIST");
            possibleWord.Add("DTU");
            possibleWord.Add("FRANCE");
            possibleWord.Add("DANMARK");
            possibleWord.Add("CPU");
            possibleWord.Add("ROAD");
            possibleWord.Add("HEART");
            possibleWord.Add("BARCELONA");
            possibleWord.Add("LIVERPOOL");
            possibleWord.Add("FRANCE");
            possibleWord.Add("ANDROIDSTUDIO");
            possibleWord.Add("MATCH");
            possibleWord.Add("COPENHAGEN");
            possibleWord.Add("KEYBOARD");

        }

        private String getRandomPossibleWord()
        {
            
            return possibleWord[0];
        }
        public void setTheWord(String ChoosenWord)
        {
            this.theWord = ChoosenWord;
        }

        public void roundReset()
        {
            round = 0;
            highScore = 0;
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
        public void updateChoosenWord()
        {
            wordScore = theWord.Length * 1000;
            showXWord();
            round++;
        }
        public void updateWord()
        {
            add();
            theWord = getRandomPossibleWord();
            wordScore = theWord.Length * 1000;
            showXWord();
            round++;
        }

        public void calcHighscore()
        {
            highScore = highScore + (((theWord.Length * letterScore) - (letterScore * thisIsnrWrongGuess)));
            if (highScore <= 0)
            {
                highScore = 0;
            }
        }

        private void showXWord()
        {
            xWord = "";
            for (int n = 0; n < getTheWord().Length; n++)
            {
                // String letter = getTheWord().Substring(n, n ++);
                String letter = "fser";
                if (getUsedLetters().Contains(letter))
                {
                    xWord = xWord + letter;
                }
                else
                {
                    xWord = xWord + "#";
                }
            }
        }

        public void guessLetter(String letter)
        {
            thisIsnrTotGuess++;
            if (getTheWord().Contains(letter))
            {
                IsCorrectGuess = true;
                updateXWord(letter);
                if (thisIsnrCorrectGuess == getTheWord().Length)
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
                thisLetter = getTheWord()[0];
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

      
}
  
}
   