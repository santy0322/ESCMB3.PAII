using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Bus.notifications
{
    internal interface IRequestNotificationHandler<in TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
    {
    }
}
