using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.iterator
{
    public class Task
    {
        public string Value { get; set; }

        public Task next()
        {
            return null;
        }

        public Boolean hasNext()
        {
            return false;
        }
    }
}
