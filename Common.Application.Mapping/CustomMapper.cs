using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Application.Mapping
{
    public static class CustomMapper
    {
        public static IMapper Instance { get; set; }

        public static T To<T>(this object input)
        {
            IMapper mapper = Instance;
            return mapper.Map<T>(input);
        }

        public static T To<T>(this IValidate input)
        {
            IMapper mapper = Instance;

            return mapper.Map<T>(input);
        }

        public static IEnumerable<T> To<T>(this IEnumerable<IValidate> input)
        {
            IMapper mapper = Instance;
            return mapper.Map<IEnumerable<T>>(input);
        }
    }
}
