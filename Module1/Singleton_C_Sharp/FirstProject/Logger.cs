using System;

public class Logger
{
    private static readonly Logger instance = new Logger();

    private Logger()
    {
        Console.WriteLine("Logger Initialized");
    }

    public static Logger GetInstance()
    {
        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}
