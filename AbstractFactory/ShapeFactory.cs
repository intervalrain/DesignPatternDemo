using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(Shape shape)
        {
            switch (shape)
            {
                case Shape.circle:
                    return new Circle();
                case Shape.rectangle:
                    return new Rectangle();
                case Shape.square:
                    return new Square();
                default:
                    break;
            }
            return null;
        }
        public override IColor GetColor(Color color)
        {
            return null;
        }
    }
    
}