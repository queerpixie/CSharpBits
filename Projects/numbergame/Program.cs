// Print the initial welcome message and game instructions to the player.
Console.WriteLine("I'm thinking of a number between 1 and 100.");
Console.WriteLine("Try to guess what it is!");
Console.WriteLine("Good luck!");

// Initialize a new random number generator.
Random random = new Random();
// Generate the secret number the player needs to guess (between 1 and 100).
int ans = random.Next(1, 101);
// Initialize a counter for the number of tries.
int tries = 0;
// A boolean flag to track if the player has won. The loop continues as long as this is false.
bool win = false;

// The main game loop. It continues until the player wins (win becomes true).
while (!win)
{
    // Increment the try counter for each guess.
    tries += 1;
    Console.WriteLine($"Enter a number (try: {tries}):");
    // Read the user's input from the console. Defaults to "1" if input stream is closed.
    string input = Console.ReadLine() ?? "1";
    int number = int.Parse(input);

    if (ans == number)
    {
        Console.WriteLine($"Correct, the number was {ans}!\nIt took you {tries} tries.");
        // Set win to true to exit the while loop.
        win = true;
    }
    else if (ans > number)
    {
        Console.WriteLine($"The answer is higher than {number}");
    }
    else if (ans < number)
    {
        Console.WriteLine($"The answer is lower than {number}");
    }

}
