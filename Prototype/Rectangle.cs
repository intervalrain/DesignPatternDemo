using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Prototype
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            base.type = "Rectangle";
        }
    }
}