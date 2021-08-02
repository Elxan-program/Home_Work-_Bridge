using Home_Work__Bridge.Classes;
using Home_Work__Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IRemote RadioRemote = new Radio_Remote(new Radio());

            bool RadioisEnabled = false;

            bool RadioIsMute = true;

            RadioRemote.Mute(RadioIsMute);
            RadioRemote.VolumeUp();
            RadioRemote.VolumeDown();
            RadioRemote.Power(RadioisEnabled);
            RadioRemote.ChannelDown();
            RadioRemote.ChannelUp();


            IRemote TvRemote = new TV_Remote(new Television_TV_());

            bool TvIsEnabled = true;
            bool TvIsMute = false;

            TvRemote.Power(TvIsEnabled);
            TvRemote.Mute(TvIsMute);
            TvRemote.VolumeDown();
            TvRemote.VolumeUp();
            TvRemote.ChannelDown();
            TvRemote.ChannelUp();
        }
    }
}
