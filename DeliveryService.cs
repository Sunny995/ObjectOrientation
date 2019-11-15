using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class DeliveryService : IDeliveryService
    {
        public string Customer;
        public string getBuyers()
        {

            // we can return by querying database or performing some sequential logics
            Customer = "Rohan";
            return Customer;
        }
    }
}
