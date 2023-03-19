using Domain.DTOs;
using Domain.DTOs.Request;
using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class ExamplesController: ControllerBase
    {
        public IExampleService _service { get; set; }

        public ExamplesController(IExampleService service)
        {
            _service = service;
        }

        /// <summary>
        /// Retorna todos os regesitros
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if(!ModelState.IsValid)
                    //  400 bad request - solicitação inválida
                    return BadRequest(ModelState);

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Retorna um registro pelo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}", Name = "GetWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
                //  400 bad request - solicitação inválida
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Cria um registro
        /// </summary>
        /// <param name="example"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] RequestExampleDto example)
        {
            if (!ModelState.IsValid)
                //  400 bad request - solicitação inválida
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Post(example);

                if (result != null)
                    return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), result);
                else
                    return BadRequest();

            }
            catch (ArgumentException Aex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, Aex.Message);
            }
        }

        /// <summary>
        /// Atualiza um registro
        /// </summary>
        /// <param name="example"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ExampleDto example)
        {
            if (!ModelState.IsValid)
                //  400 bad request - solicitação inválida
                return BadRequest(ModelState);

            try
            {
                var result = await _service.Put(example);

                if (result != null)
                    return Ok(result);
                else
                    return BadRequest();
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Remove um registro (delete lógico)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
                //  400 bad request - solicitação inválida
                return BadRequest(ModelState);

            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
