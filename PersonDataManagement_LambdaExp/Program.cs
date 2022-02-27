using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement_LambdaExp
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to Person data management program");
                List<Person> list = new List<Person>();
                AddPersonDetailsToList(list);
                Console.ReadLine();

            }

        }
        public static void AddPersonDetailsToList(List<Person> list)
        {

            list.Add(new Person() { ssn = 1, name = "Sam", address = "Belgaum", age = 25 });
            list.Add(new Person() { ssn = 2, name = "John", address = "Belgaum", age = 26 });
            list.Add(new Person() { ssn = 3, name = "San", address = "Karnataka", age = 70 });
            list.Add(new Person() { ssn = 4, name = "Jonny", address = "Maharastra", age = 50 });
            list.Add(new Person() { ssn = 5, name = "Sachin", address = "Maharastra", age = 61 });
            list.Add(new Person() { ssn = 6, name = "Pandya", address = "Maharastra", age = 35 });
            list.Add(new Person() { ssn = 1, name = "Rahul", address = "Karnataka", age = 63 });

        }

        
    }
}
