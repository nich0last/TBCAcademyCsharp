Console.Write("Please enter length for first array: ");
string Ainput = Console.ReadLine();
int ALength;

if (int.TryParse(Ainput, out ALength))
{
    int[] myint1 = new int[ALength];
    for (int i = 0; i < ALength; i++)
    {
        Console.Write("Please enter value for first array element " + i + ":");
        myint1[i] = int.Parse(Console.ReadLine());
    }
    Console.Write("Please enter length for second array: ");
    string Binput = Console.ReadLine();
    int BLength;
    if (int.TryParse(Binput, out BLength))
    {
        int[] myint2 = new int[BLength];
        for (int i = 0; i < BLength; i++)
        {
            Console.Write("Please enter value for int array element " + i + ":");
            myint2[i] = int.Parse(Console.ReadLine());
        }
        int[] mergedArray = new int[myint1.Length + myint2.Length];
        Array.Copy(myint1, mergedArray, myint1.Length);
        Array.Copy(myint2, 0, mergedArray, myint1.Length, myint2.Length);

        bool isValidInput = false;
        string sortOption = "";

        while (!isValidInput)
        {
            Console.WriteLine("Enter 'asc' for ascending or 'desc' for descending:");
            sortOption = Console.ReadLine().ToLower();

            if (sortOption == "asc" || sortOption == "desc")
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter 'asc' or 'desc'.");
            }
        }
        if(sortOption == "asc")
        {
            Array.Sort(mergedArray);
        }
        else
        {
            Array.Sort(mergedArray);
            Array.Reverse(mergedArray);
        }
        foreach(int i in mergedArray)
        {
            Console.Write(i + " ");
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