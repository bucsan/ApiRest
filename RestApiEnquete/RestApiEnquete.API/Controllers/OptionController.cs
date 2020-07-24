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
        private readonly IApplicationServiceOption applicationServiceProduto;

        public OptionController(IApplicationServiceOption applicationServiceProduto)
        {
            this.applicationServiceProduto = applicationServiceProduto;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceProduto.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceProduto.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] OptionDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();


                applicationServiceProduto.Add(produtoDTO);
                return Ok("O produto foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] OptionDto produtoDTO)
        {

            try
            {
                if (produtoDTO == null)
                    return NotFound();

                applicationServiceProduto.Update(produtoDTO);
                return Ok("O produto foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] OptionDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                applicationServiceProduto.Remove(produtoDTO);
                return Ok("O produto foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}