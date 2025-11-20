namespace Class_5_10
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
        public int J { get; set; } //auto property
    }
    internal class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.I = 100;
            obj.J = 125;
            Console.WriteLine(obj.I);
            Console.WriteLine(obj.J);

            //after this we move to constructors
        }
    }

}
