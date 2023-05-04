using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Builder
{
    public class MealBuilder
    {
        public Meal prepareVegMeal()
        {
            Meal meal = new Meal();
            meal.Add(new VegBurger());
            meal.Add(new BlackTea());
            return meal;
        }
        public Meal prepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.Add(new ChickenBurger());
            meal.Add(new Coke());
            return meal;
        }

    }
}