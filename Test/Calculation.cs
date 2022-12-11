using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Context;
using Test.Models;
using Test.Operation;
using static Test.Operation.IOperationFactory;

namespace Test
{
    public class Calculation
    {
        private IOperatinFactory operationFactory = new IOperatinFactory();
        private CalculationContext _calculationContext;

        public Calculation(CalculationContext calculationContext)
        {
            _calculationContext = calculationContext;
        }

        public ResultCalculation Calc(CalculateInfo info)
        {
            //calc
            IOperation operation = operationFactory.GetOperation((OperationType)info.Operation);
            decimal res =  operation.calc(info.Field1, info.Field2);

            //calc history
            var calculationHistories = _calculationContext.CalculationHistories.FromSqlRaw($"EXECUTE dbo.GetRecentOperationsByOperationType {info.Operation}")
                .ToList();
            calculationHistories.ForEach(ch => ch.operationTypeDesc = Enum.GetName(typeof(OperationType), info.Operation));

            //calc count
            var calcCount = _calculationContext.Set<ScalarInt>()
                    .FromSqlRaw($"EXECUTE dbo.GetCountOperationsByOperationType {info.Operation}")
                    .AsEnumerable()
                    .First().Value;

            //min, max, avg calc
            var minMaxAvg = _calculationContext.Set<MinMaxAvgScalar>()
                    .FromSqlRaw($"EXECUTE dbo.GetMinMaxAveOperationsByOperationType {info.Operation}")
                    .AsEnumerable()
                    .First();

            //save calc
            CalculationHistory calculation =
               new CalculationHistory
               {
                   field1 = info.Field1,
                   field2 = info.Field2,
                   operationTypeId = info.Operation,
                   result = res,
                   calcDate = DateTime.Now
               };
            _calculationContext.CalculationHistories.Add(calculation);
            _calculationContext.SaveChanges();

            //return object
            return new ResultCalculation
            {
                Restult = res,
                CalculationHistories = calculationHistories,
                CountInCurrentMonth = calcCount,
                AvgCalc = minMaxAvg.Avg,
                MaxCalc = minMaxAvg.Max,
                MinCalc = minMaxAvg.Min
            };
        }
    }
}
