using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace AbstractFactory
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(Color color)
        {
            switch (color)
            {
                case Color.red:
                    return new Red();
                case Color.green:
                    return new Green();
                case Color.blue:
                    return new Blue();
                default:
                    break;
            }
            return null;
        }
        public override IShape GetShape(Shape shape)
        {
            return null;
        }
    }
}