using Assignment_3_Dependency_Inversion.Interfaces;
using Assignment_3_Dependency_Inversion.Managers;
using Assignment_3_Dependency_Inversion.Services;

namespace Assignment_3_Dependency_Inversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create dependency
            ILogger logger = new FileLogger();

            // Inject dependency
            UserManager manager = new UserManager(logger);

            // Run method
            manager.CreateUser();
        }
    }
}