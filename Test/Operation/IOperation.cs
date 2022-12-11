using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Operation
{
    public interface IOperation
    {
        decimal calc(decimal field1, decimal field2);
    }
}
