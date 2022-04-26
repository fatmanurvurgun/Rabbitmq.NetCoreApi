using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RabbitMq.Core.Application.Contracts.Managers.Dealer.Dtos;
using RabbitMq.Core.Application.Contracts.Services.Dealer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RabbitMq.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerController : ControllerBase
    {
        private readonly IDealerService _dealerService;

        public DealerController(IDealerService dealerService)
        {
            _dealerService = dealerService;
        }
        [HttpGet("get-all")]
        public IActionResult GetAllDealers()
        {
            var result = _dealerService.GetAll();

            if (result.HasError)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("save")]
        public IActionResult Save(DealerInput dealerInput)
        {
            _dealerService.Add(dealerInput);

            return Ok();
        }

        [HttpPost("update")]
        public IActionResult Update(DealerInput dealerInput)
        {
            _dealerService.Update(dealerInput);

            return Ok();
        }

        [HttpGet("{id}/get")]
        public IActionResult GetById(int id)
        {
            var result = _dealerService.GetById(id);

            if (result.HasError)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            _dealerService.Delete(id);
            return Ok();
        }
    }
}
