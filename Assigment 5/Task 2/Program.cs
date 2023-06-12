char[] mychar = GetCharArrayFromUser();

Console.WriteLine("Please Enter Symbol to find");
char symbol = Console.ReadKey().KeyChar;
Console.WriteLine(); ;
PrintResult(symbol, FindSymbol(mychar, symbol));


char[] GetCharArrayFromUser()
{
    int arraysize;
    do
    {
        Console.WriteLine("Enter Size for your Char Array");
    }   while(!int.TryParse(Console.ReadLine(), out arraysize));

    char[] array = new char[arraysize];
    for(int i = 0; i < arraysize; i++)
    {
        Console.Write($"Enter Value for char array element {i}: ");
        array[i] = Console.ReadKey().KeyChar;
        Console.WriteLine();
    }
    return array;
}

int FindSymbol(char[] mychar, char symbol)
{
    int Count = 0;
    for(int i = 0;i < mychar.Length;i++)
    {
        if (mychar[i] == symbol)
        {
            Count++;
        }
    }
    return Count;
}

void PrintResult(char symbol, int count)
{
    Console.WriteLine($"{symbol} was found in array {count} times");
}