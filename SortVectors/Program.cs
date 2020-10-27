using System;

namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vett = new int [10] {-9, 8,100,1004,-78,-97,44,65,-43,0};

            Ordina(vett);

            int mi = Minimo(vett);

            Console.WriteLine("Il valore minimo è: " + mi);

        }

        static void Ordina(int [] v)
        {
            Array.Sort(v);
        }

        static int Minimo(int [] v)
        {
            return v[0];
        }
    }
}
