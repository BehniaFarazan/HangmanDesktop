using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGameDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
      
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          WordService wc = new WordService();
            Console.WriteLine("Words ISSSSS: "+ wc.getWordFormWeb());
            Application.Run(new Form1());
            
        }
        //
    }
}
