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
                Console.WriteLine("Choose an option \n1. Retrieve top 2 Person Age Less Than 60" +
                                             "\n2. Retrieve Person Age Between 13 To 18" +
                                             "\n3. Average Age in the list" +
                                              "\n4. check specific name present in the list" +
                                              "\n5. Skip Person Age Less Than 60" +
                                              "\n6. Remove Specific Person From List");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        RetrievePersonAgeLessThan60(list);
                        break;
                    case 2:
                        RetrievePersonAgeBetween13To18(list);
                        break;
                    case 3:
                        GetAverageAgeInTheList(list);
                        break;
                    case 4:
                        CheckSpecificNamePresent(list, "Rahul");
                        break;
                    case 5:
                        SkipPersonAgeLessThan60(list);
                        break;
                    case 6:
                        RemoveSpecificPersonFromList(list, "Sachin");
                        break;
                    default:
                        Console.WriteLine("Please choose correct option");
                        break;
                }
                Console.ReadLine();

            }

        }
        public static void AddPersonDetailsToList(List<Person> list)
        {

            list.Add(new Person() { ssn = 1, name = "Sam", address = "Belgaum", age = 25 });
            list.Add(new Person() { ssn = 2, name = "John", address = "Belgaum", age = 18 });
            list.Add(new Person() { ssn = 3, name = "San", address = "Karnataka", age = 70 });
            list.Add(new Person() { ssn = 4, name = "Jonny", address = "Maharastra", age = 15 });
            list.Add(new Person() { ssn = 5, name = "Sachin", address = "Maharastra", age = 61 });
            list.Add(new Person() { ssn = 6, name = "Pandya", address = "Maharastra", age = 35 });
            list.Add(new Person() { ssn = 7, name = "Rahul", address = "Karnataka", age = 63 });

        }
        public static void IterateOverList(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine(person);
                Console.ReadLine();
            }
        }
        public static void RetrievePersonAgeLessThan60(List<Person> list)
        {
            List<Person> topTwoRecords = list.FindAll(p => p.age < 60).OrderBy(a => a.age).Take(2).ToList();
            Console.WriteLine("\nTop 2 persons with Age less than 60");
            IterateOverList(topTwoRecords);
            Console.ReadLine();
        }
        public static void RetrievePersonAgeBetween13To18(List<Person> list)
        {
            List<Person> teenage = list.FindAll(person => person.age >= 13 && person.age <= 18).ToList();
            Console.WriteLine("\nlist for Age between 13 to 18");
            IterateOverList(teenage);
            Console.ReadLine();
        }
        public static void GetAverageAgeInTheList(List<Person> list)
        {
            double averageAge = list.Average<Person>(person => person.age);
            Console.WriteLine("\nAverage age in the list is: " + averageAge);
        }
        public static void CheckSpecificNamePresent(List<Person> list, string name)
        {
            Person personPresent = list.Find(person => person.name == name);
            if (personPresent != null)
                Console.WriteLine("\n" + personPresent);
            else
                Console.WriteLine("Person not Exist in the list");
        }
        public static void SkipPersonAgeLessThan60(List<Person> list)
        {
            List<Person> PersonResult = list.FindAll(person => person.age > 60);
            Console.WriteLine("\npersons with Age greater than 60 are: ");
            IterateOverList(PersonResult);
        }
        public static void RemoveSpecificPersonFromList(List<Person> list, string name)
        {
            int removePerson = list.RemoveAll(person => person.name == name);
            Console.WriteLine("\nRemove Specific person from list");
            if (removePerson != 0)
                Console.WriteLine("\nRemoved Successfully");
            else
                Console.WriteLine("Failed to remove");
            Console.WriteLine("\nDisplaying updated list");
            IterateOverList(list);
        }
    }
}
