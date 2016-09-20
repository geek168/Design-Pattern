using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class StereoOffWithCDCommand : ICommand
    {
        private Stereo Stereo;

        public StereoOffWithCDCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Excute()
        {
            Stereo.Off();
        }

        public void Undo()
        {
            Stereo.On();
            Stereo.SetCD();
            Stereo.SetVolume();
        }
    }
}
