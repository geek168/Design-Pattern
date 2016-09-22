using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey Turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            Turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                Turkey.Fly();
            }
        }

        public void Quack()
        {
            Turkey.Gobble();
        }
    }
}
