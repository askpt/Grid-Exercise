using GridExercise.Model;

namespace GridExercise
{
    static class Parser
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
    }
}