using System;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Task5
{
    public class Employee 
    {
        private string name;
        private int age;
        private decimal basic;
        public string Name { set; get; }
        public int Age { set; get; }
        public decimal Basic { set; get; }

        public override string ToString()
        {
            string s = Name + "," + Age + "," + Basic;
            return s;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] arr = { new Employee { Name = "Aabhas", Age = 24, Basic = 500000 }, new Employee { Name = "Sandeep", Age = 24, Basic = 500000 }, new Employee { Name = "karan", Age = 24, Basic = 500000 } };
            foreach (var item in arr) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================================================================");
            Array.Sort(arr, (a, b) => string.Compare(b.Name, a.Name));
            foreach (var item in arr)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
//Task: Use the Array.Sort method with a lambda expression to sort an array of custom objects by a specific property.
//Requirement 1 (Data): Use the provided Emp class (or similar simple class with EmpNo and Name).
//Requirement 2 (Sorting): Create an array of three Emp objects. Use Array.Sort with a lambda expression (acting as the comparison logic, similar to an IComparer) to sort the array by Name descending (Z to A).
//Requirement 3 (Output): Print the names of the employees after sorting.