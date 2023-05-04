using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace AbstractFactory
{
    public class Green : IColor
    {
        public void fill()
        {
            System.Console.WriteLine("Fill color green");
        }
    }
}