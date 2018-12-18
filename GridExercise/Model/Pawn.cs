using System;

namespace GridExercise.Model
{
    public class Pawn
    {
        public char Orientation { get; set; }
        public int AxisXX { get; set; }
        public int AxisYY { get; set; }
        public (int X, int Y) MazeDimensions { get; set; }

        public Pawn(char orientation, int axisXX, int axisYY, (int X, int Y) dimensions)
        {
            Orientation = orientation;
            AxisXX = axisXX;
            AxisYY = axisYY;
            MazeDimensions = dimensions;

            if (MazeDimensions.X < AxisXX || AxisXX < 0)
            {
                throw new IndexOutOfRangeException();
            }
            if (MazeDimensions.Y < AxisYY || AxisYY < 0)
            {
                throw new IndexOutOfRangeException();
            }
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
                    if (MazeDimensions.Y > AxisYY)
                    {
                        AxisYY++;
                    }
                    break;
                case 'E':
                    if (MazeDimensions.X > AxisXX)
                    {
                        AxisXX++;
                    }
                    break;
                case 'S':
                    if (AxisYY > 0)
                    {
                        AxisYY--;
                    }
                    break;
                case 'W':
                    if (AxisXX > 0)
                    {
                        AxisXX--;
                    }
                    break;
            }
        }

        public override string ToString()
        {
            return $"{Orientation}, {AxisXX}, {AxisYY}";
        }
    }
}