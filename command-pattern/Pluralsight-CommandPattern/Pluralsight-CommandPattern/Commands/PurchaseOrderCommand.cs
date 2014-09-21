using System;

namespace Pluralsight_CommandPattern.Commands
{
    public class PurchaseOrderCommand : ICommand, ICommandFactory
    {
        public int NewQuantity { get; set; }

        public void Execute()
        {
            // simulate updating a database
            const int oldQuantity = 5;
            Console.WriteLine("DATABASE: Updated");

            // simulate logging
            Console.WriteLine("LOG: Updated order quantity from {0} to {1}", oldQuantity, NewQuantity);
        }

        public string Name { get { return "PurchaseOrder"; } }
        public string Description { get { return "PurchaseOrder number"; } }
        public ICommand CreateCommand(string[] args)
        {
            return new PurchaseOrderCommand { NewQuantity = Int32.Parse(args[0]) };
        }
    }
}
