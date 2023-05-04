using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Builder
{
    public class Coke : ColdDrink
    {
        public Coke() {}
        public override float GetPrice()
        {
            return 30.0f;
        }
        public override string GetName()
        {
            return "Coke";
        }
    }
}