using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Module11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = CreateListOfCustomers(@"C:\Project\AcceleratedLearning\C#\CsharpExercises\Module11_2\PersonShort.txt");
            SortedListByAge(customers);
            SortedListByFirstName(customers);
            MenOlderThan35(customers);
            List<Customer> customersManipulated = Manipulate(customers);
            MenOlderThan1035(customersManipulated);

        }

        private static void MenOlderThan1035(List<Customer> customersManipulated)
        {
            Header("Manipulated:");

            foreach (Customer customer in customersManipulated.Where(x => x.Age > 1035).OrderBy(x => x.FirstName))
            {
                WriteInfoAboutCustomer(customer);
            }
            Console.WriteLine();
        }

        private static List<Customer> Manipulate(List<Customer> customers)
        {
            return customers.Select(x => { x.Age += 1000; x.FirstName = x.FirstName.ToUpper(); return x; }).ToList();
            
        }ef

        private static void MenOlderThan35(List<Customer> customers)
        {
            Header("Men older than 35:");

            foreach (Customer customer in customers.Where(x => x.Age > 35).OrderBy(x => x.FirstName))
            {
                WriteInfoAboutCustomer(customer);
            }
            Console.WriteLine();
        }

        private static void SortedListByFirstName(List<Customer> customers)
        {
            Header("Sorted lis by first name:");

            foreach (Customer customer in customers.OrderBy(x => x.FirstName))
            {
                WriteInfoAboutCustomer(customer);
            }
            Console.WriteLine();
        }

        private static void SortedListByAge(List<Customer> customers)
        {
            Header("Sorted list by age:");

            foreach  (Customer customer in customers.OrderBy(x => x.Age))
            {                
                WriteInfoAboutCustomer(customer);
            }
            Console.WriteLine();
        }

        private static void Header(string v)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(v);
            Console.ForegroundColor = ConsoleColor.Gray;

        }

        private static void WriteInfoAboutCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + "\t\t" + customer.Age + "\t\t" + customer.Gender);
        }

        private static List<Customer> CreateListOfCustomers(string v)
        {
            string[] allLines = File.ReadAllLines(v);

            var allCustomers = new List<Customer>();

            foreach (string line in allLines)
            {
                string[] splittedLine = line.Split(',');

                var customer = new Customer
                {
                    FirstName = splittedLine[1],
                    LastName = splittedLine[2],
                    Email = splittedLine[3],
                    Gender = Enum.Parse<Gender>(splittedLine[4]),
                    Age = int.Parse(splittedLine[5])
                };

                allCustomers.Add(customer);
            }
            return allCustomers;
        }
    }
}
