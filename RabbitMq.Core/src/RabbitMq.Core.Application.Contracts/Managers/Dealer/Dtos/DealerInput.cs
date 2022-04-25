using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Core.Application.Contracts.Managers.Dealer.Dtos
{
    public class DealerInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TaxNumber { get; set; }
    }
}
