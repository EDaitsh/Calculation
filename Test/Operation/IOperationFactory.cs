using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Operation
{
    public class IOperationFactory
    {
        public class IOperatinFactory
        {
            private IOperation addOperation = new Add();
            private IOperation subtractOperation = new Subtruct();
            private IOperation multiplyOperation = new Multiply();
            private IOperation devideOperation = new Devide();
            public IOperation GetOperation(OperationType operationType)
            {
                switch (operationType)
                {
                    case OperationType.Add:
                        return addOperation;
                    case OperationType.Subtruct:
                        return subtractOperation;
                    case OperationType.Multiply:
                        return multiplyOperation;
                    case OperationType.Devide:
                        return devideOperation;
                    default:
                        return null;
                }
            }
        }
    }
}
