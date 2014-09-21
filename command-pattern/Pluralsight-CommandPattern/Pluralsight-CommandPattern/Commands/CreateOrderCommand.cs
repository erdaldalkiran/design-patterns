using System;

namespace Pluralsight_CommandPattern.Commands
{
    public class CreateOrderCommand : ICommand, ICommandFactory
    {
        public void Execute()
        {
            Console.WriteLine("Do nothing.");
        }

        public string Name { get { return "CreateOrder"; } }
        public string Description { get { return "CreateOrder"; } }
        public ICommand CreateCommand(string[] args)
        {
            return  new CreateOrderCommand();
        }
    }
}
