using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Builder
{
    public class VegBurger : Burger
    {
        public VegBurger() {}
        public override float GetPrice()
        {
            return 25.0f;
        }
        public override string GetName()
        {
            return "Veg Burger";
        }
    }
}