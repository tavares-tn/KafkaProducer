﻿using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class OpportunitController : ControllerBase
    {
        public IOpportunitService _service { get; set; }

        public OpportunitController(IOpportunitService service)
        {
            _service = service;
        }

        /// <summary>
        /// Requisição Get API extrena
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                return Ok( await _service.Get());
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
