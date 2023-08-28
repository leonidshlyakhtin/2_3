using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal interface IPair
    {
          
            IPair Add(Object obj);
            IPair Sub(Object obj);
            IPair Mult(double v);
            bool CompareTo(Object obj);




   
    }
}
