using System;

namespace GridExercise.Model
{
    public class Pawn
    {
        public char Orientation { get; set; }
        public int AxisXX { get; set; }
        public int AxisYY { get; set; }

        public Pawn(char orientation, int axisXX, int axisYY)
        {
            Orientation = orientation;
            AxisXX = axisXX;
            AxisYY = axisYY;
        }

        public void RotateLeft()
        {
            switch (Orientation)
            {
                case 'N':
                    Orientation = 'W';
                    break;
                case 'W':
                    Orientation = 'S';
                    break;
                case 'S':
                    Orientation = 'E';
                    break;
                case 'E':
                    Orientation = 'N';
                    break;
            }
        }

        public void RotateRight()
        {
            switch (Orientation)
            {
                case 'N':
                    Orientation = 'E';
                    break;
                case 'E':
                    Orientation = 'S';
                    break;
                case 'S':
                    Orientation = 'W';
                    break;
                case 'W':
                    Orientation = 'N';
                    break;
            }
        }

        public void Move()
        {
            switch (Orientation)
            {
                case 'N':
                    AxisYY++;
                    break;
                case 'E':
                    AxisXX++;
                    break;
                case 'S':
                    AxisYY--;
                    break;
                case 'W':
                    AxisXX--;
                    break;
            }
        }
    }
}