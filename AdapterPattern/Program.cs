using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacter myChar = new Spirit("Daniel");
            ICharacter youVehicle = new CharacterAdapter(new MysticVehicle());

            myChar.CastSpell();
            myChar.Walk();

            youVehicle.CastSpell();
            youVehicle.Walk();
        }
    }
}

/*Adapter Pattern
Adapters are apart of modern life. 
We see them in the physical world: USB A to USB C and also in software
    The new playstation running old games
    
Much like the usb adaprter example
    We have a common problem in software when on system supports interface A and another application only provides interface B

The adapter pattern converts the interface of a class into another interface the client expects
Adapter lets classes work together that couldn't otherwise because of incompatible interfaces (Structural Pattern)

Remember the Decorator Pattern where we wrapped additional functionality
Similiar concept: Except the goal is to make compatible interfaces 
*/