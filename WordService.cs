using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HangmanGameDesktop
{
    // List < String > words;
   
    class WordService
    {
        WebClient wc = new WebClient();
        //List<String> words;
        String[] words;
        String data;
        Random random = new Random();
       
      public String getWordFromWeb()
        {
            //List<String> words = new List<String>();


            // data = wc.DownloadString("http://www.mit.edu/~ecprice/wordlist.10000");
             data = wc.DownloadString("https://www.bold.dk/");
           // data = wc.DownloadString("https://ekstrabladet.dk/");
            words = data.Split(' ');



            data = Regex.Replace(data, @"(?></?\w+)(?>(?:[^>'""]+|'[^']*'|""[^""]*"")*)>", string.Empty);
            data = Regex.Replace(data, @"</?\w+((\s+\w+(\s*=\s*(?:"".*?""|'.*?'|[^'"">\s]+))?)+\s*|\s*)/?>", string.Empty);
            data = Regex.Replace(data, @"<[^>].+?>", string.Empty);
            data = Regex.Replace(data, @"[a-z]", string.Empty);
            // data = Regex.Replace(data, "<style>(.|\n)*?</style>", string.Empty);
            // data = Regex.Replace(data, @"<xml>(.|\n)*?</xml>", string.Empty);
            //data = Regex.Replace(data, @"<(.|\n)*?>", string.Empty);
            // Removes all the special characters.
            //data = data.Replace("<.+?>", " ").ToLower().Replace("[^a-z]", " ");
            // data = Regex.Replace(data, @"(?></?\w+)(?>(?:[^>'""]+|'[^']*'|""[^""]*"")*)>", string.Empty);


            // Remove words consisting of 1 letter.
            //data = Regex.Replace(data, "[a-z]", " ");

            // Remove words consisting of 2 letters.
            // data = Regex.Replace(data, @" [a-z][a-z] ", String.Empty);
            //data.Replace(@"<.*?>", "TEST");
            //  data.Replace(@"(?></?\w+)(?>(?:[^>'""]+|'[^']*'|""[^""]*"")*)>", "TEST");
            //data.Replace(@"(\<(\/)?(\w)*(\d)?\>)", "TEST");
            // Removes æ, ø and å.
            //data.Replace("&#198;", "æ"); // erstat HTML-tegn
            //data.Replace("&#230;", "æ"); // erstat HTML-tegn
            //data.Replace("&#216;", "ø"); // erstat HTML-tegn
            //data.Replace("&#248;", "ø"); // erstat HTML-tegn
            //data.Replace("&oslash;", "ø"); // erstat HTML-tegn
            //data.Replace("&#229;", "å"); // erstat HTML-tegn

            // words = data.Split('\n');
            words = data.Split(' ');
            //words.AddRange(new HashSet<String>(data.Split(' ')));
            // words = data.Split(¨"\n");
            //words.AddAll(new HashSet<>(Array.asList(data.Split(" "))));
            // words = data.Split("\n");
            //words.ToArray(new HashSet<String>(Array.(data.Split(" "))));

            //return words[140];
           
            return words[4];
        }

    }
 

}
