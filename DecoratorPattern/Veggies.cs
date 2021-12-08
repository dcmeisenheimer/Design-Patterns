using System;

namespace DecoratorPattern
{
    public class Veggies : PizzaDecorator
    {
        Pizza pizza;
        public Veggies(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string GetDescription()
        {
            return pizza.GetDescription() + ", add Veggies";
        }

        public override void SetSize(string size)
        {
            this.pizza.SetSize(size);
        }
        public override string GetSize()
        {
            return this.pizza.GetSize();
        }
        public override double Cost()
        {
            double cost = pizza.Cost();

             switch(pizza.GetSize())
            {
                case "Small":
                    cost += .50;
                    break;
                case "Medium":
                    cost += 1.25;
                    break;
                case "Large":
                    cost += 1.50;
                    break;
            }
            return cost;

        }
    }
}
