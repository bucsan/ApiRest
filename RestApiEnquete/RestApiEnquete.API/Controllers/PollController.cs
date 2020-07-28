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

        private readonly IApplicationServicePoll _applicationServicePoll;


        public PollController(IApplicationServicePoll applicationServicePoll)
        {
            _applicationServicePoll = applicationServicePoll;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationServicePoll.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            try
            {
                var result = _applicationServicePoll.GetByIdResponse(id);

                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] PollDto pollDTO)
        {
            try
            {
                if (pollDTO == null)
                    return NotFound();

                _applicationServicePoll.Add(pollDTO);
                return Ok("Enquete cadastrado com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] PollDto pollDTO)
        {
            try
            {
                if (pollDTO == null)
                    return NotFound();

                _applicationServicePoll.Update(pollDTO);
                return Ok("Enquete atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] PollDto pollDTO)
        {
            try
            {
                if (pollDTO == null)
                    return NotFound();

                _applicationServicePoll.Remove(pollDTO);
                return Ok("Enquete removido com sucesso!");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}