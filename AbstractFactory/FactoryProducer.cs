using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactorys(Factory factory)
        {
            switch (factory)
            {
                case Factory.color:
                    return new ColorFactory();
                case Factory.shape:
                    return new ShapeFactory();
                default:
                    break;
            }
            return null;
        }
    }
    
}