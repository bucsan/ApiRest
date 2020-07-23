using Microsoft.AspNetCore.Mvc;
using RestApiEnquete.Application.Dtos;
using RestApiEnquete.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiEnquete.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PollController : ControllerBase
    {
        private readonly IApplicationServicePoll applicationServicePoll;

        public PollController(IApplicationServicePoll applicationServicePoll)
        {
            this.applicationServicePoll = applicationServicePoll;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServicePoll.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServicePoll.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PollDto pollDto)
        {
            try
            {
                if (pollDto == null)
                    return NotFound();

                applicationServicePoll.Add(pollDto);
                return Ok("Enquete cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PollDto pollDto)
        {
            try
            {
                if (pollDto == null)
                    return NotFound();

                applicationServicePoll.Update(pollDto);
                return Ok("Enquete atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PollDto pollDto)
        {
            try
            {
                if (pollDto == null)
                    return NotFound();

                applicationServicePoll.Remove(pollDto);
                return Ok("Enquete removida com sucesso!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}