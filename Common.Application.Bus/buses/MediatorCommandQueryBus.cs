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


        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            return mediator.Send(request, cancellationToken);
        }
    }
}
