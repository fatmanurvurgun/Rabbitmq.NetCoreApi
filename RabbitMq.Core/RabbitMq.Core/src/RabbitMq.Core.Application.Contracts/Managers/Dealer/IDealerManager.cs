using RabbitMq.Core.Application.Contracts.Managers.Dealer.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Core.Application.Contracts.Managers.Dealer
{
    public interface IDealerManager
    {
        List<DealerOutput> GetAllDealers();
        DealerOutput GetById(int id);
    }
}
