using System;

namespace Pluralsight_CommandPattern.Commands
{
    public class ShipOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine("Do nothing.");
        }

        public string Name { get { return "ShipOrder"; } }
        public string Description { get { return "ShipOrder"; } }
        public ICommand CreateCommand(string[] args)
        {
            return new ShipOrderCommand();
        }
    }
}
