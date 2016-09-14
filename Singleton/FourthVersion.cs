using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Not quite as lazy, but thread-safe without using locks.
    public sealed class FourthVersion
    {
        private static readonly FourthVersion Instance = new FourthVersion();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static FourthVersion()
        {

        }

        private FourthVersion()
        {

        }

        public static FourthVersion GetInstance()
        {
            return Instance;
        }
    }
}
