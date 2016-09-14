using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SecondVersion
    {
        private static SecondVersion Instance;
        private static readonly object padlock = new object();

        private SecondVersion()
        {

        }

        public static SecondVersion GetInstance()
        {
            lock(padlock)
            {
                if(Instance == null)
                {
                    Instance = new SecondVersion();
                }
                return Instance;
            }
        }
    }
}
