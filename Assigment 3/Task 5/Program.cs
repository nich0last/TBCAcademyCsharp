while (true)
{
    Console.Write("Enter min number: ");
    string inputmin = Console.ReadLine();

    Console.Write("Enter max number: ");
    string inputmax = Console.ReadLine();

    int Min, Max;

    if (int.TryParse(inputmin, out Min) && int.TryParse(inputmax, out Max))
    {
        if (Min <= Max)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(Min, Max + 1);

            int guess;
            int attampt = 0;

            do
            {
                Console.Write("Your guess: ");
                string inputGuess = Console.ReadLine();
                if (int.TryParse(inputGuess, out guess))
                {
                    attampt++;

                    if (randomNumber == guess)
                    {
                        Console.WriteLine("You Win");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try Again");
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid number");
                }
            } while (true);

            Console.WriteLine("Do you want to play again? (yes/no)");
            string inputQ = Console.ReadLine();

            if(inputQ == "no")
            {
                break;
            }
        }
        else
        {
            Console.WriteLine("Min number must be less than Max number");
        }
    }
    else
    {
        Console.WriteLine("Enter valid number");
    }
}