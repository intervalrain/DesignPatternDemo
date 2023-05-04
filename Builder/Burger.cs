using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Builder
{
    public abstract class Burger : Item
    {
        public Packing GetPacking()
        {
            return new Wrapper();
        }
        public abstract float GetPrice();
        public abstract string GetName();
    }
}