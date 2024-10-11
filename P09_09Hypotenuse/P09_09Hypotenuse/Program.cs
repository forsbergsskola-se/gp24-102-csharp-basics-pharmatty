        // input - Use the Pythagorean theorem: c = √(a² + b²)
        {Console.Write("Enter the lengths of the two sides of the right triangle (example 5,6):");
        
        
        string input = Console.ReadLine();
        string[] inputs = input.Split(',');

        if (inputs.Length == 2 && 
            double.TryParse(inputs[0].Trim(), out double sideA) && 
            double.TryParse(inputs[1].Trim(), out double sideB))
        {
            // Hypotenuse
            double hypotenuse = CalculateHypotenuse(sideA, sideB);
            
            // Result
            Console.WriteLine($"The length of the hypotenuse is: {hypotenuse}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static double CalculateHypotenuse(double a, double b)
    {
        
        return Math.Sqrt(a * a + b * b);
    }
