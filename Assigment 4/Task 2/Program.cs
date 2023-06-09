Console.Write("Please enter length for string array: ");
string Ainput = Console.ReadLine();
int ALength;

if(int.TryParse(Ainput,out ALength))
{
    string[] mystring = new string[ALength];
    for (int i = 0;i < ALength; i++)
    {
        Console.Write("Please enter value for string array element " +  i + ":");
        mystring[i] = Console.ReadLine();
    }
    Console.Write("Please enter length for int array: ");
    string Binput = Console.ReadLine();
    int BLength;
    if(int.TryParse(Binput,out BLength))
    {
        int[] myint = new int[BLength];
        for (int i = 0; i < BLength; i++)
        {
            Console.Write("Please enter value for int array element " + i + ":");
            myint[i] = int.Parse(Console.ReadLine());
        }

        int maxsize = Math.Max(ALength, BLength);

        for (int i = 0; i < maxsize; i++)
        {
            if (i < ALength) { Console.Write(mystring[i]); }
            if (i < BLength) { Console.Write(myint[i]); }
        }
    }
    else
    {
        Console.WriteLine("Please enter valid number");
    }
}
else
{
    Console.WriteLine("Please enter valid number");
}