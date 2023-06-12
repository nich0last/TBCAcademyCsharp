int arraysize;
do
{
    Console.WriteLine("Enter length for your array:");
} while(!int.TryParse(Console.ReadLine(), out arraysize));

int[] Array = new int[arraysize];

for (int i = 0; i < arraysize; i++)
{
    do
    {
        Console.WriteLine($"Enter Value for array element {i}: ");
    } while (!int.TryParse(Console.ReadLine(), out Array[i]));
}

int index;
do
{
    Console.WriteLine("Enter Index to find Value");
} while (!int.TryParse(Console.ReadLine(), out index) || index>=arraysize);

int sum = getSumByIndex(Array, index);
Console.WriteLine($"Sum of digits for your number is: {sum}");

int getSumByIndex(int[] array, int index)
{
    return CalculateSumOfDigits(array[index]);
}
int CalculateSumOfDigits(int number)
{
    number = Math.Abs(number);//In Case of Negative Number
    int sum = 0;
    while (number != 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }
    return sum;
}