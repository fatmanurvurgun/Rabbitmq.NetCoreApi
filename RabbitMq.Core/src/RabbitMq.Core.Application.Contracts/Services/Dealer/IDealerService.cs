using RabbitMq.Core.Application.Contracts.Managers.Dealer.Dtos;
using RabbitMq.Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Core.Application.Contracts.Services.Dealer
{
    public interface IDealerService
    {
        BaseResponse<List<DealerOutput>> GetAll();
        void Add(DealerInput dealerInput);
        void Update(DealerInput dealerInput);
        void Delete(int id);
        BaseResponse<DealerOutput> GetById(int id);

    }
}
