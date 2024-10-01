using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface Iplayable
    {
        void Play();
    }

    public class VideoPlayer : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Video");
        }
    }

    public class MusicPlayer : Iplayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Music");
        }
    }

}
