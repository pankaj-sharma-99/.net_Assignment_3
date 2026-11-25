using System;

static class ApplicationConfig
{
    public static string DatabaseName = "UniversityDB";

    public static string ConnectionString =
        "Server=localhost;Database=UniversityDB;";

    public static string ApplicationName = "Student Management";

    public static void DisplaySettings()
    {
        Console.WriteLine("Application: " + ApplicationName);
        Console.WriteLine("Database: " + DatabaseName);
        Console.WriteLine("Connection: " + ConnectionString);
    }
}

class Program
{
    static void Main()
    {
        ApplicationConfig.DisplaySettings();
    }
}
