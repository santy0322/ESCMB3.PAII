using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Bus.bus
{
    public interface ICommandQueryBus 
    {
        Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default);

        Task Publish <TNotification> (TNotification notification, CancellationToken cancellationToken = default)
        where TNotification : INotification;
    }
}
