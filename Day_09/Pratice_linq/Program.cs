using System.Runtime.InteropServices;

namespace Pratice_linq
{
   
        internal class Program
        {
        public class Student
        {
            public int StdNo { get; set; }
            public string Name { get; set; }
            public decimal Marks { get; set; }
            public int DeptNo { get; set; }
            public string Gender { get; set; }

            public override string ToString()
            {
                string s = Name + "," + StdNo.ToString() + "," + Marks.ToString() + "," + DeptNo.ToString();
                return s;
            }
        }
        public class Department
        {
            public int DeptNo { get; set; }
            public string DeptName { get; set; }
        }
        static List<Student> stdlst = new List<Student>();
        static List<Department> dptlst = new List<Department>();
        public static void AddData() 
        {
            Program pro = new Program();
            
                                //Adding Department Data
            dptlst.Add(new Department { DeptNo = 1, DeptName = "Computer Science" });
            dptlst.Add(new Department { DeptNo = 2, DeptName = "Electronics" });
            dptlst.Add(new Department { DeptNo = 3, DeptName = "Mechanical" });
            dptlst.Add(new Department { DeptNo = 4, DeptName = "Civil" });

                            // Adding Student Data
            stdlst.Add(new Student { StdNo = 1, Name = "Aarav", Marks = 89.5m, DeptNo = 1, Gender = "Male" });
            stdlst.Add(new Student { StdNo = 2, Name = "Diya", Marks = 92.3m, DeptNo = 1, Gender = "Female" });
            stdlst.Add(new Student { StdNo = 3, Name = "Karan", Marks = 75.8m, DeptNo = 2, Gender = "Male" });
            stdlst.Add(new Student { StdNo = 4, Name = "Isha", Marks = 68.2m, DeptNo = 3, Gender = "Female" });
            stdlst.Add(new Student { StdNo = 5, Name = "Rohan", Marks = 81.0m, DeptNo = 4, Gender = "Male" });
            stdlst.Add(new Student { StdNo = 6, Name = "Sneha", Marks = 95.4m, DeptNo = 2, Gender = "Female" });
        }
        

        static void Main(string[] args)
        {
            AddData();

            //var selectAll = from std in stdlst where std.Gender == "Male" select std;
            //foreach (var item in selectAll)
            //{
            //    Console.WriteLine(item);
            //}


            //var orderby = from std in stdlst orderby /*std.Marks,*/ std.Name descending where std.Gender == "Male" select std;
            //foreach (var item in orderby)
            //{
            //    Console.WriteLine(item);
            //}


            var join = from std in stdlst join dpt in dptlst on std.DeptNo equals dpt.DeptNo select new { std.Marks, dpt.DeptName };
            foreach(var item in join)
            {
                Console.WriteLine(item.Marks);
                Console.WriteLine(item.DeptName);
                
            }
        }
    }
}
