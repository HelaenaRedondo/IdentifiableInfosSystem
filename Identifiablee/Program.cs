using IdentifiableBusiness;
using identifiableDl;
using System;

namespace IdentifiableMain
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("HENLOOO WELCOME TO MY IDENTIFIABLE SYSTEM :))");
            Console.WriteLine("                              ");
            Console.WriteLine("                              ");
            Console.WriteLine("                              ");
            Console.WriteLine("                              ");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("                              ");
            Console.WriteLine("Go to my API you can now ADD,DELETE,UPDATE AND VIEW the identifiables");
            Console.WriteLine("                              ");
            Console.WriteLine("-----------------------------------------------------------------------");


            identifiableGetServices hpr = new identifiableGetServices();

            var infos = hpr.Getidentifiableuser();

            foreach (var item in infos)
            {
                Console.WriteLine($"firstname: {item.firstname}");
                Console.WriteLine($"middlename: {item.middlename}");
                Console.WriteLine($"lastname: {item.lastname}");
                Console.WriteLine($"email: {item.email}");
                Console.WriteLine($"contactnumber: {item.contactnumber}");
                Console.WriteLine($"address: {item.address}");
                Console.WriteLine($"password: {item.password}");


            }

        }
    }
}