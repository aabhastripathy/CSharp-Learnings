using System.Collections.Generic;

namespace Task3
{
    public class StackFull : ApplicationException 
    {
        public StackFull(string message):base(message) { }
    }
    public class StackEmpty : ApplicationException
    {
        public StackEmpty(string message) : base(message) { }
    }
    public class Mystack<T> where T : class {

        //Stack<T> st = new Stack<T>();

        private T[] arr;
        private int position = -1;
        public Mystack(int size)
        {
            arr = new T[size];
        }
        public void Push(T item )
        {
            if (position == arr.Length - 1)
            {
                throw new StackFull("No more space left!!");
            }
            else 
            {
                position++;
                arr[position] = item;
            }
        }
        public T Pop() 
        {
            if (position == -1)
                throw new StackEmpty("Empty Stack!!");
            else 
            {

                T temp = arr[position];
                arr[position] = default(T)!;
                position--;
                return temp;
            }
        }

    }
    public class Employee 
    {
        private string? name;
        private int age;
        public string? Name { set; get; }
        public int Age { set; get; }
    }
    internal class Program
    {
        static void Main()
        {
            try
            {
                Employee emp = new Employee();
                emp.Name = "Test";
                emp.Age = 10;
                // Mystack<int> ab = new Mystack<int>();
                Mystack<Employee> empstack = new Mystack<Employee>(5);
                empstack.Push(emp);
                Console.WriteLine( empstack.Pop());
            }
            catch (StackFull full) {
                Console.WriteLine(full.Message);
            }
            catch (StackEmpty empty)
            {
                Console.WriteLine(empty.Message);
            }
        }
    }
}
//Task: Modify the MyStack<T> generic class to ensure that it can only store reference types.
//Requirement 1 (Constraint): Add a constraint to the generic type parameter T so that it can only be a reference type (a class).
//Requirement 2 (Instantiation Test): Demonstrate that attempting to create a stack of an int (a value type) fails, but creating a stack of string (a reference type) succeeds.