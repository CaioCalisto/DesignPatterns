using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_1
{
    public class Builder
    {
        public Meal Prepare1()
        {
            Meal meal = new Meal();
            meal.Add(new Restaurant.Sanduich.Cheese());
            meal.Add(new Restaurant.Beverages.Coke());
            return meal;
        }

        public Meal Prepare2()
        {
            Meal meal = new Meal();
            meal.Add(new Restaurant.Sanduich.Cheese());
            meal.Add(new Restaurant.Beverages.Pepsi());
            return meal;
        }


    }
}
