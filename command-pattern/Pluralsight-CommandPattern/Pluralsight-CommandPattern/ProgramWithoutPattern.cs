using System;

namespace Pluralsight_CommandPattern
{
    public class ProgramWithoutPattern
    {
        public static void Run(string[] args)
        {
            if (args.Length == 0)
            {
                PrintUsage();
                return;
            }

            var processor = new CommandProcessor();
            processor.ExecuteCommand(args);
        }

        private static void PrintUsage()
        {
            Console.WriteLine("Usage: LoggingDemo CommandName Arguments");
            Console.WriteLine("Commands:");
            Console.WriteLine("   UpdateQuantity number");
            Console.WriteLine("   CreateOrder");
            Console.WriteLine("   ShipOrder");
        }
    }
}