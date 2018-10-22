using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vettore= { 1, 5, 2, 7, 20, 34, 56, 8, 30, 41 };
            int ValoreMassimo = Vettore.Max();
            int IndexMassimo = Vettore.ToList().IndexOf(ValoreMassimo);
            int ValoreMinimo = Vettore.Min();
            int IndexMinimo = Vettore.ToList().IndexOf(ValoreMinimo);
            Console.WriteLine("Il valore massimo è " + ValoreMassimo + " e si trova nella posizione " + IndexMassimo);
            Console.WriteLine("Il valore minimo è " + ValoreMinimo + " e si trova nella posizione " + IndexMinimo);
            Console.ReadKey();
        }
    }
}
