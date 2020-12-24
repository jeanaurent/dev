using System;

namespace devtestC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Gros!");

            var monTruc = new MonTruc
            {
                A = 6,
                B = 3,
                C = A / B
            };
        }

    class MonTruc {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
    }

    }
}
