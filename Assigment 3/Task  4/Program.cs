Console.Write("Enter a number: ");
string input = Console.ReadLine();
int num;
if (int.TryParse(input, out num))
{
    if (num < 0) Console.WriteLine("Please enter positive number");
    else
    {
        for (int i = 1; i <= num; i++)
        {
            for (int j = 0; j < num - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
else
{
    Console.WriteLine("Enter valid number");
}