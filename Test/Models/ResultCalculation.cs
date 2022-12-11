using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    [Serializable]
    public class ResultCalculation
    {
        public decimal Restult { get; set; }
        public List<CalculationHistory> CalculationHistories { get; set; }
        public int CountInCurrentMonth { get; set; }
        public decimal MaxCalc { get; set; }
        public decimal MinCalc { get; set; }
        public decimal AvgCalc { get; set; }
    }
}
