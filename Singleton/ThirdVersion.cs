﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Bad code! Don't use!
    /*
     * This implementation attempts to be thread-safe without the necessity of taking out a lock every time. 
     * Unfortunately, there are four downsides to the pattern:
        It doesn't work in Java. This may seem an odd thing to comment on, 
            but it's worth knowing if you ever need the singleton pattern in Java, 
            and C# programmers may well also be Java programmers. 
            The Java memory model doesn't ensure that the constructor completes before 
            the reference to the new object is assigned to instance. 
            The Java memory model underwent a reworking for version 1.5, 
            but double-check locking is still broken after this without a volatile variable (as in C#).
        Without any memory barriers, it's broken in the ECMA CLI specification too. 
            It's possible that under the .NET 2.0 memory model (which is stronger than the ECMA spec) it's safe, 
            but I'd rather not rely on those stronger semantics, especially if there's any doubt as to the safety. 
            Making the instance variable volatile can make it work, 
            as would explicit memory barrier calls, 
            although in the latter case even experts can't agree exactly which barriers are required. 
            I tend to try to avoid situations where experts don't agree what's right and what's wrong!
        It's easy to get wrong. 
            The pattern needs to be pretty much exactly as above - any significant changes 
            are likely to impact either performance or correctness.
        It still doesn't perform as well as the later implementations.
     */
    public sealed class ThirdVersion
    {
        private static ThirdVersion Instance;
        private static readonly object padlock = new object();

        private ThirdVersion()
        {

        }

        public static ThirdVersion GetInstance()
        {
            if(Instance == null)
            {
                lock(padlock)
                {
                    if(Instance == null)
                    {
                        Instance = new ThirdVersion();
                    }
                }
            }
            return Instance;
        }

    }
}
