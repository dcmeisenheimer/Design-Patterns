using System;

namespace DecoratorPattern
{
    public class Sausage : PizzaDecorator
    {
        Pizza pizza;
        public Sausage(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string GetDescription()
        {
            return pizza.GetDescription() + ", add Sausage";
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
                    cost += .75;
                    break;
                case "Medium":
                    cost += 1.5;
                    break;
                case "Large":
                    cost += 1.75;
                    break;
            }
            return cost;

        }
    }
}
