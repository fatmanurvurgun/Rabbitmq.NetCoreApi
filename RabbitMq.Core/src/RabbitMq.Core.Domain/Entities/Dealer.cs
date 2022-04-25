using RabbitMq.Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Core.Domain.Entities
{
    public class Dealer : BaseEntity
    {
        public string Name { get; set; }
        public string TaxNumber { get; set; }

        public ICollection<Branch> Branches { get; set; }
    }
}
