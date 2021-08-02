using Home_Work__Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__Bridge.Classes
{
    class Radio : IDevice
    {
        public Random rand = new Random();
        public void Disable()
        {
            Console.WriteLine("Radio is Disable");
        }

        public void Enable()
        {
            Console.WriteLine("Radio is Enable");
        }

        public void GetChannel()
        {
            //Random rand = new Random();
            double channel = double.Parse(rand.ToString());
            Console.WriteLine($"Channel : {channel}");
        }

        public void GetVolume()
        {
            double volume = double.Parse(rand.ToString());
            Console.WriteLine($"Volume : {volume}");
        }

        public void isEnabled(bool is_enabled)
        {
            if (is_enabled == true)
            {
                Enable();
            }
            else
            {
                Disable();
            }
        }

        public void SetChannel(double channel)
        {
            Console.WriteLine($"Channel : {channel}");
        }

        public void SetVolume(double percent)
        {
            Console.WriteLine($"Volume : {percent}");
        }
    }
}
