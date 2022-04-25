using RabbitMq.Core.Application.Contracts.Managers.Dealer;
using RabbitMq.Core.Application.Contracts.Managers.Dealer.Dtos;
using RabbitMq.Core.Application.Contracts.Services.Dealer;
using RabbitMq.Core.Common.Entity;
using RabbitMq.Core.Data.Interfaces;
using RabbitMq.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMq.Core.Application.Services
{
    public class DealerService : IDealerService
    {
        private IRepository<Dealer> _dealerRepository;
        private IDealerManager _dealerManager;
        public DealerService(IRepository<Dealer> dealerRepository,
            IDealerManager dealerManager)
        {
            _dealerRepository = dealerRepository;
        }
        public void Add(DealerInput dealerInput)
        {
            var dealer = new Dealer()
            {
                Name = dealerInput.Name,
                TaxNumber = dealerInput.TaxNumber
            };
            _dealerRepository.InsertAsync(dealer);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<List<DealerOutput>> GetAll()
        {
            throw new NotImplementedException();
        }

        public BaseResponse<DealerOutput> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DealerInput dealerInput)
        {                                                                                                                         
            var dealer = _dealerRepository.GetByIdAsync(dealerInput.Id);
                            
0            dealer.Name = dealerInput.Name;
            dealer.TaxNumber = dealerInput.TaxNumber;

            _dealerRepository.UpdateAsync(dealer);
        }
    }
}
