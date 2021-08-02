using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__Bridge.Interfaces
{
    interface IRemote
    {
        void Power(bool isEnable);
        void VolumeUp();
        void VolumeDown();
        void ChannelUp();
        void ChannelDown();
        void Mute(bool isMute);
    }
}
