using System;

namespace Lifegame
{
    class Program
    {
        static void Main(string[] args)
        {
            var filed = FieldCreator.CreateField(25);
            filed.PrintToConsole();
            var newlife = LifeGameEngine.GetNextGeneration(filed);
            newlife.PrintToConsole();

            Console.ReadKey();
        }
    }
}
