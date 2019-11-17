using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class Delivery 
    {
        IDeliveryService deliveryService;

       
        // #this
        public Delivery(): this (new DeliveryService())
        {

        }
        public Delivery(IDeliveryService deliveryService)
        {
            //use of "this" Keyword

            this.deliveryService = deliveryService;
            this.deliver();

        }

        public void deliver()
        {
            //use of #this
           Console.WriteLine("Delivered To"+ " "+this.deliveryService.getBuyers());
        }
    }
}
