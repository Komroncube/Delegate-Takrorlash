using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Takrorlash
{
    public class BaseMethod
    {
        public int FuncMethod(int a, int b, Func<int,int,int> function)
        {
            return function(a, b);
        }
        public void ActionMethod(double a, Action<double>action) 
        {
            action(a);
        }
        public bool PredicateMethod(int a, Predicate<int> predicate)
        {
            return predicate(a);
        }
    }
}
