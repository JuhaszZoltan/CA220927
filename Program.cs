DateTime dt1 = new(2000, 09, 11, 10, 45, 00);
Console.WriteLine(dt1);

DateTime dt2 = DateTime.Parse("22-11-12 13:00");
Console.WriteLine(dt2);

Console.WriteLine(dt2.ToLongDateString());
Console.WriteLine(dt2.ToShortDateString());
Console.WriteLine(dt2.ToLongTimeString());
Console.WriteLine(dt2.ToShortTimeString());

Console.WriteLine(dt2.ToString("yyy. MMM dd. ddd. tt hh:mm"));

DateTime dt3 = dt2.AddDays(100);
Console.WriteLine(dt3);

Console.ForegroundColor = ConsoleColor.Green;
for (DateTime i = new(1990, 07, 11); 
    i <= DateTime.Now; 
    i = i.AddDays(200))
{
    Console.Write(i.ToString("yyyy-MM-dd "));
}
Console.Write('\n');
Console.ResetColor();

//var ilyenNincs = dt1 + dt2;



Console.WriteLine(DateTime.IsLeapYear(1600));


DayOfWeek dow = dt2.DayOfWeek;
Console.WriteLine(dow);

Console.WriteLine(DateTime.Parse("1990-07-11").DayOfWeek);


//-------------------------


TimeSpan ts1 = dt2 - dt1;
Console.WriteLine(ts1);

TimeSpan ts2 = new TimeSpan(hours: 45, minutes: 20, seconds: 00);
Console.WriteLine(ts2);

DateTime dt4 = dt3 + ts2;
Console.WriteLine(dt4);

var ts3 = TimeSpan.FromHours(3.5);
Console.WriteLine(ts3);

Console.WriteLine(ts3.Minutes);
Console.WriteLine(ts3.TotalMinutes);

