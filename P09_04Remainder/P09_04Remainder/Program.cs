{        //Type out integers
        Console.Write("Enter two integers, example 1,5):");
        
        
        string input = Console.ReadLine();
        string[] inputs = input.Split(',');

        if (inputs.Length == 2 && 
            int.TryParse(inputs[0].Trim(), out int dividend) && 
            int.TryParse(inputs[1].Trim(), out int divisor))
        {
            // Remainder value
            int remainder = CalculateRemainder(dividend, divisor);
            
           
            Console.WriteLine($"The remainder is: {remainder}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
}

static int CalculateRemainder(int dividend, int divisor)
    {
        // Zero check
        if (divisor == 0)
        {
            throw new DivideByZeroException("Divisor cannot be zero.");
        }
        return dividend % divisor;
    }
