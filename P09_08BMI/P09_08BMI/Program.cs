
    {   // input formula: BMI = weight (kg) / (height (m) * height (m))
        Console.Write("Enter weight in KG and height in meters ex 42, 2): ");
        
       
        string input = Console.ReadLine();
        string[] inputs = input.Split(',');

        if (inputs.Length == 2 && 
            float.TryParse(inputs[0].Trim(), out float weight) && 
            float.TryParse(inputs[1].Trim(), out float height))
        {
            // BMI
            float bmi = CalculateBMI(weight, height);
            
            // Result
            Console.WriteLine($"Your BMI is: {bmi:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static float CalculateBMI(float weight, float height)
    {
        
        return weight / (height * height);
    }
