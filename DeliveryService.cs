using System;
using System.Collections.Generic;
using System.Text;

namespace Principles
{
    public class DeliveryService : IDeliveryService
    {
        public  string Customer;
        

        public void ShowCharge(int amount)
        {
            amount= Tax(amount);
            Console.WriteLine(amount);
        }

        public int Tax(int amount)
        {
            if (amount > 100)
                amount += 50;
            return amount;
        }
        //public string[] customers = new string[2];
        //public string this[int index]
        //{
        //    get
        //    {
        //        return customers[index];
        //    }

        //    set
        //    {
        //        customers[index] = value;
        //    }
        //}

        public void GetProfiles()
        {
            //for (int i = 0; i < 2; i++)
               // Console.Write(customers[i] + " ");
        }
        public string getBuyers()
        {
            
            // we can return by querying database or performing some sequential logics
            Customer = "Rohan";
            return Customer;
        }
    }
}
