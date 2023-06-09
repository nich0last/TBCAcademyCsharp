Console.Write("Please enter Array length: ");
string arraylst = Console.ReadLine();
int arrayl;

if(int.TryParse(arraylst, out arrayl))
{
    int[] myarray = new int[arrayl];
    for(int i = 0; i < arrayl; i++)
    {
        Console.Write("Enter value for element " + i + ":");
        myarray[i] = int.Parse(Console.ReadLine());
    }

    for (int i = 0; i < arrayl - 1; i++)
    {
        for (int j = 0; j < arrayl - 1 - i; j++)
        {
            if (myarray[j] > myarray[j + 1])
            {
                int temp = (int)myarray[j];
                myarray[j] = myarray[j + 1];
                myarray[j + 1] = temp;
            }
        }
    }

    Console.WriteLine("Sorted Array:");
    foreach (int i in myarray)
    {
        Console.Write(i + ":");
    }
}
else
{
    Console.WriteLine("Please enter valid number");
}