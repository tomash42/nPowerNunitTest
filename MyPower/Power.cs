using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPower;

namespace MyPower
{
  public  class Power
    {
     
        public int PowerCalc(int a , int exp)
        {
            if (exp < 0) throw new ArgumentOutOfRangeException(nameof(exp),$"Exponent is less than zero and must be greater than -1. Your exponent is equal  {exp} ");
            int result = 1;
            for (int i = 1; i <= exp; i++)
            {
                Console.WriteLine("{0} {1} {2}",a ,result,i);
                result =a * result;
             
            }
            Console.WriteLine(result);
            return result;
        }
        
    }
}
