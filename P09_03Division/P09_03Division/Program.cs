{
        Console.Write("Enter two whole numbers to divide. (ex. 1/2)");
        
        // Read input
        string input = Console.ReadLine();
        string[] inputs = input.Split('/');

        if (inputs.Length == 2 && 
            int.TryParse(inputs[0].Trim(), out int numerator) && 
            int.TryParse(inputs[1].Trim(), out int denominator))
        {
            // Excecute division
            float result = Divide(numerator, denominator);
            
            
            Console.WriteLine($"Your division result: {result:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
    
    static float Divide(int numerator, int denominator)
    {
        //Zero check
        if (denominator == 0)
        {
            throw new DivideByZeroException("Denominator cannot be of the value zero.");
        }
        return (float)numerator / denominator;
    }
