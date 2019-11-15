using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class Showroom
    {
        IAssemble _vehicleType;

        public void Showcase(Car car)
        {
            Console.WriteLine("Car Showcased");
        }
        public void Showcase(Bike bike)
        {
            Console.WriteLine("Bike Showcased");
        }

         public IAssemble GetType(Type type)
        {
            switch (type) {

                case Type.H:
                    _vehicleType = new HatchBack();
                    break;

                case Type.S:
                    _vehicleType = new Sedan();
                    break;
            }
            return _vehicleType;
        }
    }
}
