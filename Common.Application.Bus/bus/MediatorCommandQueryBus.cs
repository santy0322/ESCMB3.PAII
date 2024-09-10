using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Bus.bus
{
    internal class MediatorCommandQueryBus: ICommandQueryBus
    {
        IMediator mediator;
        public MediatorCommandQueryBus(IMediator mediator)
        {

            this.mediator = mediator;
        }

        public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default) where TNotification : INotification
        {
            return mediator.Publish(notification, cancellationToken);
        }

    
        public Task Send<TRequest>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest
        {
            return mediator.Send(request, cancellationToken);                
        }
    }
}
