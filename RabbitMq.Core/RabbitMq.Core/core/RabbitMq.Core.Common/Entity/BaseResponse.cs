using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RabbitMq.Core.Common.Entity
{
    public class BaseResponse<TData>
    {
        public BaseResponse()
        {
            Total = 0;
            Errors = new List<string>();
        }

        public bool HasError => Errors.Any();
        public List<string> Errors { get; set; }
        public long Total { get; set; }
        public TData Data { get; set; }
    }
}
