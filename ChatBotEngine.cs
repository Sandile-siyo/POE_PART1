using System;
using System.Collections.Generic;
using System.Threading;

namespace POE_PART1
{
    public class ChatBotEngine
    {
        public void HandleUserInteraction(string userName)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\n{userName}: ");
                string userInput = Console.ReadLine();
                Console.ResetColor();

                if (userInput.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    TypeTextSlowly("Cyber Bot: Goodbye!, it was nice chating with you remember to Stay safe online.");
                    break;
                }

                string response = Get_Response_ForUser(userInput);
                TypeTextSlowly($"Cyber Bot: {response}");

                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Blue;
                TypeTextSlowly("\nCyber Bot: If you have any other questions, feel free to ask. Otherwise, type 'exit' to end the conversation.");
            }
        }

        private string Get_Response_ForUser(string TheUsersInput)
        {
            var usersLowercaseInput = TheUsersInput.ToLower();
            var AllTheResponses = new List<object[]>();

            AllTheResponses.Add(new object[] {
                new List<string>{"how are you", "who are you", "you good"},
                "I'm just a machine.but i'm here to help you stay safe."
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"what's your purpose", "purpose", "aim", "goal"},
                "My purpose is to help you learn about cybersecurity and stay safe online"
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"password", "secure password", "strong password"},
                "Password Safety Tips:\n" +
                "1. Use long passwords (at least 12 characters)\n" +
                "2. Include numbers, symbols, and both uppercase and lowercase letters\n" +
                "3. Don't use personal information or common words\n" +
                "4. Use a unique password for each account\n" +
                "5. Consider using a password manager to keep track of your passwords"
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"phishing", "fake email", "suspicious email"},
                "Phishing Awareness:\n" +
                "1. Be wary of emails asking for personal information\n" +
                "2. Check the sender's email address carefully\n" +
                "3. Hover over links to see the actual URL before clicking\n" +
                "4. Look for poor grammar or spelling mistakes\n" +
                "5. When in doubt, contact the company directly through their official website"
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"browsing", "safe internet", "web safety"},
                "Safe Browsing Practices:\n" +
                "1. Look for 'https://' and the padlock icon in the address bar\n" +
                "2. Keep your browser and plugins updated\n" +
                "3. Use an ad-blocker to avoid malicious ads\n" +
                "4. Be cautious when downloading files\n" +
                "5. Consider using a VPN on public Wi-Fi networks"
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"what can i ask about", "query", "inquire"},
                "You can ask me about password safety, phishing, and safe browsing."
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"malware", "virus", "ransomware"},
                "Malware Protection:\n" +
                "1. Install reputable antivirus software\n" +
                "2. Keep your operating system updated\n" +
                "3. Don't open email attachments from unknown senders\n" +
                "4. Be careful with USB drives from untrusted sources\n" +
                "5. Regularly back up your important files"
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"social media", "facebook", "twitter", "instagram"},
                "Social Media Safety:\n" +
                "1. Review your privacy settings regularly\n" +
                "2. Be careful what personal information you share\n" +
                "3. Don't accept friend requests from strangers\n" +
                "4. Be wary of quizzes and apps that ask for permissions\n" +
                "5. Think before you post - once online, it's hard to take back"
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"public wifi", "coffee shop", "hotel wifi"},
                "Public Wi-Fi Safety:\n" +
                "1. Avoid accessing sensitive accounts on public Wi-Fi\n" +
                "2. Use a VPN if you need to access private information\n" +
                "3. Confirm the network name with staff before connecting\n" +
                "4. Turn off file sharing when on public networks\n" +
                "5. Consider using your mobile data instead if possible"
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"two-factor", "2fa", "multi-factor"},
                "Two-Factor Authentication (2FA):\n" +
                "1. 2FA adds an extra layer of security beyond just a password\n" +
                "2. Can use SMS codes, authenticator apps, or security keys\n" +
                "3. Enable it on all important accounts (email, banking, social media)\n" +
                "4. Authenticator apps are more secure than SMS-based 2FA\n" +
                "5. Keep backup codes in a safe place in case you lose access"
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"update", "patch", "software update"},
                "Importance of Updates:\n" +
                "1. Software updates often include critical security fixes\n" +
                "2. Enable automatic updates when possible\n" +
                "3. Don't ignore update notifications\n" +
                "4. Update all your devices - computers, phones, and smart devices\n" +
                "5. Keep your apps updated too, not just the operating system"
            });

            AllTheResponses.Add(new object[] {
                new List<string>{"cybersecurity", "cybersecurity awareness", "definition of cybersecurity"},
                "Cybersecurity:\n" +
                "1. Cybersecurity encompasses the technologies, policies, and practices used to protect computer systems, networks, data, and other digital assets from cyber threats\n" +
                "2. In simplest terms, cybersecurity is about protecting computer systems, networks, and data from unauthorized access, damage, or theft, essentially safeguarding your digital world"
            });

            foreach (object[] responsePair in AllTheResponses)
            {
                var keywords = (List<string>)responsePair[0];
                var responseText = (string)responsePair[1];

                foreach (string keyword in keywords)
                {
                    if (usersLowercaseInput.Contains(keyword))
                        return responseText;
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            return "Sorry I don't quite understand.please rephrase Try asking something related to cybersecurity?";
        }

        private void TypeTextSlowly(string text, int delayBetweenCharacters = 17)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delayBetweenCharacters);
            }
            Console.WriteLine();
        }
    }
}