using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class LightOnCommand : ICommand
    {
        private Light Light;

        public LightOnCommand(Light light)
        {
            Light = light;
        }

        public void Excute()
        {
            Light.On();
        }

        public void Undo()
        {
            Light.Off();
        }
    }
}
