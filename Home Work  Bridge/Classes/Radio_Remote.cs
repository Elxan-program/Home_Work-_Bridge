using Home_Work__Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__Bridge.Classes
{
    class Radio_Remote : IRemote
    {
        public IDevice Device { get; set; }

        double percent = 100;

        double channel = 1;

        public void ChannelDown()
        {
            if (channel > 0)
            {
                channel--;
                Device.SetChannel(channel);
            }
        }
        public Radio_Remote(IDevice device)
        {
            Device = device;
        }
        public void ChannelUp()
        {
            channel++;
            Device.SetChannel(channel);
        }

        public void Mute(bool isMute)
        {
            Console.WriteLine($"Mute of Radio is {isMute}");
        }

        public void Power(bool isEnable)
        {
            Device.isEnabled(isEnable);
        }

        public void VolumeDown()
        {
            if (percent > 0)
            {
                percent--;
                Device.SetVolume(percent);
            }
        }

        public void VolumeUp()
        {
            percent++;
            Device.SetVolume(percent);
        }
    }
}
