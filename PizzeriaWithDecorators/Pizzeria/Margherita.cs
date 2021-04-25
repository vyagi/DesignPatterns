using System;

namespace Pizzeria
{
    public class Margherita : Pizza
    {
        public override double Cost =>
            Size switch
            {
                PizzaSize.Small => 15,
                PizzaSize.Normal => 19,
                PizzaSize.Big => 25,
                PizzaSize.Family => 30,
                _ => throw new ArgumentOutOfRangeException()
            };

        public override string Description 
            => "Italian Margherita";
    }
}