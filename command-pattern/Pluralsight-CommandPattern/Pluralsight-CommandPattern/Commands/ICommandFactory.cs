namespace Pluralsight_CommandPattern.Commands
{
    public interface ICommandFactory
    {
        string Name { get; }

        string Description { get; }
        ICommand CreateCommand(string[] args);
    }
}
