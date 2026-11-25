using System;

class University
{
    public class Department
    {
        public string DepartmentName;
        public string HODName;
        public int FacultyCount;

        public void DisplayDepartment()
        {
            Console.WriteLine("Department: " + DepartmentName);
            Console.WriteLine("HOD Name: " + HODName);
            Console.WriteLine("Faculty Members: " + FacultyCount);
        }
    }
}

class Program
{
    static void Main()
    {
        University.Department dept =
            new University.Department();

        dept.DepartmentName = "Computer Science";
        dept.HODName = "Dr. Sharma";
        dept.FacultyCount = 15;

        dept.DisplayDepartment();
    }
}
