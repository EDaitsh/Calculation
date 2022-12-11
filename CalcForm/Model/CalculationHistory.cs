using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm.Model
{
    public class CalculationHistory
    {
        public int Id { get; set; }
        public decimal field1 { get; set; }
        public decimal field2 { get; set; }
        public int operationTypeId { get; set; }
        public decimal result { get; set; }
        public DateTime calcDate { get; set; }
        public string operationTypeDesc { get; set; }


        public override string ToString()
        {
            return ($"{field1} {operationTypeDesc} {field2} = {result}");
        }
    }
}
