using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Media;
using System.IO;

namespace ProgPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            string wavPath = @"C:\Users\paras\source\repos\ProgPart1\ProgPart1\Welcome.wav";

            if (File.Exists(wavPath))
            {
                new Music(wavPath).Play();
            }
            else
            {
                Console.WriteLine("WAV file not found at: " + wavPath);
            }

            string asciiArt = @"
                
          %%%%%%%%%%%%%%%%%%%%%%%%%%*+++*%%%%%%%%%%%%%%%%%%%%%%%%%%
          %%%%%%%%%%%%%%%%%%%%%%%*+++++++++*%%%%%%%%%%%%%%%%%%%%%%%
          %%%%%%%%%%%%%%%%%%%#++++++#%%%#++++++#%%%%%%%%%%%%%%%%%%%
          %%%%%%%%%%%%%%%#+++++++%%%%%%%%%%%+++++++#%%%%%%%%%%%%%%%
  %%%%%%%%%%%%%%%%%%*++++++++%%%%%%%%%%%%%%%%%%%++++++++*#%%%%%%%%%%%%%%%%%%
  %%%%%%%%%##**++++++++++#%%%%%%%%%%%+++++%%%%%%%%%%%*++++++++++**##%%%%%%%%%
  %%++++++++++++++#%%%%%%%%%%%%%%%%*+++++*%%%%%%%%%%%%%%%%#++++++++++++++%%%%
  %%+++#%%%%%%%%%%%%%%%%%%%%%%%%%%%%+++++%%%%%%%%%%%%%%%%%%%%%%%%%%%%#+++%%%%
  %%+++%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%+++%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%+++%%%%
  %%+++%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%+++%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%+++%%%%
  %%+++%%%%%%%%%%%%%%%%%%*+++++++++++++++++++++++++*%%%%%%%%%%%%%%%%%%+++%%%%
  %%*++%%%%%%%%%%%%%%%*+++++++++++++++++++++++++++++++*%%%%%%%%%%%%%%%++*%%%%
  %%*++#%%%%%%%%%%%%%+++*%%%%%%%%%%%%%%%%%%%%%%%%%%%*+++%%%%%%%%%%%%%#++*%%%%
   %%++*%%%%%%%%%%%%*++#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#++*%%%%%%%%%%%%*++%%%%%
   %%+++%%%%%%%%%%%#+++#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#+++#%%%%%%%%%%%+++%%%%%
   %%+++%%%%%%%%%++++++#%%%%#....:%%%%%%%%%-....+%%%%#++++++%%%%%%%%%+++%%%%%
   %%+++%%%%%%%%%++++++#%%%%=.....*%%%%%%%#.....:%%%%#++++++%%%%%%%%%+++%%%%%
   %%%++**%%%%%%%%++++++#%%%%%=...+%%%%%%%%%#...:%%%%%#++++++%%%%%%%%*++%%%%%
   %%+++%%%%%%%%++++++#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#++++++%%%%%%%%+++%%%%%%
   %%%*++#%%%%%%%++++++#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#++++++%%%%%%%#++*%%%%%
    %%%+++%%%%%%%%%%+++#%%%%%%%%+++++++++++++%%%%%%%%#+++%%%%%%%%%%+++%%%%%
    %%%*++*%%%%%%%%%*++#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#++*%%%%%%%%%*++*%%%%
     %%%+++%%%%%%%%%%+++*%%%%%%%%%%%%%%%%%%%%%%%%%%%*+++%%%%%%%%%%+++%%%%
      %%%+++%%%%%%%%%%*+++++++++++++++++++++++++++++++*%%%%%%%%%%+++%%%%
       %%*++*%%%%%%%%%%%%#*+++++++++++++++++++++++*#%%%%%%%%%%%%*++*%%%
        %%+++#%%%%%%%%%%%#+++++++++%%%%%%%+++++++++*%%%%%%%%%%%#+++%%%
         %%+++#%%%%%%%%*++++++++++%%*+++*%%++++++++++*%%%%%%%%#+++%%%
          %%+++*%%%%%#+++++++++++=%%+++++%%=+++++++++++#%%%%%#+++%%%
           %%+++*%%%*++++++++++++#%%%%%%%%%%*+++++++++++*%%%*+++%%%
            %%%*+++%#++++++++++++#%%%%%%%%%%%%++++++++++++*%+++*%%
             %%#++++++++++++++++#%%%%+++%%%%%++++++++++++++++#%%
              %%+++++++++++++++%%%%%+++%%%%%+++++++++++++++%%%
                %%#+++++++++++++%%%%%#+#%%%%%+++++++++++++*%%
                 %%%*+++++++++++#%%%%%%%%%%%%++++++++++++%%
                   %%%*++++++++++###########+++++++++++%%
                    %%%*+++++++++++++++++++++++++++*%%
                      %%%%+++++++++++++++++++++++#%%
                        %%%#+++++++++++++++++#%%
                           %%%%#+++++++++++#%%%
                             %%%%#+++#%%%%
                                %%%%%%%%%
                
            ";
            Console.WriteLine(asciiArt);

            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("===========================================");
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name cannot be empty. Please enter your name:");
                Console.ResetColor();
                name = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHey there {name}!!! I'm your Cybersecurity Awareness Assistant.");
            Console.WriteLine($"Nice to meet you, {name}!\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            BotAnswers.TypeText("Let’s learn how to stay safe online!", ConsoleColor.Green);
            Console.ResetColor();

            HandleUserQuestions handler = new HandleUserQuestions("", name);

            while (true)
            {
                Console.Write("\n\n");
                Console.Write("                                                                 ");
                Console.Write("You: ");
                string question = Console.ReadLine();

                if (string.Equals(question, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nGoodbye! Stay safe online!");
                    break;
                }

                handler = new HandleUserQuestions(question, name);
                handler.ProcessQuestion();
            }
        }
    }
}

