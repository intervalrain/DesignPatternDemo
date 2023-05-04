using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Builder
{
    public class ChickenBurger : Burger
    {
        public ChickenBurger() {}
        public override float GetPrice()
        {
            return 50.5f;
        }
        public override string GetName()
        {
            return "Chicken Burger";
        }
    }
}