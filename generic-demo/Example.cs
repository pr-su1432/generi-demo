using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_demo
{
    public class Example<T>where T:IComparable
    {
        public int Maximumnumofintegers(int firstvalue, int secondvalue, int thirdvale)
        {
            if(firstvalue>secondvalue && firstvalue>thirdvale)
            {
                return firstvalue;
                
            }
            else if(secondvalue > firstvalue && secondvalue > thirdvale)
            {
                return secondvalue;
         
            }
            else
            {
                return thirdvale;
            }

        }

        internal bool maximumnumOfIntegers(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }
    }
}
