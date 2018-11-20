﻿using System;
using System.Collections.Generic;
using System.Net;
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
       
      public String getWordFormWeb()
        {
            //List<String> words = new List<String>();
            
            
            data = wc.DownloadString("https://www.bold.dk/");
                                           // Removes all the special characters.
            data = data.Replace("<.+?>", " ").ToLower().Replace("[^a-z]", " ");
          
            // Remove words consisting of 1 letter.
            data.Replace(" [a-z] ", " ");

            // Remove words consisting of 2 letters.
            data.Replace(" [a-z][a-z] ", " ");

            // Removes æ, ø and å.
            data.Replace("&#198;", "æ"); // erstat HTML-tegn
            data.Replace("&#230;", "æ"); // erstat HTML-tegn
            data.Replace("&#216;", "ø"); // erstat HTML-tegn
            data.Replace("&#248;", "ø"); // erstat HTML-tegn
            data.Replace("&oslash;", "ø"); // erstat HTML-tegn
            data.Replace("&#229;", "å"); // erstat HTML-tegn

            words = data.Split(' ');
            // words = data.Split(¨"\n");
            // words.AddAll(new HashSet<>(Array.asList(data.Split(" "))));
           // words = data.Split("\n");
            //words.ToArray(new HashSet<String>(Array.(data.Split(" "))));
           
            return words[random.Next(0,words.Length-1)];

        }

    }
 

}