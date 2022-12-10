using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Test.Operation;
using static Test.Operation.IOperationFactory;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private IOperatinFactory operationFactory = new IOperatinFactory();
        // GET: api/Calculate
        [HttpGet]
        public Dictionary<int, string> GetOparation()
        {
            //return Enum.GetNames(typeof(OperationType)).ToList();
            return Enum.GetValues(typeof(OperationType))
                           .Cast<OperationType>()
                           .ToDictionary(t => (int)t, t => t.ToString());
        }

        // POST: api/Calculate
        [HttpPost]
        public double Calc([FromBody] CalculateInfo info)
        {
            IOperation operation = operationFactory.GetOperation((OperationType)info.Operation);
            if (operation != null)
                return operation.calc(info.Field1, info.Field2);
            else return 0;
        }
    }
}
