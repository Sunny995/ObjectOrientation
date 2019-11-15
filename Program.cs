using System;

namespace Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Moving functionalities to differnt class or function

            Manufacturer manufacturer = new Manufacturer();

            //dynamic dispatch

            new Showroom().Showcase(manufacturer.BikeCreator());
            new Showroom().Showcase(manufacturer.CarCreator());
           Bike b =  manufacturer.BikeCreator();
            b.Name = "harsh";
            new Seller().FruitsAvailable(b.Name);

            //Maintaining States with respect to objects of classes.

            InsuranceProvider i = new InsuranceProvider();
            i.getInsurance();
            i.SetInsurance(new NotInsured());         
            i.getInsurance();

            // Separation of concerns
            Delivery deliver = new Delivery(new DeliveryService());
            deliver.deliver();

            //Working with strategy types & objects
            IAssemble vehicle = new Showroom().GetType(Type.S);
            vehicle.Assemble();
        }
    }
}
