using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        protected readonly IPaymentRepository _repository;


        public PaymentController(IPaymentRepository repository)
        {
            _repository = repository;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<PaymentDomain> GetById(int id)
        {
            try
            {
                var result = _repository.GetById(id);
                
                return Ok(result);
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }
        // POST api/values
        [HttpPost]
        public ActionResult<string> Insert([FromBody] PaymentDomain obj)
        {
            try
            {                
                var result = _repository.Insert(obj);

                if (result)
                    return Ok();
                else
                    return new StatusCodeResult(500);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult<string> Put([FromBody] PaymentDomain obj)
        {
            try
            {                
                var result = _repository.Update(obj);

                if (result)
                    return Ok();
                else
                    return new StatusCodeResult(500);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
