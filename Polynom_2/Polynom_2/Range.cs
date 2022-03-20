using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public static class Range
    {
        public static IEnumerable<ulong> UInt64(ulong from, ulong to, ulong step)
        {
            if (step == 0UL) step = 1UL;

            if (from <= to)
            {
                for (ulong ul = from; ul <= to; ul += step) yield return ul;
            }
            else
            {
                for (ulong ul = from; ul >= to; ul -= step) yield return ul;
            }
        }
    }
}
