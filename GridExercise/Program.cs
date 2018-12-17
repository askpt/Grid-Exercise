using System;
using GridExercise.Model;

namespace GridExercise
{
    static class Program
    {
        static void Main(string[] args)
        {
            NewMethod1();
            NewMethod2();
        }

        private static void NewMethod2()
        {
            var pawn = new Pawn('E', 3, 3);

            Parser.ParsePath(pawn, "MMRMMRMRRM");

            Console.WriteLine($"{pawn.Orientation}, {pawn.AxisXX}, {pawn.AxisYY}");
        }

        private static void NewMethod1()
        {
            var pawn = new Pawn('N', 1, 2);

            Parser.ParsePath(pawn, "LMLMLMLMM");

            Console.WriteLine($"{pawn.Orientation}, {pawn.AxisXX}, {pawn.AxisYY}");
        }
    }
}
