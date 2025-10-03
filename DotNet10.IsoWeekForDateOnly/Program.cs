using System.Globalization;


var dateTime = new DateTime(2025, 5, 25);
var weekForDateTime = ISOWeek.GetWeekOfYear(dateTime);
Console.WriteLine($"{dateTime} is in ISO week {weekForDateTime}.");

var dateOnly = new DateOnly(2025, 5, 25);
var weekForDateOnly = ISOWeek.GetWeekOfYear(dateOnly);
Console.WriteLine($"{dateOnly} is in ISO week {weekForDateOnly}.");