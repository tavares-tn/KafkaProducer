using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class KafkaController: ControllerBase
    {
        public IKafkaService _service { get; set; }

        public KafkaController(IKafkaService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> Post(string evento)
        {
            try
            {
                var result = await _service.Post(evento);

                return Ok(result);
            }
            catch (ArgumentException Aex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, Aex.Message);
            }
        }

    }
}
