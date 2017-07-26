using SharedLibrary;
using System;

namespace ProjectReference
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new SharedClass();

            s.MagicNumber = 5;

            var result = s.MultiplyMagicNumber(3);

            Console.WriteLine(result);

            Console.ReadLine();

            SharedStruct s2;
            s2.IntA = 1;
            s2.IntB = 3;

            SharedClass.ReverseToString<int>(2);
        }
    }
}
