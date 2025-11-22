namespace Abstract_Class
{
    internal class Program
    {
        static void Main()
        {
            Class1 c = new Class2();
            c.Display();
            c.Get();
            //Class1 c = new Class2();
            //c.Display();


        }
    }
    public abstract class Class1 
    {
        public abstract void Get();
        public virtual void Display() 
        {
            Console.WriteLine("abstract class public function ");
        }
    }
    public class Class2 : Class1
    {
        public override void Display() 
        {
            Console.WriteLine("Derived class");
        }
        public override void Get() 
        {
            Console.WriteLine("Abstarct methord");
        }
    }
}
