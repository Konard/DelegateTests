using System;

namespace DelegateTests.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic();
            StructTest.Run();
            ClassTest.Run();
        }

        private static void Basic()
        {
            var a = 0;
            Func<int> x = () => (a++, 0).Item2;
            x += () => (a++, 1).Item2;
            x -= () => (a++, 0).Item2;
            var r = x();
            System.Console.WriteLine($"a = {a}");
            System.Console.WriteLine($"r = {r}");
        }
    }
}
