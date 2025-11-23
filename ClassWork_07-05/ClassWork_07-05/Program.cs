namespace Struct_07
{
    internal class Program
    {
        static void Main()
        {
            Mypoint z = new Mypoint();
            Console.WriteLine(z.A);
            Console.WriteLine(z.B);
            Console.WriteLine(z.X);
            //Console.WriteLine(z.b);




        }
    }
    public struct Mypoint 
    {
        public int A { get; set; }
        public int X;
        private int b;
        public int B 
        {
            get 
            {
                return b;
            }
            set 
            {
                b = value;
            }
        }
        public Mypoint() 
        {
            this.A = 1;
            this.B = 2;
            this.X = 3;
            this.b = 40;
        }
    }
}
