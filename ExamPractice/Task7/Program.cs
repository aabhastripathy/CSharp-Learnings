namespace Task7
{
    internal class Program
    {
        public class InvalidP1ValueException : ApplicationException 
        {
            public InvalidP1ValueException(string message) : base(message) { }
        }
        public class Employee 
        {
            private int age;
            private string name;
            private int p1;

            public int Age { set; get; }
            public string Name { set; get; }
            public int P1 
            {
                set {
                    if (value <= 100)
                    {
                        p1 = value;
                    }
                    else {
                        throw new InvalidP1ValueException("invalid P1");
                    }
                }
                get { return p1; }
            }
        }
        static void Main()
        {
            try
            {
                Employee employee = new Employee();
                employee.P1 = 1001;
            }
            catch (InvalidP1ValueException msg) {
                Console.WriteLine(msg.Message);
            }
            
        }
    }
}
//Task: Modify the Class1.P1 property setter to throw a custom exception instead of printing a message.
//Requirement 1 (Custom Exception): Define a custom exception class named InvalidP1ValueException that inherits from ApplicationException and accepts a message in its constructor.
//Requirement 2 (Property Modification): In the P1 property's setter, if the value is greater than or equal to 100, throw an instance of your new custom exception.
//Requirement 3 (Handling): In a Main method, use a try...catch block to call the setter with an invalid value and catch the specific InvalidP1ValueException, printing its message.