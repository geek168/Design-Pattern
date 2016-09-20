using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class LightOffCommand : ICommand
    {
        private Light Light;

        public LightOffCommand(Light light)
        {
            Light = light;
        }

        public void Excute()
        {
            Light.Off();
        }

        public void Undo()
        {
            Light.On();
        }
    }
}
