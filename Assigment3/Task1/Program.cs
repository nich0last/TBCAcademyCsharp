Console.Write("Enter a number: ");
string input = Console.ReadLine();
int num;
int divider = 1;
if (int.TryParse(input, out num))
{
    if (num == 1 || num == 0) Console.WriteLine(num + " is not prime nor composite number");
    else
    {
        for (int i = 2; i <= num; i++)
        {
            if (num % i == 0) divider += 1;
        }
        if (divider > 2) Console.WriteLine(num + " is composite number");
        else Console.WriteLine(num + " is prime number");
    }
}
else
{
    Console.WriteLine("Enter valid number");
}