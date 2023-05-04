using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Prototype
{
    public abstract class Shape : ICloneable
    {
        private int id;
        internal string type = "shape";
        public void Draw()
        {
            System.Console.WriteLine("Draw a " + type);
        }
        public string GetType()
        {
            return type;
        }
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}