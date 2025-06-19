using System;

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First message.");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second message.");

        if (logger1 == logger2)
        {
            Console.WriteLine("Singleton works: Only one instance exists.");
        }
        else
        {
            Console.WriteLine("Singleton failed: Different instances.");
        }
    }
}
