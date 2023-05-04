using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Singleton 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Singleton obj = Singleton.Instance;
            obj.Show();
        }
    }
}