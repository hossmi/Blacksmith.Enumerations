namespace Blacksmith.Enumerations.Tests
{
    public class ServerStatus : DescribedEnumeration
    {
        protected ServerStatus(int id, string name, string description) : base(id, name, description)
        {
        }

        public static ServerStatus Off => new ServerStatus(1, "Off", "Server is off.");
        public static ServerStatus Starting => new ServerStatus(2, "Starting", "Server is initializig systems.");
        public static ServerStatus Ready => new ServerStatus(3, "Ready", "Server is ready and waiting requests.");
        public static ServerStatus ShutingDown => new ServerStatus(3, "ShutingDown", "Server is taking down systems.");
        public static ServerStatus Error => new ServerStatus(3, "Error", "An unknown error had happened.");
    }
}
