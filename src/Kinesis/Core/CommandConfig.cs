namespace Kinesis.Core
{
    public class CommandConfig
    {
        public string Name { get; set; }
        public string Header { get; set; }

        public static CommandConfig Parse(string command)
        {
            var commandParts = command.Split(".");
            return new CommandConfig
            {
                Name = commandParts[1],
                Header = commandParts[0]
            };
        }
    }
}