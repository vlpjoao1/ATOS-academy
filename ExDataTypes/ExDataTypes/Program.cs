using System;
using System.Collections.Generic;

namespace ExDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customer = new List<Customer>
            {
                new Customer { Name = "Joao", Register = DateTime.Now},
                new Customer { Name = "Juan", Register = DateTime.Now},
                new Customer { Name = "Luis", Register = DateTime.Now},
                new Customer { Name = "Ramon", Register = DateTime.Now},
                new Customer { Name = "Alfredo", Register = DateTime.Now},
                new Customer { Name = "Angel", Register = DateTime.Now},
                new Customer { Name = "María", Register = DateTime.Now},
                new Customer { Name = "Emmanuel", Register = DateTime.Now},
                new Customer { Name = "Veronica", Register = DateTime.Now},
                new Customer { Name = "Wilmer", Register = DateTime.Now}
            };
            foreach(Customer custom in customer)
            {
                Console.WriteLine(custom.Name+" se registró: "+custom.Register);
            }
            Console.WriteLine("---------------------------------------");
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine(customer[i].Name + " se registró: " + customer[i].Register);
            }
            Console.WriteLine("---------------------------------------");
            int count = 0;
            while (count <= 9)
            {
                Console.WriteLine(customer[count].Name + " se registró: " + customer[count].Register);
                count++;
            }
            Console.WriteLine("---------------------------------------");
            int count2 = 0;
            do
            {
                Console.WriteLine(customer[count2].Name + " se registró: " + customer[count2].Register);
                count2++;
            }while(count2 <= 9);

        }
    }
}
