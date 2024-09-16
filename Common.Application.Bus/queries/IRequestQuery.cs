using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Bus.queries
{
    public interface IRequestQuery<TResponse> where TResponse : class
    {
    }
}
