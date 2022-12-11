using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public partial class ScalarInt
    {
        public int Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }

    public partial class MinMaxAvgScalar
    {
        public decimal Min { get; set; }
        public decimal Max { get; set; }
        public decimal Avg { get;set; }
    }
}
