using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_System
{
    public class UC1_to_UC4
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string PhoneNumber { get; set; }
        public string ZipCode { get; set; }
        public string email { get; set; }

        public static List<UC1_to_UC4> People = new List<UC1_to_UC4>();
        public static void Add_Person()
        {
            UC1_to_UC4 person=new UC1_to_UC4();

            Console.WriteLine("Enter First Name: ");
            person.FirstName=Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            person.LastName=Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            person.PhoneNumber=Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            person.Address=Console.ReadLine();

            Console.WriteLine("Enter City: ");
            person.City=Console.ReadLine();

            Console.WriteLine("Enter Zip code: ");
            person.ZipCode=Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            person.email=Console.ReadLine();


            People.Add(person);
        }
        public static void PrintPerson(UC1_to_UC4 persion)
        {
            Console.WriteLine("First Name:"+persion.FirstName);
            Console.WriteLine();
            Console.WriteLine("Last Name:"+persion.LastName);
            Console.WriteLine();
            Console.WriteLine("Phone Number:"+persion.PhoneNumber);
            Console.WriteLine();
            Console.WriteLine("Address:"+persion.Address);
            Console.WriteLine();
            Console.WriteLine("City :"+persion.City);
            Console.WriteLine();
            Console.WriteLine("Zip Code:"+persion.ZipCode);
            Console.WriteLine();
            Console.WriteLine("Email:"+persion.email);


        }
        public static void ListPeople()
        {
            if(People.Count==0)
            {
                Console.WriteLine("\nYour Address Book Is Empty.Press Any Key To Continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("\nHere are The Current People In Your Address Book:\n");
            foreach(var person in People)
            {
                PrintPerson(person);
            }
            Console.WriteLine("\nPress Any Key To Continue");
            Console.ReadKey();
        }
        public static void RemovePerson()
        {
            Console.WriteLine("\nEnter The First Name Of Person You Want To Remove");
            string FirstName=Console.ReadLine();
            UC1_to_UC4 person=People.FirstOrDefault(x => x.FirstName.ToLower()==FirstName.ToLower());
            if(person==null)
            {
                Console.WriteLine("That Person Not Found");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you Sure You Want To Remove This Person");
            PrintPerson(person);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(person);
                Console.WriteLine("Person Removed");
                Console.ReadKey();
            }
        }
        public static void EditPerson()
        {
            Console.WriteLine("\nEnter The First Name Of Person You Want To Edit:");
            string FirstName = Console.ReadLine();
            UC1_to_UC4 person = People.FirstOrDefault(x => x.FirstName.ToLower() == FirstName.ToLower());
            if (person == null)
            {
                Console.WriteLine("That Person Not Found");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Are you Sure You Want To Edit This Person");
            PrintPerson(person);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Insert(person);
                Console.WriteLine("Detail Edited");
                Console.ReadKey();
            }
        }

    }
}
