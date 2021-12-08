using System;

namespace AdapterPattern
{
    public class Spirit : ICharacter
    {
        private string name;

        public Spirit(string name)
        {
            this.name = name;
        }

        public void CastSpell()
        {
            System.Console.WriteLine($"{name} casts a spirit spell");
            
        }

        public void Walk()
        {
            System.Console.WriteLine($"{name} walks forward");
        }
    }
}
