using System;

namespace POE_PART1
{
    public class UserInterface
    {
        public string GetUserName()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Enter Your Name: ");
            string userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name cannot be empty. Please enter your name: ");
                Console.ResetColor();
                userName = Console.ReadLine();
            }

            return userName;
        }

        public void DisplayWelcomeMessage(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nWelcome, {userName}!!!");
            Console.WriteLine("I'm your Cyber Bot. I’m here to help you stay safe online.");
            Console.ResetColor();
        }

        public void StartChat(string userName, ChatBotEngine bot)
        {
            bot.HandleUserInteraction(userName);
        }
    }
}