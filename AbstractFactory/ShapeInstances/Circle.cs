using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace AbstractFactory
{
    public class Circle : IShape
    {
        public Circle()
        {
        }
        public void draw()
        {
            System.Console.WriteLine("Draw a circle");
        }
    }   
}