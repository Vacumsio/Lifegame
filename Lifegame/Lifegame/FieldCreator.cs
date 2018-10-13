using System;
using System.Collections.Generic;
using System.Text;

namespace Lifegame
{
    public static class FieldCreator
    {
        public static Field CreateField(int rang)
        {
            var field = new Field(rang, rang);
            var rnd = new Random();

            for (int i = 0; i < rang; i++)
            {
                for (int j = 0; j < rang; j++)
                {
                    var value = rnd.Next(0, 10) > 6;
                    field.Set(i, j, value);
                }
            }

            return field;
        }
    }
}
