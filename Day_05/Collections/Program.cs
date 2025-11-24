using System.Collections;

internal class Program
    {
        static void Main()
        {
        ArrayList objArrayList = new ArrayList();
        objArrayList.Add(10);
        objArrayList.Add("Vikram");
        objArrayList.Add(10.234);
        objArrayList.Add(true);
        objArrayList.Insert(1, "inserted");

        foreach (object item in objArrayList)
        {
            Console.WriteLine(item);
        }
        
    }
    }

