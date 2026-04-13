using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;

namespace POE_PART1
{
    public class LogoAndVoice
    {
        public void PlayVoiceAndDisplayLogo()
        {
            Thread voiceThread = new Thread(PlayVoiceGreeting);
            voiceThread.Start();

            DisplayAsciiLogo();

            voiceThread.Join();
        }

        private void PlayVoiceGreeting()
        {
            string full_location = AppDomain.CurrentDomain.BaseDirectory;
            string new_path = full_location.Replace("bin\\Debug\\", "");
            string full_path = Path.Combine(new_path, "sandi.wav");

            try
            {
                using (SoundPlayer play = new SoundPlayer(full_path))
                {
                    play.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void DisplayAsciiLogo()
        {
            string fullpath = AppDomain.CurrentDomain.BaseDirectory;
            string path = fullpath.Replace(@"bin\Debug\", "logo2.jpg");

            Bitmap image = new Bitmap(path);

            int width = 150;
            int height = 70;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            Console.ForegroundColor = ConsoleColor.Cyan;
            string asciiChars = "@#S%?*+;:,. ";

            for (int y = 0; y < resized.Height; y++)
            {
                for (int x = 0; x < resized.Width; x++)
                {
                    Color pixel = resized.GetPixel(x, y);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    int index = (gray * (asciiChars.Length - 1)) / 255;
                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }
    }
}