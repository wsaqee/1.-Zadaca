using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerList Lista1 = new IntegerList();
            Lista1.Add(1);
            Lista1.Add(2);
            Lista1.Add(3);
            Lista1.Add(4);
            Lista1.Add(5);

            IspisiElemente(Lista1);

            Lista1.RemoveAt(0);
            IspisiElemente(Lista1);

            Lista1.Remove(5);
            IspisiElemente(Lista1);

            Console.WriteLine("Number of elements " + Lista1.Count + "\n");

            Console.WriteLine("Lista1.Remove(100)");
            Console.WriteLine(Lista1.Remove(100) + "\n");

            Console.WriteLine("Lista1.RemoveAt(5)");
            Console.WriteLine(Lista1.RemoveAt(5) + "\n");

            Lista1.Clear();

            IspisiElemente(Lista1);

        }

        static void IspisiElemente (IntegerList L1)
        {
            for (int i = 0; i < L1.Count; i++)
            {
                Console.WriteLine(L1.GetElement(i));
            }
            Console.WriteLine("\n");
        }
    }
}
