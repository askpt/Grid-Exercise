using System;
using GridExercise.Model;

namespace GridExercise
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Dimensions");
            var dimensions = Console.ReadLine();

            Console.WriteLine("Write Starting Point");
            var start = Console.ReadLine();

            Console.WriteLine("Write Sequence");
            var path = Console.ReadLine();

            var dim = Parser.ParseDimensions(dimensions);
            var pawn = Parser.ParsePawn(start, dim);
            Parser.ParsePath(pawn, path);
            
            Console.WriteLine(pawn.ToString());

            // NewMethod1();
            // NewMethod2();
        }

        private static void NewMethod2()
        {
            var pawn = new Pawn('E', 3, 3, (5, 5));

            Parser.ParsePath(pawn, "MMRMMRMRRM");

            Console.WriteLine(pawn.ToString());
        }

        private static void NewMethod1()
        {
            var pawn = new Pawn('N', 1, 2, (5, 5));

            Parser.ParsePath(pawn, "LMLMLMLMM");

            Console.WriteLine(pawn.ToString());
        }
    }
}
