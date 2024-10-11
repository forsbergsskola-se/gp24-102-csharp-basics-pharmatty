        // Input
        {Console.Write("Enter circle radius ");
        
        // Parse to float
        if (float.TryParse(Console.ReadLine(), out float radius))
        {
            // Area
            float area = CalculateArea(radius);
            
            // Result
            Console.WriteLine($"The area of the circle is: {area:F2}");
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

    static float CalculateArea(float radius)
    {
        // Formula to use: Area = pi * r^2
        return (float)(Math.PI * Math.Pow(radius, 2));
    }
