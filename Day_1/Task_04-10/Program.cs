namespace Task_04_10
{

    public class Employee 
    {
        private string name;
        public string Name 
        {
            set {
                if (value == "")
                {
                    Console.WriteLine("Invalid Input");
                }
                else {
                    name = value;
                }
            }
            get 
            {
                return name;
            }
        }
        private int empno;
        public int Empno 
        {
            set {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Input");
                }
                else {
                    empno = value;
                }
            }
            get 
            {
                return empno;
            }
        }
        private decimal basic;
        public decimal Basic 
        {
            set {
                if (value <= 10000 && value > 1000000) {
                    Console.WriteLine("Invalid Input");
                }
                else {
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
            set {
                if (value <= 0) {
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
        
    }
    
    
    
    internal class Program
    {
        static void Main()
        {
            Employee obj = new Employee();
            obj.Name = "Aabhas";
            obj.Empno = 1;
            obj.Basic = 20000;
            obj.Deptno = 2;
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Empno);
            Console.WriteLine(obj.Basic);
            Console.WriteLine(obj.Deptno);
            Console.WriteLine(obj.GetNetSalary());
        }
    }
}
