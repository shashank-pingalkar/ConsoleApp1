using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Iplayable videoPlayer = new VideoPlayer();
            Iplayable musicPlayer = new MusicPlayer();

            videoPlayer.Play(); 
            musicPlayer.Play(); 

            Console.ReadLine(); 
        }
    }
}
