Console.Write("Please enter a specific number of seconds:");
string input = Console.ReadLine();
        
if (int.TryParse(input, out int totalSeconds))
{
    
    int secondsInDay = 86400; 
  
    int secondsInHour = 3600;  
   
    int secondsInMinute = 60;  

    int days = totalSeconds / secondsInDay;
    int remainingSecondsAfterDays = totalSeconds % secondsInDay;

    int hours = remainingSecondsAfterDays / secondsInHour;
    int remainingSecondsAfterHours = remainingSecondsAfterDays % secondsInHour;

    int minutes = remainingSecondsAfterHours / secondsInMinute;
    int seconds = remainingSecondsAfterHours % secondsInMinute;

    //Writeline according to P09 instructions
    Console.WriteLine($"Days: {days}");
    Console.WriteLine($"Hours: {hours}");
    Console.WriteLine($"Minutes: {minutes}");
    Console.WriteLine($"Seconds: {seconds}");
    
    // Total Days (Fractioned)
    double totalDays = (double)totalSeconds / secondsInDay;
    Console.WriteLine($"Days: {totalDays:F2}");
}
else
{
    Console.WriteLine("No valid number was applied");
}
