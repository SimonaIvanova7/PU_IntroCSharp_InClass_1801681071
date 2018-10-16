using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to play some music?");
            string answer = Console.ReadLine();
            
           if (answer == "Yes")
            {
                Console.WriteLine("Playing music!");
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\fmi\Desktop\Week3\PU_IntroCSharp_InClass_1801681071\Music\MONKEY_SNAKE_ft._FANTASY_BAND_-_DA_ILI_NE_OFFICIAL_VIDEO_2018_--bcyknj7OZb4.wav"))
                {
                    // Use PlaySync to load and then play the sound.
                    // ... The program will pause until the sound is complete.
                    player.PlaySync();
                }

            }
           else if (answer == "No")
            {
                Console.WriteLine("Goodbye!");
            }
           else
            {
                Console.WriteLine("Wrong input!");
            }
       

                   //Console.WriteLine("Hello!");
        }
    }
}
