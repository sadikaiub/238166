using System;

namespace Assingment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Your ID:");
            string id = Console.ReadLine();
            Console.Write("Enter Your Mobile NO:");
            string age = Console.ReadLine();
            Console.Write("Enter Your Age:");
            string birthDate = Console.ReadLine();
            Console.Write("Enter Your Date of Birth:");
            string mobileNo = Console.ReadLine();
            Console.Write("Enter Your Address:");
            string address = Console.ReadLine();
            Console.WriteLine("---------------------------------\n");
            Console.WriteLine("Your Information:");
            Console.WriteLine("Name : "+name+"\n" +"Id : "+id+"\n"+"Age: "+age+"\n"+"Date of Birth: "+birthDate+"\n" +
                              "Mobile No: "+mobileNo+"\n"+"Address: "+address);
            Console.ReadKey();
        }
    }
}
