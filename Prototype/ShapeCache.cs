using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Prototype
{
    public class ShapeCache
    {
        private static Dictionary<int, Shape> shapeMap = new Dictionary<int, Shape>();
        public static Shape GetShape(int shapeId)
        {
            shapeMap.TryGetValue(shapeId, out Shape shape);
            return shape;
        }
        public static void LoadCache()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetId(0);
            shapeMap.Add(rectangle.GetId(), rectangle);
            Circle circle = new Circle();
            circle.SetId(1);
            shapeMap.Add(circle.GetId(), circle);
            Square square = new Square();
            square.SetId(2);
            shapeMap.Add(square.GetId(), square);
        }
    }
}