namespace EmployeeAssign
{
    public delegate void InvalidEmpnoHandler();
    public delegate void InvalidNameHandler();
    public delegate void InvalidBasicHandler();
    public delegate void InvalidDeptnoHandler();

    public class Employee
    {
        public event InvalidEmpnoHandler InvalidEmpno;
        public event InvalidNameHandler InvalidName;
        public event InvalidBasicHandler InvalidBasic;
        public event InvalidDeptnoHandler InvalidDeptno;
        private int empNo;
        private string? name;
        private decimal basic;
        private short deptNo;
        public int EmpNo
        {
            get { return empNo; }
            set
            {
                if (value > 0)
                    empNo = value;
                else
                    InvalidEmpno();
            }
        }
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    InvalidDeptno();
            }
        }
        public decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 10000)
                    basic = value;
                else
                    InvalidBasic();
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "")
                    InvalidName();
                else
                    name = value;
            }
        }
        public decimal GetNetSalary()
        {
            //return Basic * (decimal)2.1;
            return Basic * 2.1M;
        }
    }
    internal class Program
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.InvalidEmpno += WrongEmpno;
            emp.InvalidDeptno += WrongDeptno;
            emp.InvalidName += WrongName;
            emp.InvalidBasic += WrongBasic;
            emp.EmpNo = 0;
            emp.DeptNo = 0;
            emp.Basic = 0;
            emp.Name = "";
        }
        static void WrongEmpno() 
        {
            Console.WriteLine("Invalid Empno");
        }
        static void WrongDeptno()
        {
            Console.WriteLine("Invalid Deptno");
        }
        static void WrongName()
        {
            Console.WriteLine("Invalid name");
        }
        static void WrongBasic()
        {
            Console.WriteLine("Invalid Basic");
        }
    }
}
