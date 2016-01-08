using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.iterato
{
    class Iterator : IIterator
    {
        IAggregate aggregate = null;
        int currentIndex = 0;

        public Iterator(IAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        #region IIterator Members

        public string FirstItem
        {
            get
            {
                this.currentIndex = 0;
                return this.aggregate[this.currentIndex];
            }
        }

        public string NextItem
        {
            get
            {
                this.currentIndex += 1;

                if (IsDone == false)
                {
                    return this.aggregate[this.currentIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string CurrentItem
        {
            get
            {
                return this.aggregate[this.currentIndex];
            }
        }

        public bool IsDone
        {
            get
            {
                if (this.currentIndex < this.aggregate.Count)
                {
                    return false;
                }
                return true;
            }
        }

        #endregion
    }
}
