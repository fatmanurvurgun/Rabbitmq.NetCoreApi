using AutoMapper;
using RabbitMq.Core.Application.Contracts.Managers.Dealer;
using RabbitMq.Core.Application.Contracts.Managers.Dealer.Dtos;
using RabbitMq.Core.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RabbitMq.Core.Application.Managers.Dealer
{
    public class DealerManager : IDealerManager
    {
        private readonly IRepository<RabbitMq.Core.Domain.Entities.Dealer> _dealerRepository;

        public DealerManager(IRepository<RabbitMq.Core.Domain.Entities.Dealer> dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }
        public List<DealerOutput> GetAllDealers()
        {
            var result = _dealerRepository.Table.ToList();

            //TODO Return to mapping 
            var dealerOutputs = result.Select(x => new DealerOutput
            {
                Id = x.Id,
                Name = x.Name,
                TaxNumber = x.TaxNumber
            }).ToList();

            return dealerOutputs;
        }

        public DealerOutput GetById(int id)
        {
            var result = _dealerRepository.GetById(id);

            if (result == null)
                return null;

            var dealerOutput = new DealerOutput()
            {
                Id = result.Id,
                Name = result.Name,
                TaxNumber = result.TaxNumber
            };

            return dealerOutput;
        }
    }
}
