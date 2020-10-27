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

            int ma = Massimo(vett);

            Console.WriteLine("Il valore massimo è: " + ma);

        }

        static void Ordina(int [] v)
        {
            Array.Sort(v);
        }

        static int Minimo(int [] v)
        {
            return v[0];
        }

        static int Massimo(int[] v)
        {
            return v[9];
        }
    }
}
