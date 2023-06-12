Console.Write("Enter a number: ");
string input = Console.ReadLine();
int num;
int count = 0;
int sum = 0;
double average = 0;
if(int.TryParse(input, out num))
{
    if (num < 0) Console.WriteLine("Please enter positive number");
    else
    {
        for (int i = 0; i <= num; i++)
        {
            sum += i;
            count++;
        }
        average = (double)sum / (num + 1);
        Console.WriteLine("Sum for your number: " + sum);
        Console.WriteLine("Average for your number: " + average);
    }
}
else
{
    Console.WriteLine("Enter valid number");
}