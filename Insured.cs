using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class Insured : IInsuranceState
    {
        public void getInsuranceState(InsuranceProvider provider)
        {
            Console.WriteLine("Vehicle is Insured");
        }
    }
}
