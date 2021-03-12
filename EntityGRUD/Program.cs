using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dz_11_03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (MyprogramContext db = new MyprogramContext())
            {
                Customer custone = new Customer { Name = "Muhammad", Age = 17 };
                Customer custtwo = new Customer { Name = "Davlat", Age = 18 };

                db.Customers.Add(custone);
                db.Customers.Add(custtwo);
                db.SaveChanges();
            }

            using (MyprogramContext db = new MyprogramContext())
            {
                var customers = db.Customers.ToList();
                Console.WriteLine("Data after adding it:");
                foreach (Customer u in customers)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            using (MyprogramContext db = new MyprogramContext())
            {
                Customer customer = db.Customers.FirstOrDefault();
                if(customer!=null)
                {
                    customer.Name = "Ahmad";
                    customer.Age = 20;
                    db.SaveChanges();
                }
                Console.WriteLine("\nData after editing:");
                var customers = db.Customers.ToList();
                foreach (Customer u in customers)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }

            using (MyprogramContext db = new MyprogramContext())
            {
                Customer customer = db.Customers.FirstOrDefault();
                if (customer != null)
                {
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                }
                Console.WriteLine("\nData after deletion:");
                var customers = db.Customers.ToList();
                foreach (Customer u in customers)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            Console.Read();
        }
    }
}
