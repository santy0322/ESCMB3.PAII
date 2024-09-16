using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Bus.notifications
{
    public class DomainEvent:IRequestNotification
    {
        public DateTime EventDateUtc { get; private set; }

        public DomainEvent()
        {
            EventDateUtc = DateTime.UtcNow;
        }

        public DomainEvent(DateTime createDateUtc)
        {
            EventDateUtc = createDateUtc;
        }
    }
}
