using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Core.Common.Entity
{
    public abstract partial class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
