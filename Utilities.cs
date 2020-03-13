using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialInput
{
    static class Utilities
    {
        static readonly Random r = new Random();
        static public T[] Shuffle<T>(T[] list)
        {
            int count = r.Next (10, 200);
            for (int i = 0; i < count; i++)
            {
                int ia = r.Next (list.Length);
                int ib = r.Next (list.Length);
                T tmp = list[ia];
                list[ia] = list[ib];
                list[ib] = tmp;
            }
            return list;
        }
    }
}
