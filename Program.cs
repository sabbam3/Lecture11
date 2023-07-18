using System;
using Lecture11;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter 1-7: ");
        var myDay = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine(myDay.ToString());
        var myStatus = Status.Delivered;
        switch(myStatus)
        {
            case Status.Sent: Console.WriteLine(Status.Sent); break;    
            case Status.Deleted: Console.WriteLine(Status.Deleted); break;
            case Status.Delivered: Console.WriteLine(Status.Delivered); break;
        }
        Person person0 = new Person();
        Person person1 = new Person();
        Person person2 = new Person();
        Console.WriteLine($"Person count: {Person.Count}");
    }
}