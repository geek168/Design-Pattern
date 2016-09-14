using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Bad code! Don't use!
    //Not thread-safe!
    public sealed class FirstVersion
    {
        private static FirstVersion Instance;

        private FirstVersion()
        {

        }

        public static FirstVersion GetInstance()
        {
            if(Instance == null)
            {
                Instance = new FirstVersion();
            }
            return Instance;
        }

    }
}
