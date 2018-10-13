using System;

namespace Lifegame
{
    class Program
    {
        static void Main(string[] args)
        {
            var filed = FieldCreator.CreateField(5);


            filed.PrintToConsole();
            Console.ReadKey();
        }
    }
}
