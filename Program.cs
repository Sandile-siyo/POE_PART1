using POE_PART1;
using System;

namespace POE_PART1
{
    class Program
    {
        static void Main(string[] args)
        {
            LogoAndVoice logoVoice = new LogoAndVoice();
            UserInterface ui = new UserInterface();
            ChatBotEngine bot = new ChatBotEngine();

            logoVoice.PlayVoiceAndDisplayLogo();

            string userName = ui.GetUserName();
            ui.DisplayWelcomeMessage(userName);

            ui.StartChat(userName, bot);

            Console.ReadKey();
        }
    }
}