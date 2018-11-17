using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGameDesktop
{
   
    class Mylogic
    {
       private String  theWord;
       private static String xWord;



        public static String getTheWord() {
            return "TR";
        }

        public static String getThexWord()
        {
            return "";
        }
        public static String makeWordHidden()
        {
            xWord = getThexWord();
            for (int i =0; i< getTheWord().Length ; i++)
            {
                xWord = xWord + "#";
            }

            return xWord;
        }
        public void setTheWord(String theWord) {
            
        }

        public void changeGalgePic() {

        }
    }
}
