using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work__Bridge.Interfaces
{
    interface IDevice
    {
        void isEnabled(bool is_enabled);
        void Enable();
        void Disable();
        void GetVolume();
        void SetVolume(double percent);
        void GetChannel();
        void SetChannel(double channel);
    }
}
