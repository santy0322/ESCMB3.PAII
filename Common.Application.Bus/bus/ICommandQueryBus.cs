using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Bus.bus
{
    internal interface ICommandQueryBus 
    {
        Task Send<TRequest>(TRequest request, CancellationToken cancellationToken = default)
        where TRequest : IRequest;

        Task Publish <TNotification> (TNotification notification, CancellationToken cancellationToken = default)
        where TNotification : INotification;
    }
}
