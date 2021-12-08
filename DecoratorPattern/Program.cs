using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza myPizza = new DeepDish(){Size = "Large"};
            myPizza = new Cheese(myPizza);
            myPizza = new Cheese(myPizza);

            System.Console.WriteLine(myPizza.GetDescription() + " Cost $" + myPizza.Cost());

            Pizza secondPizza = new Original(){Size = "Small"};
            secondPizza = new Cheese(secondPizza);
            secondPizza =  new Pepperoni(secondPizza);
            secondPizza = new Sausage(secondPizza);

            System.Console.WriteLine(secondPizza.GetDescription() + " Cost $" + secondPizza.Cost());
        }
    }
}

/* Decorator Pattern
Attaches additional responsibilites to an object dynamically.
Decorators provide a flexible alternative to sub classing for extending functionality
*/
