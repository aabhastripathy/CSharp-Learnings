namespace ExamPractice
{
    public class WrongName : ApplicationException 
    {
        public WrongName(string message):base(message) 
        {

        }
    }
    public class NeagtiveBasic : ApplicationException 
    {
        public NeagtiveBasic(string message) : base(message) { }
    }
    public class Employee 
    {
        public static int lastempno = 0;
        private string? name;
        public string? Name 
        {
            set {
                if (value == null || value == "")
                {
                    throw new WrongName("Empty name or null string input!!");
                }
                else
                    name = value;
            }
            get 
            {
                return name;
            }

        }
        private int empno;
        public int Empno 
        {
            get;
        }
        private decimal basic;
        public decimal Basic 
        {
            set 
            {
                if (value < 0)
                {
                    throw new NeagtiveBasic("Negative Basic input!!");
                }
                else 
                    basic = value;
            }
            get { return basic; }
        }
        public Employee(string name , decimal basic ) 
        {
            this.Name = name;
            this.Basic = basic;
            this.Empno = ++lastempno;

        }
        
        

    }
    internal class Program
    {
        static void Main()
        {
            try
            {
                Employee emp = new Employee("",- 45);
                Console.WriteLine(emp.Empno);
            }
            catch (WrongName ms)
            {
                Console.WriteLine(ms.Message);
            }
            catch(NeagtiveBasic ms) 
            {
                Console.WriteLine(ms.Message);
            }
        }
    }
}
//Task: Refactor the Employee class from the EmployeeExample4 namespace to simplify the EmpNo property while keeping it read-only externally and ensuring it is initialized sequentially in the constructor.
//Requirement 1 (Field/Property): The private static variable lastEmpNo must still be used to track the last assigned employee number.
//Requirement 2 (Property): The public EmpNo property must be an auto-implemented read-only property.
//Requirement 3 (Constructor): The constructor must be the only place where EmpNo is set.