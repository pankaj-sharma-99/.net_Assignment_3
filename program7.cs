using System;

class Repository<T>
{
    private T item;

    public void Store(T value)
    {
        item = value;
    }

    public T Retrieve()
    {
        return item;
    }
}

class Student
{
    public string Name { get; set; }
    public int RollNo { get; set; }
}

class Employee
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }
}

class Program
{
    static void Main()
    {
        Repository<Student> studentRepo =
            new Repository<Student>();

        Student student = new Student
        {
            Name = "Rahul",
            RollNo = 101
        };

        studentRepo.Store(student);

        Student result1 = studentRepo.Retrieve();

        Console.WriteLine("Student Name: " + result1.Name);
        Console.WriteLine("Roll Number: " + result1.RollNo);

        Repository<Employee> employeeRepo =
            new Repository<Employee>();

        Employee employee = new Employee
        {
            Name = "Amit",
            EmployeeId = 201
        };

        employeeRepo.Store(employee);

        Employee result2 = employeeRepo.Retrieve();

        Console.WriteLine("Employee Name: " + result2.Name);
        Console.WriteLine("Employee ID: " + result2.EmployeeId);
    }
}
