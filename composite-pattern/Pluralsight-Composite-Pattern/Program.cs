using System;

namespace Pluralsight_Composite_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramWithOutPatternImplemented.Run(args);
            
            Console.WriteLine();
            Console.WriteLine();

            ProgramWithPatternImplemented.Run(args);
        }
    }
}
