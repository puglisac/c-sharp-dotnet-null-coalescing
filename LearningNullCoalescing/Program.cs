using System;

namespace LearningNullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "hello";
            var s2 = s ?? "default";

            Console.WriteLine("s equals: "+s);
            s = null;
            Console.WriteLine("now s equals: "+s);
            Console.WriteLine("s2 equals: "+s2);
        }
    }
}
