//using System;
namespace BasicConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            System.Console.WriteLine("HW");
            Class1 obj;//obj is a reference of type Class 1
            obj = new Class1();//new Class1() is an object of Class1
            //obj refers to (points to) the object
            Class1 obj2 = new Class1();
            obj.Display();
            obj2.Display(" by obj2");
            Class1 obj3 = new Class1();
            Console.WriteLine(obj3.Add(a: 30, b: 40));

        }
    }
    public class Class1 
    {
        public void Display() 
        {
            Console.WriteLine("Display Called");
        }
        public void Display(string s)
        {
            Console.WriteLine("Display Called" + s);
        }
        public int Add(int a = 0, int b = 0, int c = 0) 
        {
            return a + b + c;   
        }
    }
}
namespace n2
{
    public class CLS1 { }
}