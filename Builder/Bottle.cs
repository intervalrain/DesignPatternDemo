using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Builder
{
    public class Bottle : Packing
    {
        public string pack()
        {
            return "Bottle";
        } 
    }
}