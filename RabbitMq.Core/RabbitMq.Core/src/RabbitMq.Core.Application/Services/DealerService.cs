using RabbitMq.Core.Application.Contracts.Managers.Dealer;
using RabbitMq.Core.Application.Contracts.Managers.Dealer.Dtos;
using RabbitMq.Core.Application.Contracts.Services.Dealer;
using RabbitMq.Core.Common.Entity;
using RabbitMq.Core.Data.Interfaces;
using RabbitMq.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMq.Core.Application.Services
{
    public class DealerService : IDealerService
    {
        private IRepository<Dealer> _dealerRepository;
        private IDealerManager _dealerManager;
        public DealerService(IRepository<Dealer> dealerRepository,
            IDealerManager dealerManager)
        {
            _dealerManager = dealerManager;
            _dealerRepository = dealerRepository;
        }
        public void Add(DealerInput dealerInput)
        {
            var dealer = new Dealer()
            {
                Name = dealerInput.Name,
                TaxNumber = dealerInput.TaxNumber
            };
            _dealerRepository.Insert(dealer);
        }

        public void Delete(int id)
        {
            var dealer = _dealerRepository.GetById(id);
        }

        public BaseResponse<List<DealerOutput>> GetAll()
        {
            BaseResponse<List<DealerOutput>> baseResponse = new BaseResponse<List<DealerOutput>>();
            try
            {
                baseResponse.Data = _dealerManager.GetAllDealers();
            }
            catch (Exception ex)
            {
                baseResponse.Errors.Add(ex.ToString());
            }
            return baseResponse;
        }

        public BaseResponse<DealerOutput> GetById(int id)
        {
            BaseResponse<DealerOutput> baseResponse = new BaseResponse<DealerOutput>();
            try
            {
                baseResponse.Data = _dealerManager.GetById(id);
            }
            catch (Exception ex)
            {
                baseResponse.Errors.Add(ex.ToString());
            }
            return baseResponse;
        }

        public void Update(DealerInput dealerInput)
        {
            var dealer = _dealerRepository.GetById(dealerInput.Id);

            dealer.Name = dealerInput.Name;
            dealer.TaxNumber = dealerInput.TaxNumber;

            _dealerRepository.Update(dealer);
        }
    }
}
