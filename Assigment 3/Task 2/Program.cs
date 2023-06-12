Console.Write("Enter a number: ");
string input = Console.ReadLine();
int num;
int divider = 1;
if (int.TryParse(input, out num))
{
    for (int i = 2; i <= num; i++)
    {
        if (num % i == 0) divider += 1;
    }
    Console.WriteLine("The number of dividers for " + num + " is " + divider);
}
else
{
    Console.WriteLine("Enter valid number");
}