using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //ListMethod();

            //ListMethod2();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book","Kitap");
            dictionary.Add("Table","Masa");
            Console.WriteLine(dictionary["Table"]);
        }

        private static void ListMethod2()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FrisName = "Suat", LastName = "Satilmis" });
            customers.Add(new Customer { Id = 2, FrisName = "Umut", LastName = "Cay" });
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FrisName + " " + customer.LastName);
            }
        }

        private static void ListMethod()
        {
            List<String> cities = new List<String>();
            cities.Add("Ankara");
            cities.Add("Sivas");
            cities.Add("İstanbul");
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Sivas");
            cities.Add("İstanbul");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }

        class Customer
        {
            public int Id { get; set; }
            public string FrisName { get; set; }
            public string LastName { get; set; }
        }
    }
}
