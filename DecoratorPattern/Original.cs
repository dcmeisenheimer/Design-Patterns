using System;

namespace DecoratorPattern
{
    public class Original : Pizza
    {
        public Original()
        {
            Description = "Original Pizza";
        }

        public override double Cost()
        {
            double cost = 0.0;
            switch(Size)
            {
                case "Small":
                    cost += 5;
                    break;
                case "Medium":
                    cost += 7.5;
                    break;
                case "Large":
                    cost += 10;
                    break;
            }
            return cost;

        }
    }
}
