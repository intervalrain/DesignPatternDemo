using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            IShape shape1 = shapeFactory.GetShape(Shape.circle);
            IShape shape2 = shapeFactory.GetShape(Shape.square);
            IShape shape3 = shapeFactory.GetShape(Shape.rectangle);

            shape1.draw();
            shape2.draw();
            shape3.draw();
        }
    }
    
}