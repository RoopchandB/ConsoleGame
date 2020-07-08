using System;

namespace ConsoleGame
{
    class Game : SuperGame
    {
        public new static void UpdatePosition(
          string keyPressed,
          out int xCoordinate,
          out int yCoordinate
        )
        {
            switch (keyPressed)
            {
                case "DownArrow":
                    xCoordinate = 0;
                    yCoordinate = 1;
                    break;

                case "UpArrow":
                    xCoordinate = 0;
                    yCoordinate = -1;
                    break;

                case "LeftArrow":
                    xCoordinate = -1;
                    yCoordinate = 0;
                    break;

                case "RightArrow":
                    xCoordinate = 1;
                    yCoordinate = 0;
                    break;

                default:
                    xCoordinate = 0;
                    yCoordinate = 1;
                    break;
            }
        }

        public new static char UpdateCursor(string keyPressed)
        {
            switch (keyPressed)
            {
                case "DownArrow":
                    return 'v';

                case "UpArrow":
                    return '^';

                case "LeftArrow":
                    return '<';

                case "RightArrow":
                    return '>';

                default:
                    return '<';

            }
        }

        public new static int keepInBounds(
          int coordinate,
          int maxValue
          )
        {
            if (coordinate >= maxValue)
            {
                return maxValue;
            }
            else if (coordinate < 0)
            {
                return 0;
            }
            else
            {
                return coordinate;
            }
        }

        public new static bool DidScore(
          int xchar,
          int ychar,
          int x,
          int y
        )
        {
            if (xchar == x && ychar == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}