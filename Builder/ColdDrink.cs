using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Builder
{
    public abstract class ColdDrink : Item
    {
        public Packing GetPacking()
        {
            return new Bottle();
        }
        public abstract float GetPrice();
        public abstract string GetName();
    }
}