using System;

namespace Pluralsight_CommandPattern.Commands
{
    public class NullCommand : ICommand
    {
        public string Name { get; set; }
        public void Execute()
        {
            Console.WriteLine("Command: " + Name + " does not exists.");
        }
    }
}
