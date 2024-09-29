using System;

class NimGame
{
    static void Main(string[] args)
    {
        //TRUE = Player FALSE = Ai
        int matches = 24;
        bool playerAction = true; 
        

        Console.WriteLine("Welcome to Nim!");
        while (matches > 0)
            
        {
            DisplayMatches(matches);

            if (playerAction)
            {
                Console.Write("How many matches do you want to draw?");
                int playerDraw = GetPlayerInput(matches);
                matches -= playerDraw;

                if (matches <= 0)
                {
                    Console.WriteLine("You drew the last match. You lose.");
                    break;
                }
            }
            else
            {
                int aiDraw = GetAIDraw(matches);
                Console.WriteLine($"Your opponent draws {aiDraw} matches.");
                matches -= aiDraw;

                if (matches <= 0)
                {
                    Console.WriteLine("Your opponent drew the last match. You Win!");
                    break;
                }
            }
            playerAction = !playerAction; // Player Turn
        }
    }

    static void DisplayMatches(int matches)
    {
        Console.WriteLine(new string('|', matches) + $" ({matches})");
    }

    static int GetPlayerInput(int matches) //Value input for how many matches the player can draw.
    {
        int playerDraw;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out playerDraw) && playerDraw >= 1 && playerDraw <= 5 && playerDraw <= matches)
            {
                return playerDraw;
            }
            Console.Write("Please enter a value between 1 to 5:");
        }
    }

    static int GetAIDraw(int matches)
    {
        // AI Behavior
        int aiAction = (matches - 1) % 5;
        if (aiAction == 0 || aiAction > 3)
        {
            aiAction = 1;
        }
        return aiAction;
    }
}