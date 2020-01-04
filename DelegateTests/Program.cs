using System;

namespace DelegateTests
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
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"r = {r}");
        }
    }
}
