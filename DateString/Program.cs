using System;

public class DateString
{
    public static void Main()
    {
        Console.WriteLine("Day: ");
        var dateDay = Console.ReadLine();
        var dateDayInt = Convert.ToInt32(dateDay);

        Console.WriteLine("Month: ");
        var dateMonth = Console.ReadLine();
        var dateMonthInt = Convert.ToInt32(dateMonth);

        Console.WriteLine("Year: ");
        var dateYear = Console.ReadLine();
        var dateYearInt = Convert.ToInt32(dateYear);

        DateTime userDate = new DateTime(dateYearInt, dateMonthInt, dateDayInt);

        var usersDate = userDate.ToString("MMMM dd, yyyy");

        DateTime date = DateTime.Now;
        DateTime newDate = date.AddDays(7);
        var fmtNewDate = newDate.ToString("MMMM dd, yyyy");

        Console.WriteLine("The date a week after is " + fmtNewDate);

        Console.WriteLine("The date that was passed is " + usersDate);



        if (date == newDate)
        {
            Console.WriteLine(usersDate);
        }

    }
}
