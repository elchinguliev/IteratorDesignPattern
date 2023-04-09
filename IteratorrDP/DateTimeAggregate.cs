using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorrDP
{
    class DateTimeAggregate : IAggregate
    {
        public DateTime startDate;
        public DateTime endDate;
        public IIterator CreateIterator() => new DateTimeIterator(this);
    }
}
