Console.Write("Please enter Array length: ");
string arraylst = Console.ReadLine();
int arrayl;

if (int.TryParse(arraylst, out arrayl))
{
    int[] myarray = new int[arrayl];
    for (int i = 0; i < arrayl; i++)
    {
        Console.Write("Enter value for element " + i + ":");
        myarray[i] = int.Parse(Console.ReadLine());
    }
    int longestlinestart = 0;
    int longestlinelength = 1;
    int currentlinestart = 0;
    int currentlinelength = 0;

    for (int i = 1; i < myarray.Length; i++)
    {
        if (myarray[i] > myarray[i - 1])
        {
            currentlinelength++;
            if(currentlinelength > longestlinelength)
            {
                longestlinelength = currentlinelength;
                longestlinestart = currentlinestart;
            }
        }
        else
        {
            currentlinestart = i;
            currentlinelength = 1;
        }
    }
    Console.WriteLine("Longest asc line is: ");
    for (int i = longestlinestart; i < longestlinestart + longestlinelength; i++)
    {
        Console.WriteLine(myarray[i] + " ");
    }
}
else
{
    Console.WriteLine("Please enter valid number");
}