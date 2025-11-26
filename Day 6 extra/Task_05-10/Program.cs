namespace Task_05_10
{
    
    public class Employee
    {
        public static int gen = 0;
        private string name;
        public string Name
        {
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    name = value;
                }
            }
            get
            {
                return name;
            }
        }
        private  int empno  ;
        public  int Empno
        {

            get 
            {
                return empno;
            }         
             
            
        }
        

        private decimal basic;
        public decimal Basic
        {
            set
            {
                if (value <= 10000 && value > 1000000)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    basic = value;
                }
            }
            get
            {
                return basic;
            }
        }
        private short deptno;
        public short Deptno
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    deptno = value;
                }
            }
            get
            {
                return deptno;
            }
        }
        public decimal GetNetSalary()
        {
            return basic + 1000 - 150;
        } 
        public Employee(string name=" ",  decimal basic=12000, short deptno=1)
        {
            gen++;
            Name = name;
            Basic = basic;
            Deptno = deptno;
            empno = gen;
            
        }
    }



    internal class Program
    {
        static void Main()
        {
            Employee obj1 = new Employee("Aabhas", 20000, 2);
            Employee obj2 = new Employee("Aabhas", 20000, 2);
            Employee obj3 = new Employee("Aabhas", 20000, 2);
            //obj.Name = "Aabhas";
            //obj.Basic = 20000;
            //obj.Deptno = 2;
            //Console.WriteLine(obj.Name);
            //Console.WriteLine(obj.Basic);
            //Console.WriteLine(obj.Deptno);
            //Console.WriteLine(obj.GetNetSalary());
            Console.WriteLine(obj1.Empno);
            Console.WriteLine(obj2.Empno);
            Console.WriteLine(obj3.Empno);
            Console.WriteLine();
            Console.WriteLine(obj3.Empno);
            Console.WriteLine(obj2.Empno);
            Console.WriteLine(obj1.Empno);
        }
    }
}
