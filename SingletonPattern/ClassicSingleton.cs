using System;

namespace SingletonPattern
{
    public class ClassicSingleton
    {
        private static ClassicSingleton uniqueInstance; //private field to hold the object

        private ClassicSingleton() //Private No Arg Constructor
        {

        }

        public static ClassicSingleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                System.Console.WriteLine("Creating new, unique instance of ClassicSingleton");
                uniqueInstance = new ClassicSingleton();
            }
            else
            {
                System.Console.WriteLine("Using the previously created instance of ClassicSingleton");
            }

            return uniqueInstance;
        }
    }
}

/* Singleton Design Pattern
Sometimes we only need one instance of a class
    Ex: Keyboard, drivers, in some cases database connections, etc.
    We want to make it impossible to get a 2nd instance

Can we just create, destroy, then recreate?
    Creating some objects can take a lot of time
    Extra object can take up memory if they are not "Cleaned Up" properly
    If you end up with multiple objects that should be unique, you could have bugs
 */