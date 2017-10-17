using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest2
{
    public class Calculator
    { 
        public int Add(int summand1, int summand2) => summand1 + summand2;
        public int Substract(int subtrahend1, int subtrahend2) => subtrahend1 - subtrahend2;
        public int Divide(int divisor1, int divisor2)
        {
            if (divisor2 == 0) throw new DivideByZeroException($"{nameof(divisor2)} is 0");

            return divisor1 / divisor2;
        }

        public int AddAll(params int[] args)
        {
            int ReturnValue = 0;
            //foreach(int item in  args)
            //{
            //    ReturnValue += item;
            //}

            //ReturnValue = args.Select((x) => x).Sum();
            ReturnValue = args.Sum();
            return ReturnValue;
        }
    
        
    }
}
