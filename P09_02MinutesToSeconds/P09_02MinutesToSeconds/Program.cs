
        Console.Write("Enter desired time in minutes: ");
        
        
        if (int.TryParse(Console.ReadLine(), out int minutes))
        {
            // Convert minutes to seconds
            int seconds = ConvertMinutesToSeconds(minutes);
            
            // Result
            Console.WriteLine($"Time in seconds: {seconds}");
        }
        else
        {
            Console.WriteLine("Please enter a number");
        }
        
    static int ConvertMinutesToSeconds(int minutes)
    {
        return minutes * 60;
    }
