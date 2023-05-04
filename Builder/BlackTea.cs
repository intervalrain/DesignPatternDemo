using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Builder
{
    public class BlackTea : ColdDrink
    {
        public BlackTea() {}
        public override float GetPrice()
        {
            return 10.0f;
        }
        public override string GetName()
        {
            return "Black Tea";
        }
    }
}