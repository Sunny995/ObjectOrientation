using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class InsuranceProvider
    {
        private IInsuranceState _state;

        public InsuranceProvider()
        {
            _state = new Insured();
        }
        public void SetInsurance(IInsuranceState state)
        {
            _state = state;

        }

        public void getInsurance()
        {
            _state.getInsuranceState(this);
        }
    }
}
