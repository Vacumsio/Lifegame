using System;

namespace Lifegame
{
    public class Field
    {
        private int _rows;
        private int _cols;

        private bool[][] _filed;

        public int Rows { get { return _rows;} }

        public int Cols { get { return _cols;} }

        public Field(int rows, int cols)
        {
            _rows = rows;
            _cols = cols;

            _filed = new bool[_rows][];
            for(var i = 0; i < _rows; i++)
            {
                _filed[i] = new bool[_cols];
            }
        }

        public void PrintToConsole()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _cols; j++)
                {
                    Console.Write(_filed[i][j] ? "X" : ".");
                }
                Console.WriteLine();
            }
        }

        public void Set(int x, int y, bool value)
        {
            if (x > _rows)
            {
                throw new ArgumentOutOfRangeException(nameof(x),
                    $"The value should not exceed {_rows}" );
            }

            _filed[x][y] = value;
        }

        public bool Get(int x, int y)
        {
            return _filed[x][y];
        }
    }
}
