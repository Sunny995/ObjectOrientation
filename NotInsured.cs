using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class NotInsured : IInsuranceState
    {
        public void getInsuranceState(InsuranceProvider provider)
        {
            Console.WriteLine("Vehicle is Not Insured");
        }
    }
}
