using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.proxy
{
    public class MathProxy
    {
        Operations operation;
        Math math = new Math();

        public MathProxy(Operations operation) { this.operation = operation; }

        public int calc(int a, int b)
        {
            if (this.operation == Operations.SUM)
            {
                return math.sum(a, b);
            }
            else
            {
                return math.subtraction(a, b);
            }
        }
    
    }
}
