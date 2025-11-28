namespace LinqExample
{
    internal class Program
    {
        public class Employee
        {
            public int EmpNo { get; set; }
            public string Name { get; set; }
            public decimal Basic { get; set; }
            public int DeptNo { get; set; }
            public string Gender { get; set; }
            public override string ToString()
            {
                string s = Name + "," + EmpNo.ToString() + "," + Basic.ToString() + "," + DeptNo.ToString();
                return s;
            }
        }
        public class Department
        {
            public int DeptNo { get; set; }
            public string DeptName { get; set; }
        }
        static List<Employee> lstEmp = new List<Employee>();
        static List<Department> lstDept = new List<Department>();
        public static void AddRecs()
        {
            lstDept.Add(new Department { DeptNo = 10, DeptName = "SALES" });
            lstDept.Add(new Department { DeptNo = 20, DeptName = "MKTG" });
            lstDept.Add(new Department { DeptNo = 30, DeptName = "IT" });
            lstDept.Add(new Department { DeptNo = 40, DeptName = "HR" });

            lstEmp.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 10000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 2, Name = "Vishal", Basic = 11000, DeptNo = 10, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 3, Name = "Abhijit", Basic = 12000, DeptNo = 20, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 4, Name = "Mona", Basic = 11000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 5, Name = "Shweta", Basic = 12000, DeptNo = 20, Gender = "F" });
            lstEmp.Add(new Employee { EmpNo = 6, Name = "Sanjay", Basic = 11000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 7, Name = "Arpan", Basic = 10000, DeptNo = 30, Gender = "M" });
            lstEmp.Add(new Employee { EmpNo = 8, Name = "Shraddha", Basic = 11000, DeptNo = 40, Gender = "F" });
        }

        static void Main()
        {
            AddRecs();
                                    //SELECT * FROM EMPLOYEE
            var emps = from emp in lstEmp select emp;//emp of type Employee,lstEmp of type List of Employee,emps is Ienumbrable of type Employee
            foreach (var item in emps) //item is of type Employee
            {
                Console.WriteLine(item);
            }


                                    //SELECT Empno FROM EMPLOYEE
            var emps2 = from Employee emp in lstEmp select emp.EmpNo;//emp.EmpNo of type int , lstEmp of type List of Employee , emps2 is Ienumbrable of type int
            foreach (var item in emps2) //item is of type int
            {
                Console.WriteLine(item);
            }



                                    //SELECT Empno,Name FROM EMPLOYEE
            var emps3 = from Employee emp in lstEmp select new { emp.EmpNo,emp.Name};//emp.EmpNo of type int,emp.EmpNo of type string , lstEmp of type List of Employee , emps3 is Ienumbrable of type anomyus type
            foreach (var item in emps3) //item is of type anonymus type
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }



                                    //SELECT WHERE FROM EMPLOYEE
            var emps4 = from Employee emp in lstEmp where emp.Basic>10000 select emp ;
            foreach (var item in emps4) 
            {
                Console.WriteLine(item);
                
            }

                                //SELECT * FROM EMPLOYEE ORDER BY Deptno,Name desceding
            var emps5 = from Employee emp in lstEmp orderby emp.DeptNo ,emp.Name descending select emp;
            foreach (var item in emps5)
            {
                Console.WriteLine(item);

            }


            var emps6 = from emp in lstEmp
                        join dept in lstDept
                        on emp.DeptNo equals dept.DeptNo
                        select new { emp.Name, dept.DeptName };
            foreach (var item in emps6)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.DeptName);

            }

        }
    }
}