using System;
using GridExercise.Model;

namespace GridExercise
{
    public static class Parser
    {
        public static void ParsePath(Pawn pawn, string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            var c = path[0];

            switch (c)
            {
                case 'L':
                    pawn.RotateLeft();
                    break;
                case 'R':
                    pawn.RotateRight();
                    break;
                case 'M':
                    pawn.Move();
                    break;
            }

            ParsePath(pawn, path.Substring(1));
        }

        public static Pawn ParsePawn(string input, (int X, int Y) dimensions)
        {
            var inpTemp = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var x = int.Parse(inpTemp[0]);
            var y = int.Parse(inpTemp[1]);

            return new Pawn(inpTemp[2][0], x, y, dimensions);
        }

        public static (int X, int Y) ParseDimensions(string input)
        {
            var inpTemp = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var x = int.Parse(inpTemp[0]);
            var y = int.Parse(inpTemp[1]);

            return (x, y);
        }

        public static string ProcessInput(string dimensions, string start, string path)
        {
            var dim = Parser.ParseDimensions(dimensions);
            var pawn = Parser.ParsePawn(start, dim);
            Parser.ParsePath(pawn, path);

            return pawn.ToString();
        }
    }
}