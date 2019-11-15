using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class Delivery 
    {
        IDeliveryService _deliveryService;

        public Delivery(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }

        public void deliver()
        {
           Console.WriteLine("Delivered To"+ " "+_deliveryService.getBuyers());
        }
    }
}
