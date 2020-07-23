using Microsoft.AspNetCore.Mvc;
using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiEnquete.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        private readonly IApplicationServiceOption applicationServiceOption;

        public OptionController(IApplicationServiceOption applicationServiceOption)
        {
            this.applicationServiceOption = applicationServiceOption;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceOption.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceOption.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] OptionDto optionDto)
        {
            try
            {
                if (optionDto == null)
                    return NotFound();

                applicationServiceOption.Add(optionDto);
                return Ok("Opção cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] OptionDto optionDto)
        {
            try
            {
                if (optionDto == null)
                    return NotFound();

                applicationServiceOption.Update(optionDto);
                return Ok("Opção atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] OptionDto optionDto)
        {
            try
            {
                if (optionDto == null)
                    return NotFound();

                applicationServiceOption.Remove(optionDto);
                return Ok("Opção removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}