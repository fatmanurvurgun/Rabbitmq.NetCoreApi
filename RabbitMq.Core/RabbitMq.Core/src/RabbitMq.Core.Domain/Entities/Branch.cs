using RabbitMq.Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Core.Domain.Entities
{
    public class Branch : BaseEntity
    {
        public string Name { get; set; }
        public string Manager { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int DealerId { get; set; }
        public int IsActive { get; set; }
        public Dealer Dealer { get; set; }
    }
}
