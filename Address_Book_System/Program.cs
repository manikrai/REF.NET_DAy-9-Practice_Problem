// See https://aka.ms/new-console-template for more information
using System;
namespace Address_Book_System
{ 
    class Program
    {
        //public static List<UC1_Creation> People = new List<UC1_Creation>();
        
        public static void Main(string[] args)
        {
            UC1_to_UC4.Add_Person();
            UC1_to_UC4.ListPeople();
            UC1_to_UC4.RemovePerson();
           // UC1_to_UC4.EditPerson();

            Console.WriteLine("Welcome To Address Book Program");
            string Command = "";
            while (Command!="exit")
            {
                Console.Clear();
                Console.WriteLine("\nPlease Enter A Command:");
                Command = Console.ReadLine().ToLower();
                switch (Command)
                {
                    case "add":
                       UC1_to_UC4.Add_Person();
                        break;
                    case "remove":
                        UC1_to_UC4.RemovePerson();
                        break ;
                    case "list":
                        UC1_to_UC4.ListPeople();
                        break ;
                    case "edit":
                        UC1_to_UC4.EditPerson();
                        break;
                }
            }
            
        }
    }
    
    }