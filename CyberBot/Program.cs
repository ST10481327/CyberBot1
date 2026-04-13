using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot

{//start of namespace
    public class Program

    {//start of public class
        static void Main(string[] args)
        {//start of main method 
            bool isCI = Environment.GetEnvironmentVariable("CI") == "true";

            new voice_greeting();
            new AsciiLogo();

            if (isCI)
            {// If running in CI environment, skip the interactive chatbot  
                Console.WriteLine("CI Mode: Skipping interactive chatbot.");
                return;
            }// Otherwise, start the interactive chatbot    

            human_interraction bot = new human_interraction();
            bot.Start();
        }//end of main method
    }//end of public class
}//start of namespace
