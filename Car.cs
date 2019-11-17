using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class Car
    {
        public readonly string name;

        public double price;
        public readonly int deliveryCharge;

        public Car(string name, int deliveryCharge)
        {
            if (name == null)
                throw new ArgumentNullException();
            if (deliveryCharge == 0)
                throw new ArgumentNullException();
            this.name = name;
            this.deliveryCharge = deliveryCharge;
        }
    }
}
