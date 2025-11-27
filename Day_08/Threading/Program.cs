namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoResetEvent ar = new AutoResetEvent(false);
            AutoResetEvent ar2 = new AutoResetEvent(false);
            Thread t1 = new Thread(delegate ()
            {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine($"Function1 {i}");
                    if (i % 50 == 0)
                    {
                        Console.WriteLine("Waiting");
                        ar.WaitOne();
                    }
                }
            });
            
            Thread t2 = new Thread(delegate () {
                for (int i = 0; i < 200; i++)
                {
                    Console.WriteLine($"Function2 {i}");
                    if (i % 100 == 0)
                    {
                        Console.WriteLine("Waiting");
                        ar2.WaitOne();
                    }
                }
            });
            
            for (int i = 0; i < 200; i++) {
                Console.WriteLine($"Main {i}");
            }
            t1.Start();
            Console.ReadLine();
            ar.Set();
            Console.ReadLine();
            ar.Set();
            Console.ReadLine();
            ar.Set();
            Console.ReadLine();
            ar.Set();
            t2.Start();
            Console.ReadLine();
            ar2.Set();
            Console.ReadLine();
            ar2.Set();

        }
        
        static void function2()
        {
            AutoResetEvent ar = new AutoResetEvent(false);
            
        }
    }
}
