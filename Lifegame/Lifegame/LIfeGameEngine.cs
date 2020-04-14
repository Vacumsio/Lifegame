using System;

namespace Lifegame
{
    public static class LifeGameEngine
    {
        public static Field GetNextGeneration(Field currentField)
        {
            var resultField = new Field(currentField.Rows, currentField.Cols);
            
            currentField.Filed[0][0] = true;
            Console.WriteLine(currentField.Filed[0][0]);
            int counter;

            for (int i = 0; i < currentField.Rows; i++)
            {

                for (int j = 0; j < currentField.Cols; j++)
                {

                    for (int g = 0; g < 7; g++)
                    {
                        var cur = currentField.Filed[i][j];
                        counter = 0;

                        if (i >= 1 && j >= 1)//1
                        {
                            if (currentField.Filed[i - 1][j - 1] == true) { counter++; }
                        }
                        if (i >= 1)//2
                        {
                            if (currentField.Filed[i - 1][j] == true) { counter++; }
                        }
                        if (i >= 1 && j < currentField.Rows-1)//3
                        {
                            if (currentField.Filed[i - 1][j + 1] == true) { counter++; }
                        }
                        if (j >= 1)//4
                        {
                            if (currentField.Filed[i][j - 1] == true) { counter++; }
                        }
                        if (j < currentField.Rows - 1)//5
                        {
                            if (currentField.Filed[i][j + 1] == true) { counter++; }
                        }
                        if (i < currentField.Cols - 1 && j >= 1)//6
                        {
                            if (currentField.Filed[i + 1][j - 1] == true) { counter++; }
                        }
                        if (i < currentField.Cols - 1)//7
                        {
                            if (currentField.Filed[i + 1][j] == true) { counter++; }
                        }
                        if (i < currentField.Cols - 1 && j < currentField.Rows - 1)//8
                        {
                            if (currentField.Filed[i + 1][j + 1] == true) { counter++; }
                        }

                        if (counter < 2 || counter > 3)
                        {
                            resultField.Filed[i][j] = false;
                        }

                        if (counter > 3)
                        {
                            resultField.Filed[i][j] = false;
                        }

                        if (counter == 3)
                        {
                            resultField.Filed[i][j] = true;
                        }
                        if (counter == 2 && cur == true)
                        {
                            resultField.Filed[i][j] = true;
                        }
                    }
                }
            }

            return resultField;
        }
    }
}
