using System.Collections.Generic;
using System.Linq;
using Pluralsight_CommandPattern.Commands;

namespace Pluralsight_CommandPattern
{
    public class CommandParser
    {
        public static ICommand Parse(string[] args, IEnumerable<ICommandFactory> avaliableCommands)
        {
            var commandFactory = avaliableCommands.FirstOrDefault(x => x.Name.Equals(args[0]));
            if (commandFactory == null)
            {
                return new NullCommand { Name = args[0] };
            }
            return commandFactory.CreateCommand(args.Skip(1).ToArray());
        }
    }
}