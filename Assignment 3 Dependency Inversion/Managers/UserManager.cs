using Assignment_3_Dependency_Inversion.Interfaces;

namespace Assignment_3_Dependency_Inversion.Managers
{
    // This class depends on ILogger
    public class UserManager
    {
        // Dependency injection
        private readonly ILogger _logger;

        // Constructor injection
        public UserManager(ILogger logger)
        {
            _logger = logger;
        }

        public void CreateUser()
        {
            _logger.Log("User created successfully");
        }
    }
}