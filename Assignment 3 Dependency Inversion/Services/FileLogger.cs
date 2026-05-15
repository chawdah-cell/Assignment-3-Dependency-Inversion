using System;
using Assignment_3_Dependency_Inversion.Interfaces;

namespace Assignment_3_Dependency_Inversion.Services
{
    // This class implements ILogger
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("LOG: " + message);
        }
    }
}