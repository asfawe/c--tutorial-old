using System;

namespace C__with_cheatsheet
{
    class Program
    {
        enum Values { A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R = 18 }
        static void Main(string[] args)
        {
            Console.WriteLine((int)Values.A);
            Console.WriteLine((int)Values.B);
            Console.WriteLine((int)Values.C);
            Console.WriteLine((int)Values.D);
            Console.WriteLine((int)Values.E);
            Console.WriteLine((int)Values.F);
            Console.WriteLine((int)Values.G);
            Console.WriteLine((int)Values.H);
            Console.WriteLine((int)Values.I);
            Console.WriteLine((int)Values.J);
            Console.WriteLine((int)Values.K);
            Console.WriteLine((int)Values.L);
            Console.WriteLine((int)Values.M);
            Console.WriteLine((int)Values.N);
            Console.WriteLine((int)Values.O);
            Console.WriteLine((int)Values.P);
            Console.WriteLine((int)Values.Q);
            Console.WriteLine((int)Values.R);

        }
    }
}