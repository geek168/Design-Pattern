using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class DuckAdapter : ITurkey
    {
        private IDuck Duck;
        
        public DuckAdapter(IDuck duck)
        {
            Duck = duck;
        }

        public void Fly()
        {
            Random rd = new Random();
            if(rd.Next(5) == 0)
            {
                Duck.Fly();
            }
        }

        public void Gobble()
        {
            Duck.Quack();
        }
    }
}
