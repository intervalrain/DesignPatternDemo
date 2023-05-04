using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapeCache.LoadCache();
            Shape[] shapes = new Shape[3];
            for (int i = 0; i < 3; i++)
            {
                shapes[i] = (Shape) ShapeCache.GetShape(i);
                System.Console.WriteLine(shapes[i].GetType());
            }
            
        }
    }
}