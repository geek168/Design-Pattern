using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SixthVersion
    {
        private static readonly Lazy<SixthVersion> lazy = new Lazy<SixthVersion>();

        private SixthVersion()
        {

        }

        public static SixthVersion GetInstance()
        {
            return lazy.Value;
        }
    }
}
