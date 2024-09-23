using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Bus.commands
{
    public interface IRequestCommand : IRequest
    {
    }

    public interface IRequestCommand<out TResponse> : IRequest<TResponse>
    {
    }
}
