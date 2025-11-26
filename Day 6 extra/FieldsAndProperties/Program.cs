namespace FieldsAndProperties
{
    public class Class1
    {
        private int i;//field
        public int I//property
        {
            set
            {
                if (value <= 100)
                {
                    i = value;
                }
                else
                {
                    Console.WriteLine("Invalid value");
                }
            }
            get
            {
                return i;
            }

        }
    }
    internal class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.I = 100;
            Console.WriteLine(obj.I);


        }
    }
   

}
