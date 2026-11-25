using System;

record Student(
    int RollNumber,
    string Name,
    string Course,
    int Semester
);

class Program
{
    static void Main()
    {
        Student s1 = new Student(
            101, "Rahul", "BCA", 3);

        Student s2 = new Student(
            101, "Rahul", "BCA", 3);

        Console.WriteLine("Student 1: " + s1);
        Console.WriteLine("Student 2: " + s2);

        if (s1 == s2)
        {
            Console.WriteLine("Both students are equal.");
        }
        else
        {
            Console.WriteLine("Students are not equal.");
        }
    }
}
