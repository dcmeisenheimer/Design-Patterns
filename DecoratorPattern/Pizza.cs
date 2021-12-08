using System;

namespace DecoratorPattern
{
    public abstract class Pizza
    {
        public string Size{get; set;}
        public string Description {get; set;}

        public Pizza()
        {
            Description = "Unknown Pizza";

        }

        public virtual string GetDescription()
        {
            return Size + " " + Description;
        }

        public virtual void SetSize(string Size)
        {
            Size = Size;
        }

        public virtual string GetSize()
        {
            return Size;
        }

        public abstract double Cost();
        
    }
}
