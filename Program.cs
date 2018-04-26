using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace ConsoleUI
{
    class Program
    {
        private static List<Person> people = new List<Person>();
        static void Main(string[] args)
        {
           // SetUpSampleData();

            //GreetAllThePeople();

            StringDemoMethod();

            Console.ReadLine();
        }

        private static void SetUpSampleData()
        {
            people.Add(new Person() {FirstName = "Tim", LastName = "Corey"});
            people.Add(new Person() { FirstName ="Sue" , LastName = "Storm"});
            people.Add(new Person{ FirstName = "Jill", LastName = "Jones"});
        }
    
        private static void StringDemoMethod()
        {
            string s = "";
            StringBuilder sb = new StringBuilder();

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            for (int i = 0; i < 10000; i++)
            {  
                //s = s + "Hi";
                sb.Append("Hi ");
            }
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }

        private static void GreetAllThePeople()
        {
            foreach (var person in people)
            {
                if (person.FirstName == "Tim")
                {
                    Console.WriteLine($"Hello Mr. {person.LastName}");
                    Console.WriteLine("How are you doing?");
                }
                   
                Console.WriteLine($"Hello { person.FirstName } { person.LastName }");
            }
        }
    }
}
