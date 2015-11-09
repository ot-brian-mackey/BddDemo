using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BddDemo.Lib;

namespace BddDemo.Controllers
{
    public class PaymentController : ApiController
    {
        private IPayment payment;

        public PaymentController(IPayment payment)
        {
            this.payment = payment;
        }
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public bool Post([FromBody]string creditCardNumber)
        {
            var result = payment.Accept(creditCardNumber);
            return result;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}