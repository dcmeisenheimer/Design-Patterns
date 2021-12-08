using System;

namespace DecoratorPattern
{
    public class Cheese : PizzaDecorator
    {
        Pizza pizza;
        public Cheese(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string GetDescription()
        {
            return pizza.GetDescription() + ", add Cheese";
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
                    cost += 1.0;
                    break;
                case "Large":
                    cost += 1.25;
                    break;
            }
            return cost;

        }
    }
}
