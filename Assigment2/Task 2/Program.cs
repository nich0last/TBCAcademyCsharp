while (true)
{
    Random rnd = new Random();
    string[] Signs = { "rock", "paper", "scissors" };
    int signindex = rnd.Next(0, Signs.Length);
    string consolSign = Signs[signindex];

    Console.WriteLine("Enter your choice (rock, paper or scissors)");
    string UserSign = Console.ReadLine().ToLower();

    Console.WriteLine(consolSign);

    if (UserSign == consolSign)
    {
        Console.WriteLine("It's tie");
    }
    else if (
        (UserSign == "rock" && consolSign == "scissors") ||
        (UserSign == "paper" && consolSign == "rock") ||
        (UserSign == "scissors" && consolSign == "paper")
        )
    {
        Console.WriteLine("You Win");
    }
    else { Console.WriteLine("You Lose"); }
}