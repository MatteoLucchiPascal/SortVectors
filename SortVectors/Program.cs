using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vett = new int [10] {-9, 8,100,1004,-78,-97,44,65,-43,0};

            Ordina(vett);

            for (int i = 0; i < 10; i++)
                Console.WriteLine(vett[i]);
        }

        static void Ordina(int [] v)
        {
            Array.Sort(v);
        }

    }
}
