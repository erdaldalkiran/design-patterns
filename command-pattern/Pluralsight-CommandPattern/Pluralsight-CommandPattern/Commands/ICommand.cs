using System.Security.Cryptography.X509Certificates;

namespace Pluralsight_CommandPattern.Commands
{
    public interface ICommand
    {
        void Execute();
    }
}
