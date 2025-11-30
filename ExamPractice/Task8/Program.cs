using System.Runtime.Intrinsics.X86;

namespace Task8
{
    public class InvalidP1ValueException : ApplicationException
    {
        public InvalidP1ValueException(string message) : base(message) { }
    }
    internal class Program
    {
        public class Employee 
        {
            private int age;
            private string name;
            private decimal basic;

            public int Age { set; get; }
            public string Name { set; get; }
            public decimal Basic
            {
                set
                {
                    if (value <= 100)
                    {
                        basic = value;
                    }
                    else
                    {
                        throw new InvalidP1ValueException("invalid P1");
                    }
                }
                get { return basic; }
            }
            public void add() 
            {

            }
        }
        static void Main()
        {
            List<Employee> emplst = new List<Employee>();
            emplst.Add(new Employee { Age = 15, Name = "Aabhas", Basic = 15 });
            emplst.Add(new Employee { Age = 18, Name = "Aman", Basic = 12 });
            emplst.Add(new Employee { Age = 75, Name = "Abdul", Basic = 50 });
            emplst.Add(new Employee { Age = 5, Name = "Aman", Basic = 36 });
            emplst.Add(new Employee { Age = 95, Name = "Akarsh", Basic = 13 });
            emplst.Add(new Employee { Age = 15, Name = "Babu", Basic = 18 });
            var query1 = from emp in emplst select emp;
            foreach (var item in query1)
            {
                Console.WriteLine(item.Name);
            }
            var query2 = from emp in emplst where emp.Basic > 15 select emp;
            foreach (var item in query2)
            {
                Console.WriteLine(item.Basic);
            }
            var query3 = from emp in emplst select new { emp.Name, emp.Basic };
            foreach (var item in query3) {
                Console.WriteLine(item.Name);
            }
        }
    }
}
//Task: Use the LINQ Method Syntax (using lambda expressions) to perform a query that requires filtering, sorting, and projection on the provided employee list.
//Requirement 1 (Filter): Filter the lstEmp to include only employees with a Basic salary greater than 11000.
//Requirement 2 (Sort): Sort the results by Name in descending order.
//Requirement 3 (Project): Project the result into an anonymous type containing only the Name and Basic properties.
//Requirement 4 (Output): Iterate over the final result and print the names and basics.