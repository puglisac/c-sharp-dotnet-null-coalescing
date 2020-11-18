using System;

namespace LearningNullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "hello";
            Console.WriteLine("s equals: "+s);
            s = null;
            var s2 = s ?? "default";
            Console.WriteLine("now s equals: "+s);
            Console.WriteLine("s2 equals: "+s2);
        }
    }
}
