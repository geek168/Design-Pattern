using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class StereoOnWithCDCommand : ICommand
    {
        private Stereo Stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            Stereo = stereo;
        }

        public void Excute()
        {
            Stereo.On();
            Stereo.SetCD();
            Stereo.SetVolume();
        }

        public void Undo()
        {
            Stereo.Off();
        }
    }
}
