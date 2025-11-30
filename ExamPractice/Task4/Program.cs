using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Task4
{
    internal class Program
    {
       // delegate void DellDisplay();
        delegate int DellAdd(int a, int b);
        delegate int DellMulti(int a, int b);
        //delegate int arrow(int a, int b);
        static void Main()

        {
            //display();
            //DellDisplay obj = display;
           // obj();
            //Func<int, int, int> = (x, y) => x + y;
            DellAdd addition = add;
            Console.WriteLine(addition(5, 3));

        //---------------------OR------------------------------------
            Action<int,int> a1 = display;
            Func<int, int, int> f1 = add;
            Console.WriteLine(f1(5,3));

//-----------------------MULTICAST---------------------------
        DellMulti multicast = add;
         multicast += sub;
         multicast += prod;
        // multicast += div;
        Console.WriteLine(multicast(10,15));
        }
        public static int add(int a, int b) { return a + b; }
        public static int sub(int a, int b) { return a - b; }
        public static int prod(int a, int b) { return a * b; }
        public static int div(int a, int b) { return a / b; }
        public static void display(int a, int b) {
            void Show() {
                Console.WriteLine("Aabhas");
            } 
            Console.WriteLine("Sandeep");
        }
    }
}
//Task: Use a custom delegate to chain multiple arithmetic operations and analyze the return value.
//Requirement 1 (Delegate): Define a delegate DelCalculate that accepts two integers and returns an integer (similar to DelAdd or Func<int, int, int>).
//Requirement 2 (Methods): Create three static methods: Add(a, b) returns a + b, Subtract(a, b) returns a - b, and Multiply(a, b) returns a * b .
//Requirement 3 (Chaining/Analysis): Create a multicast delegate, chaining Add, then Subtract, then Multiply. Call the delegate with values(10,5) and print the result. Explain which method's return value is ultimately returned .

