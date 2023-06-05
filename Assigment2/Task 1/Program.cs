Console.WriteLine("Enter your temperature");
string Temp = Console.ReadLine();
int TempInt = int.Parse(Temp);
if (Temp == "" || Temp == " ")
{
    Console.WriteLine("Temperature is mandatory");
    return;
}
else if (TempInt < 0)
{
    Console.WriteLine("It's Freezing");
}
else if (TempInt >= 0 && TempInt <= 30)
{
    Console.WriteLine("It's Good Weather");
}
else
{
    Console.WriteLine("It's Hot");
}