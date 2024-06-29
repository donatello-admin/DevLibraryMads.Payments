using DevLibraryMads.Payments.API.Models.Entities;
using DevLibraryMads.Payments.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace DevLibraryMads.Payments.API.Controllers
{
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {

        private readonly IPaymentsService _paymentsService;

        public PaymentsController(IPaymentsService paymentsService)
        {
            _paymentsService = paymentsService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentsDTO paymentsDTO)
        {
            var payments = await _paymentsService.Process(paymentsDTO);

            if (!payments)
                return BadRequest();


            return Ok(payments);
        }
    }
}
