using System;

static class Logger
{
    static string logfile = "application.txt";
    static string logfilediscription = "you have logged in the app at mar-08-2026 at 1:00pm";

    static string Logfile { set; get; }     //property

    static Logger()             //constructor
    {
        Logger.Logfile = logfile;
    }

    static void LogMessage(string level,string message)
    {
        Console.WriteLine($"{DateTime.Now} and [{level}] and {message}");
    }

    static void LogInfo(string message)
    {
        Console.WriteLine($" the information is {message}");
    }
    static void LogError(string message)
    {
        Logger.LogMessage("mediam", message);
    }
    static void Main()
    {
        Console.WriteLine("th file name is :"+Logger.logfile);
        Console.WriteLine("the property name is :"+Logger.Logfile);

        Logger.LogMessage("Basic", Logger.logfilediscription);
        Logger.LogInfo("you Logged in");
        Logger.LogError("you Logged in");
    }

}
