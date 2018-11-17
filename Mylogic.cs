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

        public String getTheWord() {
            theWord = getRandomPossibleWord();
            return theWord ;
        }


        public String makeWordHidden()
        {
         
            for (int i =0; i< theWord.Length ; i++)
            {
                xWord = xWord + "#";
            }

            return xWord;
        }


        public int getThisIsnrWrongGuess()
        {

            return 0;
        }



        public void setTheWord(String theWord) {
            
        }

        public void changeGalgePic() {

        }
    }
}
