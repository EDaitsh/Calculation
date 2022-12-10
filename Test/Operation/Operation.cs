using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Operation
{
    public class Add : IOperation
    {
        public double calc(double field1, double field2)
        {
            return field1 + field2;
        }
    }

    public class Subtruct : IOperation
    {
        public double calc(double field1, double field2)
        {
            return field1 - field2;
        }
    }

    public class Multiply : IOperation
    {
        public double calc(double field1, double field2)
        {
            return field1 * field2;
        }
    }

    public class Devide : IOperation
    {
        public double calc(double field1, double field2)
        {

            if (field2 == 0)
                throw new Exception("Error");
            return field1 / field2;
        }

    }
}
