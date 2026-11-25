using System;

sealed class EmployeePayroll
{
    double salary;
    double taxRate;

    public EmployeePayroll(double salary, double taxRate)
    {
        this.salary = salary;
        this.taxRate = taxRate;
    }

    public double CalculateSalary()
    {
        return salary;
    }

    public double CalculateTax()
    {
        return salary * taxRate / 100;
    }

    public double CalculateNetSalary()
    {
        return salary - CalculateTax();
    }
}

class Program
{
    static void Main()
    {
        EmployeePayroll employee =
            new EmployeePayroll(50000, 10);

        Console.WriteLine("Salary: " +
                          employee.CalculateSalary());

        Console.WriteLine("Tax: " +
                          employee.CalculateTax());

        Console.WriteLine("Net Salary: " +
                          employee.CalculateNetSalary());
    }
}
