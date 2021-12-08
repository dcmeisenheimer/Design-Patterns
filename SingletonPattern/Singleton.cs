using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private volatile static Singleton uniqueInstance; //private field to hold object

        private Singleton() //Private no arg constructor
        {

        }

        public static Singleton GetInstance()
        {
            if(uniqueInstance == null)
            {
                lock(uniqueInstance)
                {
                    if (uniqueInstance == null)
                    {
                        System.Console.WriteLine("Creating new, unique instance of Singleton");
                        uniqueInstance = new Singleton();
                    }
                }
            }
            else
            {
                System.Console.WriteLine("Using the previously created instance of Singleton");
            }

            return uniqueInstance;
        }
    }
}

/* MultiThreading
Feature provided by the operating system that enables your application to have more than one execution path at the same time
Example:
    MS word cna take input from the user and display it on the screen in one thread while it continues to check spelling in another thread

If multiple threads are running, how do you know one thing will happen before the other one?
How do we know our object wasn't created in another thread?

Lock Keyword: ensures that one thread is executing a piece of code at any one time.
The lock keyword ensures that one thread does not enter a section of code while another thread is in that same section

From MS docs - acquires a mutual-exclusion lock for a given object, executes a statement block,
then releases the lock.
*/