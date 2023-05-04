using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object syncRoot = new object();
        private Singleton() {}
        public static Singleton Instance
        {
            get 
            {
                if (instance == null)
                {
                    lock(syncRoot) 
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }
        public void Show()
        {
            System.Console.WriteLine("Hello World!");
        }
    }
}