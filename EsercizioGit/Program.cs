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
            int Casella1 = rnd.Next(101);
            int Casella2 = rnd.Next(101);
            int Casella3 = rnd.Next(101);
            int Casella4 = rnd.Next(101);
            int Casella5 = rnd.Next(101);
            int Casella6 = rnd.Next(101);
            int Casella7 = rnd.Next(101);
            int Casella8 = rnd.Next(101);
            int Casella9 = rnd.Next(101);
            int Casella10 = rnd.Next(101);

            int[] Vettore= { Casella1, Casella2, Casella3, Casella4, Casella5, Casella6, Casella7, Casella8, Casella9, Casella10 };
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
