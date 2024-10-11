        
        Console.Write("Enter desired speed in km/h: ");
        
        // Read input and parse it to a double
        if (double.TryParse(Console.ReadLine(), out double kmh))
        {
            // Conversion value km/h to m/s
            double mps = ConvertKmhToMps(kmh);
            
            Console.WriteLine($"The speed in m/s is: {Math.Round(mps)}");
        }
        else
        {
            Console.WriteLine("Please enter a number.");
        }
    

    static double ConvertKmhToMps(double kmh)
    {
        return kmh / 3.6;
    }