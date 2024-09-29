
        // Input
        Console.Write("Enter an whole number:");
        
        // Parse it to an integer
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // Negate the number using the unary minus operator
            int negatedNumber = -number;
            
            
            Console.WriteLine($"The negation of {number} is: {negatedNumber}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
