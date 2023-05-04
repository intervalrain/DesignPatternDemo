using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();
            Meal vegMeal = mealBuilder.prepareVegMeal();
            vegMeal.Bill();
            Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
            nonVegMeal.Bill();
        }
    }
}