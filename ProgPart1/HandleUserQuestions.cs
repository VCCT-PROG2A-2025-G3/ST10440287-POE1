using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgPart1
{
    class HandleUserQuestions
    {
        private string question;
        private string userName;

        // Constructor to initialize the class variables
        public HandleUserQuestions(string question, string userName)
        {
            this.question = question;
            this.userName = userName;
        }
        public void ProcessQuestion()
        {
            // Check if question is null or empty/whitespace
            if (string.IsNullOrWhiteSpace(question))
            {
                Console.WriteLine("It seems you didn't ask a question. Please ask a question so I can assist you.");
                return; // Exit the method early
            }
            question = question.ToLower().Trim();

                // Using contains for more flexible matching
                if (question.Contains("how are you"))
                {
                    Console.WriteLine("I'm just a bot, but I'm fully operational and ready to help you stay safe online!");
                }
                else if (question.Contains("purpose") || question.Contains("what do you do"))
                {
                    Console.WriteLine("My purpose is to help South African citizens learn how to stay safe online by avoiding common cybersecurity threats.");
                }
                else if (question.Contains("what can i ask") || question.Contains("help") || question.Contains("topics"))
                {
                    Console.WriteLine("You can ask me about topics like:");
                    Console.WriteLine("- Password safety");
                    Console.WriteLine("- Phishing scams");
                    Console.WriteLine("- Safe browsing habits");
                }
                else if (question.Contains("password"))
                {
                    Console.WriteLine("Always use strong, unique passwords. Include letters, numbers, and symbols. Avoid using the same password across sites.");
                }
                else if (question.Contains("phish"))
                {
                    Console.WriteLine("Phishing is a scam where attackers trick you into giving up personal info. Never click suspicious links or attachments in emails.");
                }
                else if (question.Contains("safe browsing") || question.Contains("surf") || question.Contains("browser safety"))
                {
                    Console.WriteLine("Always check for HTTPS in the browser URL. Don't visit sketchy websites, and keep your browser and antivirus up to date.");
                }
                else
                {
                    // Prompt the user to rephrase their question
                    Console.WriteLine($"Sorry {userName}, I didn't quite understand that.");
                    Console.WriteLine("Could you please rephrase your question or ask about a specific topic like 'password safety', 'phishing', or 'safe browsing'?");
                }
            }
            
        }
    }




