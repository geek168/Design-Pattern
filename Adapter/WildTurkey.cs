using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I am flying a short distance!");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble!");
        }
    }
}
