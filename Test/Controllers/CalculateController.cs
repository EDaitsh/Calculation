using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test.Context;
using Test.Models;
using Test.Operation;
using static Test.Operation.IOperationFactory;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        private Calculation _calculation;
        private IOperatinFactory operationFactory = new IOperatinFactory();

        public CalculateController(CalculationContext calculationContex )
        {
            _calculation = new Calculation(calculationContex);
        }
        // GET: api/Calculate
        [HttpGet]
        public Dictionary<int, string> GetOparation()
        {
            return Enum.GetValues(typeof(OperationType))
                           .Cast<OperationType>()
                           .ToDictionary(t => (int)t, t => t.ToString());
        }

        // POST: api/Calculate
        [HttpPost]
        public ResultCalculation Calc([FromBody] CalculateInfo info)
        {
            return _calculation.Calc(info);
        }
    }
}
