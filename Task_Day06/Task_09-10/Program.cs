namespace EmployeeAssign
{
    public class MyException : ApplicationException
    {
        public MyException(string message):base(message)
        {

        }
    }
    public class MyExceptionNumber : ArithmeticException
    {
        public MyExceptionNumber(string message) : base(message)
        {

        }
    }
    public class Employee
    {
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
                    throw new MyException("Invalid Empno.");
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
                    throw new MyException("Invalid DeptNo");
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
                    //throw new MyException("Invalid Basic.");
                    // throw new DivideByZeroException();
                    throw new MyExceptionNumber("Invalid Basic.");
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value != null )
                    //
                    name = value;

                else
                    // throw new MyException("Invalid Name.");
                    throw new NullReferenceException("Invalid name");
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
            try
            {
                Employee emp = new Employee();
                //emp.Basic = 100;
                //emp.EmpNo = 0;
                //emp.Name = null;
                //int x = 0;
                emp.Basic = 10000 ;
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex )
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Final Block");
            }
        }
    }
    
}
