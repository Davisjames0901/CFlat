using System;

namespace Digman.IO.CFlat.Helpers
{
    public class ConsoleHelpers
    {
        public static void PrintError(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}