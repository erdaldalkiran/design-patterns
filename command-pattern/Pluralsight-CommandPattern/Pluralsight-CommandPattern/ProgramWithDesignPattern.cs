using System;
using System.Collections.Generic;
using Pluralsight_CommandPattern.Commands;

namespace Pluralsight_CommandPattern
{
    public class ProgramWithDesignPattern
    {
        public static void Run(string[] args)
        {
            var avaliableCommands = GetAvaliableCommands();

            if (args.Length == 0)
            {
                PrintUsage(avaliableCommands);
                return;
            }

            CommandParser.Parse(args, avaliableCommands).Execute();

        }

        private static void PrintUsage(IEnumerable<ICommandFactory> avaliableCommands)
        {
            Console.WriteLine("Avaliable commands are :");
            foreach (var commandFactory in avaliableCommands)
            {
                Console.WriteLine("\t" + commandFactory.Description);
            }
        }

        private static IEnumerable<ICommandFactory> GetAvaliableCommands()
        {
            return new List<ICommandFactory>
            {
                new PurchaseOrderCommand(),
                new CreateOrderCommand(),
                new ShipOrderCommand()
            };
        }
    }
}
