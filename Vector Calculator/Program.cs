using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(3, 1, 7);  
            Vector test2 = new Vector(2, 6, 0);
            Vector test3 = new Vector(4, 3, 1);
            Vector test4 = new Vector(2, 5, 1);
            Vector test6 = new Vector(4, 3, 1);
            Vector test7 = new Vector(-2, -5, -1);
            Vector test5 = new Vector(3, 6, 2);
            Vector test8 = new Vector(2, 4, 5);
            Vector test9 = new Vector(3, 2, 0);
            Vector test10 = new Vector(2, 4, 1); // 1, 8, 4
            Vector test11 = new Vector(6, 2, 1); // 5, 7, 2
            Vector test12 = new Vector(2, 4, 5);
            Vector test13 = new Vector(3, 6, 1);
            Vector test14 = new Vector(2, 4, 1);
            Vector test15 = new Vector(6, 2, 1);
            Vector test16 = new Vector(3, 7, 1);
            Vector test17 = new Vector(5, 2, 1);

            Console.WriteLine(test1.GetMagnitude());
            Console.WriteLine(test2.GetDirection());
            Console.WriteLine(Vector.Add(test3, test4));
            Console.WriteLine(Vector.Negate(test5));
            Console.WriteLine(Vector.Subtract(test6, test7));
            Console.WriteLine(Vector.Scale(test8));
            Console.WriteLine(Vector.Normalize(test9).GetMagnitude());
            Console.WriteLine(Vector.GetDotProduct(test10, test11));
            Console.WriteLine(Vector.CrossProduct(test12, test13));
            Console.WriteLine(Vector.AngleBetween(test14, test15));
            Console.WriteLine(Vector.ProjectOnto(test16, test17));
        }
    }
}
