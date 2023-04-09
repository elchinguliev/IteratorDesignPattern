using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorrDP
{
    internal interface IAggregate
    {
        IIterator CreateIterator();
    }
}
