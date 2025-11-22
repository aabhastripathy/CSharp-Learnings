namespace Day_3
{
    internal class Program
    {
        static void Main() 
        {
            //Implementation of 1st interface and  2nd interface 
            Class1 obj = new Class1();
            ((Iinterfaces2)obj).FirstMethod();
            obj.SecondMethod();
            obj.ThirdMethod();
            obj.FourthMethod();
            

        }
    }
}

public interface Iinterfaces1 
{
    void FirstMethod();
    void SecondMethod();
    void ThirdMethod();

}


public interface Iinterfaces2
{
    void FirstMethod();
    void FifthMethod();
    void SixthMethod();

}
public class Class1 : Iinterfaces1, Iinterfaces2
{
    public void FifthMethod()
    {
        Console.WriteLine("5Th method made in interface-2");
    }

    void Iinterfaces1.FirstMethod()
    {
        Console.WriteLine("1St method made in interface-1");
    }

    public void FourthMethod() {
        Console.WriteLine("4Th method made in class");
    }

    public void SecondMethod()
    {
        Console.WriteLine("2Nd method made in interface-1");
    }

    public void SixthMethod()
    {
        Console.WriteLine("6Th method made in interface-2");
    }

    public void ThirdMethod()
    {
        Console.WriteLine("3Rd method made in interface-1");
    }

    void Iinterfaces2.FirstMethod()
    {
        Console.WriteLine("1St method made in interface-2");
    }

   
}