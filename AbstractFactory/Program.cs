using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AbstractFactory shapeFactory = FactoryProducer.GetFactorys(Factory.shape);
            AbstractFactory colorFactory = FactoryProducer.GetFactorys(Factory.color);
            IShape shape1 = shapeFactory.GetShape(Shape.circle);
            IShape shape2 = shapeFactory.GetShape(Shape.square);
            IShape shape3 = shapeFactory.GetShape(Shape.rectangle);
            IColor color1 = colorFactory.GetColor(Color.red);
            IColor color2 = colorFactory.GetColor(Color.blue);
            IColor color3 = colorFactory.GetColor(Color.green);

            shape1.draw();
            shape2.draw();
            shape3.draw();
            color1.fill();
            color2.fill();
            color3.fill();
        }
    }
    
}