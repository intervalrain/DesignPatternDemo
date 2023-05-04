using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(Color color);
        public abstract IShape GetShape(Shape shape);
    }
}