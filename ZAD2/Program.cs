using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenericList<string> Lista1 = new GenericList<string>();
            Lista1.Add("Hello");
            Lista1.Add("World");
            Lista1.Add("!");

            Console.WriteLine("Number of elements " + Lista1.Count + "\n");

            Console.WriteLine("String contains Hello " + Lista1.Contains("Hello") + "\n");
            Console.WriteLine("String contains Hellow " + Lista1.Contains("Hellow") + "\n");

            Console.WriteLine("Index of Hello " + Lista1.IndexOf("Hello") + "\n");
            Console.WriteLine("Index of Hellow " + Lista1.IndexOf("Hellow") + "\n");

            Console.WriteLine("Element at index 1 " + Lista1.GetElement(1) + "\n");

            IGenericList<double> Lista2 = new GenericList<double>();
            Lista2.Add(0.2);
            Lista2.Add(0.7);

            IspisiElemente<double>(Lista2);

        }

        static void IspisiElemente<X>(IGenericList<X> L1)
        {
            for (int i = 0; i < L1.Count; i++)
            {
                Console.WriteLine(L1.GetElement(i));
            }
            Console.WriteLine("\n");
        }
    }
}
