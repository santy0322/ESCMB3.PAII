using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Bus.queries
{
    public interface IRequestQueryHandler<in TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
    }

    public interface IRequestQueryHandler<in TRequest> : IRequestHandler<TRequest>
        where TRequest : IRequest
    {
    }
}
