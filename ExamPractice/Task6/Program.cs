using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace Task6
{
    internal class Program
    {
        static void Main()
        {
            
            string[] names = { "Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Zeta" };
            Console.WriteLine(names[^1]);
            string[] temp = names[1..^1];
            Console.WriteLine(string.Join(",",temp));

          

        }
        
    }
}
//Task: Demonstrate the use of indices and ranges to extract specific parts of a string array.
//Requirement 1 (Array): Use the sample array: string[] names = { "Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Zeta" };.
//Requirement 2 (Index): Print the last element using the index from end operator (^).
//Requirement 3 (Range): Extract and print a new array containing the elements from the second element up to (but not including) the second-to-last element using the Range operator (..).

