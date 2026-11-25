using System;

class StudentUtility
{
    public static double CalculatePercentage(
        double obtainedMarks, double totalMarks)
    {
        return (obtainedMarks / totalMarks) * 100;
    }

    public static string CalculateGrade(double percentage)
    {
        if (percentage >= 90)
            return "A";
        else if (percentage >= 75)
            return "B";
        else if (percentage >= 60)
            return "C";
        else
            return "Fail";
    }

    public static double AttendancePercentage(
        int present, int total)
    {
        return ((double)present / total) * 100;
    }
}

class Program
{
    static void Main()
    {
        double percentage =
            StudentUtility.CalculatePercentage(450, 500);

        string grade =
            StudentUtility.CalculateGrade(percentage);

        double attendance =
            StudentUtility.AttendancePercentage(85, 100);

        Console.WriteLine("Percentage: " + percentage);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Attendance: " + attendance + "%");
    }
}
