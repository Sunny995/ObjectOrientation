using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
   public class Manufacturer
    {
        public Car CarCreator()
        {
            return new Car();
        }
        public Bike BikeCreator()
        {
            return new Bike();
        }
    }
}
