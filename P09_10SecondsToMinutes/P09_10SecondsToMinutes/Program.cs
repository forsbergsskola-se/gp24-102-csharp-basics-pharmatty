     // Input
     { Console.Write("Enter a whole amount of numbers in seconds: ");}
        
        // Parse to an integer
        if (int.TryParse(Console.ReadLine(), out int totalSeconds))
        {
            // Conversion
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            
            // Result
            Console.WriteLine($"{minutes} minute(s) and {seconds} second(s)");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
        