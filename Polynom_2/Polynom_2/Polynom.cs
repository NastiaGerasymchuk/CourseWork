using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public class Polynom:IComparable<Polynom>
    {
        public string ResPolynom { get; set; }
        public int OperationCount { get; set; }
        public Polynom()
        {
            ResPolynom = "";
            OperationCount = 0;
        }
        public int CompareTo(Polynom other) { return OperationCount.CompareTo(other.OperationCount); }
        public static Polynom GetMin(List<Polynom> polynoms,out int  countOp)
        {
            countOp = 0;
            //знайходимо всеможливі поліноми із мінімальною кількістю операцій
            var resPol = from p in polynoms
                         where p.OperationCount == (from m in polynoms
                                                    select m.OperationCount).Min()
                         select new Polynom
                         {
                             OperationCount = p.OperationCount,
                             ResPolynom = p.ResPolynom,
                         };
            Polynom polynom = new Polynom();
            polynom = resPol.Min();
            polynom.ResPolynom = "";
            foreach(Polynom item in resPol)
            {
                countOp += 1;
                polynom.ResPolynom += item.ResPolynom;
            }
            
            return polynom;
        }
        
        
    }
}
