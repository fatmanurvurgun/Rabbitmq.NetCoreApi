using RabbitMq.Core.Application.Contracts.Managers.Dealer;
using RabbitMq.Core.Application.Contracts.Managers.Dealer.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Core.Application.Managers.Dealer
{
    public class DealerManager : IDealerManager
    {
        public List<DealerOutput> GetAllDealers()
        {
            throw new NotImplementedException();
        }

        public DealerOutput GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
