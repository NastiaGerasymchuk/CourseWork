using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class GetPolynomPayload
    {
          public UInt64 start { get; set; }
          public int countQuestionsFunction { get; set; }
          public int k { get; set; }
          public int n { get; set; }
          public int rowCount { get; set; }
          public int[][] arrV { get; set; }
          public string[] pArr { get; set; }
         public string fX { get; set; }
    }
}
