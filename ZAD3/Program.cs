using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAD2;

namespace ZAD3
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenericList<string> L1 = new GenericList<string>();
            L1.Add("Rijec1");
            L1.Add("Rijec2");
            L1.Add("Rijec3");
            foreach (var item in L1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
