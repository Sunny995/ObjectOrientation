using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
   public class Manufacturer
    {
        public Car CarCreator(string name, int cost)
        {
            return new Car(name, cost);
        }
        public Bike BikeCreator()
        {
            return new Bike();
        }
    }
}
