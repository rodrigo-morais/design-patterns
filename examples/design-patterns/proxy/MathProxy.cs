using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.proxy
{
    public class MathProxy
    {
        Math math = null;

        private Math createMath()
        {
            Console.WriteLine("Creating Math object.");
            return new Math();
        }

        public int sum(int a, int b) { 
            math = math == null ? createMath() : math;
            return math.sum(a, b); 
        }
        public int subtraction(int a, int b) {
            math = math == null ? createMath() : math;
            return math.subtraction(a, b);
        }
    
    }
}
