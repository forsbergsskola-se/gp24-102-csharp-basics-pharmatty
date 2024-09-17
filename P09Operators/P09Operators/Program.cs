Console.Write("Please enter a specific number of seconds: ");
string input = Console.ReadLine();
        
if (int.TryParse(input, out int totalSeconds))
{

    // Summary = 24 hours * 60 minutes * 60 seconds
    int secondsInDay = 86400; 
    // 60 minutes * 60 seconds
    int secondsInHour = 3600;  
    // 60 seconds
    int secondsInMinute = 60;  

    int days = totalSeconds / secondsInDay;
    int remainingSecondsAfterDays = totalSeconds % secondsInDay;

    int hours = remainingSecondsAfterDays / secondsInHour;
    int remainingSecondsAfterHours = remainingSecondsAfterDays % secondsInHour;

    int minutes = remainingSecondsAfterHours / secondsInMinute;
    int seconds = remainingSecondsAfterHours % secondsInMinute;

    //Print format
    Console.WriteLine($"Days: {days}");
    Console.WriteLine($"Hours: {hours}");
    Console.WriteLine($"Minutes: {minutes}");
    Console.WriteLine($"Seconds: {seconds}");

    // Printing format according to P09 instructions D.H:M:S
    Console.WriteLine($"Formatted Time: {days}.{hours:D2}:{minutes:D2}:{seconds:D2}");

    // Total Days (Fractioned)
    double totalDays = (double)totalSeconds / secondsInDay;
    Console.WriteLine($"Days: {totalDays:F2}");
}
else
{
    Console.WriteLine("Valid number of seconds not registered");
}