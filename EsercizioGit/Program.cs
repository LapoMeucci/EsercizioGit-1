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
            Random rnd = new Random();
            int[] Vettore = new int[10];
            for(int i = 0; i < Vettore.Length; i++)
            {
                Vettore[i] = rnd.Next(101);
            }
            Array.Sort(Vettore);
            int ValoreMassimo = Vettore.Max();
            int IndexMassimo = Vettore.ToList().IndexOf(ValoreMassimo);
            int ValoreMinimo = Vettore.Min();
            int IndexMinimo = Vettore.ToList().IndexOf(ValoreMinimo);
            Console.WriteLine("Il valore massimo è " + ValoreMassimo + " e si trova nella posizione " + IndexMassimo);
            Console.WriteLine("Il valore minimo è " + ValoreMinimo + " e si trova nella posizione " + IndexMinimo);
            foreach (int i in Vettore) Console.Write(i + " ");
            Console.ReadKey();
        }
    }
}
