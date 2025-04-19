using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgPart1
{
    class BotAnswers
    {
        public static void TypeText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write("Bot: ");
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(25); // Delay in milliseconds (25ms per character)
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
