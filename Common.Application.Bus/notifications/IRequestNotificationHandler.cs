using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Bus.notifications
{
    public interface IRequestNotificationHandler<in TNotification> : INotificationHandler<INotification>
        where TNotification : INotification
    {
    }
}
