using System.ComponentModel;

namespace Task2
{
    public interface ILoggable 
    {
        void LogMessage(string message);
    }
    public class ConsoleLogger: ILoggable
    {
        public void LogMessage(string message) 
        {
            Console.WriteLine($"Console {message}");
        }
    }
    public class FileLogger : ILoggable
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"File {message}");
        }
    }



   
    internal class Program
    {
        public static void ProcessLogs(ILoggable interFace, string message)
        {
            interFace.LogMessage(message);
        }
        static void Main(string[] args)
        {
            ConsoleLogger cl = new ConsoleLogger();
            FileLogger fl = new FileLogger();
            ProcessLogs(cl, "From Console");
            ProcessLogs(fl, "From File");
            ILoggable il = new ConsoleLogger();
            ProcessLogs(il, "il fro console");
        }
    }
}


//Task: Create a system to log errors using a polymorphic method.
//Requirement 1(Interface): Define an interface ILoggable with a single method: void LogMessage(string message).
//Requirement 2 (Class): Create two classes, ConsoleLogger and FileLogger, both implementing ILoggable.
//ConsoleLogger.LogMessage should print: "[CONSOLE] " + message.

//FileLogger.LogMessage should print: "[FILE] " + message(simulating a file write).

//Requirement 3(Method): Write a static method ProcessLogs that accepts an ILoggable reference and a string message, and calls the LogMessage method through the interface reference.