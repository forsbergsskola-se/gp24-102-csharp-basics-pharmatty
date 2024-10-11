        // input
        {Console.Write("Enter two whole numbers example: 4,6: ");
        
        
        string input = Console.ReadLine();
        string[] inputs = input.Split(',');

        if (inputs.Length == 2 && 
            int.TryParse(inputs[0].Trim(), out int firstNumber) && 
            int.TryParse(inputs[1].Trim(), out int secondNumber))
        {
            // Multiply
            int product = Multiply(firstNumber, secondNumber);
            
            // Result
            Console.WriteLine($"The product of {firstNumber} and {secondNumber} is: {product}");
        }
        else
        {
            Console.WriteLine("Invalid input. ");
        }
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
