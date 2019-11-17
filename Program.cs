using System;

namespace Principles
{
    class Program
    {
        static void Main(string[] args)
        {

            // Some Uses Of This Keyword
            //1.to refer current members of class (Delivery class LIne 15)
            //2.to call another constructor of same class (Delivery class LIne 11)
            //3. calling function
            //4. Passing Object as a reference (Insurance Provider Line 23)
            //DeliveryService d = new DeliveryService();
            //d.customers[0] = "Virat";
            //d.customers[1] = "Kohli";
            //d.customers[2]= "Rahul";
            //d.G

            //Moving functionalities to differnt class or function

            Manufacturer manufacturer = new Manufacturer();

            //dynamic dispatch

            new Showroom().Showcase(manufacturer.BikeCreator());
            new Showroom().Showcase(manufacturer.CarCreator("Honda",0));
           Car b =  manufacturer.CarCreator("Hyundai", 5000);
            // b.Name = "Maruti";                                     Not changing members values 
            //                                                        to avoid logical errors in complexity & NUll references anytime.
            new Seller().GetName(b.name);

            //Maintaining States with respect to objects of classes.

            InsuranceProvider i = new InsuranceProvider();
            i.getInsurance();
            i.SetInsurance(new NotInsured());         
            i.getInsurance();

            //Using Immutable objects when possible to avoid errors
            DeliveryService d = new DeliveryService();
            d.ShowCharge(b.deliveryCharge);


            // Separation of concerns (Delivery class)
            
            Delivery deliver = new Delivery();
            

            //Working with strategy types & objects
            IAssemble vehicle = new Showroom().GetType(Type.S);
            vehicle.Assemble();
        }
    }
}
