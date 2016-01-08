using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.iterato
{
    class Tasks : IAggregate
{
    List<string> values = null;

    public Tasks()
    {
        this.values = new List<string>();
    }

    #region IAggregate Members

    public IIterator GetIterator()
    {
        return new Iterator(this);
    }

    #endregion

    public string this[int itemIndex]
    {
        get
        {
            if (itemIndex < this.values.Count)
            {
                return this.values[itemIndex];
            }
            else
            {
                return string.Empty;
            }
        }
        set
        {                
            this.values.Add(value);                                
        }
    }

    public int Count
    {
        get
        {
            return this.values.Count;
        }
    }
}
}
