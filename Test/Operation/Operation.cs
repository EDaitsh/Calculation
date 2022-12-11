using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Operation
{
    public class Add : IOperation
    {
        public decimal calc(decimal field1, decimal field2)
        {
            return field1 + field2;
        }
    }

    public class Subtruct : IOperation
    {
        public decimal calc(decimal field1, decimal field2)
        {
            return field1 - field2;
        }
    }

    public class Multiply : IOperation
    {
        public decimal calc(decimal field1, decimal field2)
        {
            return field1 * field2;
        }
    }

    public class Devide : IOperation
    {
        public decimal calc(decimal field1, decimal field2)
        {

            if (field2 == 0)
                throw new Exception("Error");
            return field1 / field2;
        }

    }
}
