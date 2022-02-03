using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops
{
    internal class Generics<T1,T2>
    {
       public static bool AreEqual(T2 ab,T2 cd)
        {
            return ab.Equals(cd);
        }
        public static void Display(T1 a,T1 b)
        {
            Console.WriteLine(a + "" + b);
        }
    }
}
