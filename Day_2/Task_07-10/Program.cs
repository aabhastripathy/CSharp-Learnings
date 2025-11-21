using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Task_07_10;

namespace Task_07_10
{
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public abstract class Employee: IDbFunctions
    {
        public static int gen = 0;
        private string? name;
        public string? Name
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
        private int empno;
        public int Empno
        {

            get
            {
                return empno;
            }


        }


        private decimal basic;//could have been declared protectted so we dont have to write it again and again in inherited classes
        public abstract decimal Basic { get; set; }
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
        //public decimal GetNetSalary()
        //{
        //    return basic + 1000 - 150;
        //}
        public abstract decimal CalcNetSalary();
        public virtual void Insert()
        {
            Console.WriteLine("Employee implementing Idb Insert");
        }
        public virtual void Update()
        {
            Console.WriteLine("Employee implementing Idb Update");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Employee implementing Idb Delete");
        }
        public Employee(string name = "default", decimal basic = 12000, short deptno = 1 )
        {
            gen++;
            Name = name;
            Basic = basic;
            Deptno = deptno;
            empno = gen;

        }
    }

    public class Manager : Employee 
    {

        private string? designation;
        public string? Designation 
        {
            set 
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Invalid input");
                }
                else 
                {
                    designation = value;
                }
            }
            get { return designation; }
        }
        private decimal basic;
        public override decimal Basic 
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

        public override decimal CalcNetSalary() 
        {
            return Basic * 2;
        }
        public override void Insert() 
        {
            Console.WriteLine("Manager implementing Idb Insert");
        }
        public override void Update() 
        {
            Console.WriteLine("Manager implementing Idb Update");
        }
        public override void Delete() 
        {
            Console.WriteLine("Manager implementing Idb Delete");
        }
        public Manager(string designation = "Invalid", string name = "default ", decimal basic = 12000, short deptno = 1) : base( name, basic,  deptno) 
        {
            Designation = designation;
        }
    }
    public class GeneralManager : Manager,IDbFunctions
    {
        private string? perks;
        public string? Perks { get; set; }
        private decimal basic;
        public override decimal Basic
        {
            set
            {
                if (value <= 100000 && value > 2000000)
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
        public override decimal CalcNetSalary()
        {
            return Basic * 3;
        }
        public override void Insert()
        {
            Console.WriteLine("GeneralManager implementing Idb Insert");
        }
        public override void Update()
        {
            Console.WriteLine("GeneralManager implementing Idb Update");
        }
        public override void Delete()
        {
            Console.WriteLine("GeneralManager implementing Idb Delete");
        }
        public GeneralManager(string perks = "default ", string designation = "Invalid", string name = "default ", decimal basic = 12000, short deptno = 1) : base(  designation, name ,basic, deptno)
        {
            Perks = perks;
        }
    }
    public class CEO : Employee 
    {
        private decimal basic;
        public override decimal Basic
        {
            set
            {
                if (value <= 1000000 && value > 5000000)
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
        public override sealed decimal CalcNetSalary() 
        {
            return Basic * 10;
        }
        public override void Insert()
        {
            Console.WriteLine("CEO implementing Idb Insert");
        }
        public override void Update()
        {
            Console.WriteLine("CEO implementing Idb Update");
        }
        public override void Delete()
        {
            Console.WriteLine("CEO implementing Idb Delete");
        }
        CEO(string name = "default ", decimal basic = 12000, short deptno = 1) : base(name, basic, deptno)
        { }
    }



    internal class Program
    {
        static void Main()
        {
            Manager manager = new Manager("aabhas");
            
        }
    }
}








//Create the following classes
//Employee
//   Prop	
//	string Name -> no blanks
//	int EmpNo -> readonly, autogenerated
//	short DeptNo -> > 0

//    abstract decimal Basic          
//   Methods
//    abstract decimal CalcNetSalary()

//Manager: Employee
//   Prop

//    string Designation -> cant be blank
	
//GeneralManager : Manager
//   Prop
// 	string Perks -> no validations

//CEO : Employee
//      Make CalcNetSalary() a sealed method

//NOTE : Overloaded constructors in all classes calling their base class constructor
//All classes must implement IDbFunctions interface
//All classes to override the abstract members defined in the base class(Employee). Basic property to have different validation in different classes.
//CalcNetSalary() to have different code in different classes.















