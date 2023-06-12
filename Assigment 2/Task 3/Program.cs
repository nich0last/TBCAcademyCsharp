Console.WriteLine("Enter your Birth Year");
int birthYear = Convert.ToInt32(Console.ReadLine());
int zodiac = (birthYear - 1900) % 12;

Console.WriteLine("Your Chinese zodiac sign is:");
switch (zodiac)
{
    case 0: 
        Console.WriteLine("Rat");
        break;
    case 1: 
        Console.WriteLine("Ox");
        break;
    case 2:
        Console.WriteLine("Tiger");
        break;
    case 3:
        Console.WriteLine("Rabbit");
        break;
    case 4:
        Console.WriteLine("Dragon");
        break;
    case 5:
        Console.WriteLine("Snake");
        break;
    case 6:
        Console.WriteLine("Horse");
        break;
    case 7:
        Console.WriteLine("Goat");
        break;
    case 8:
        Console.WriteLine("Monkey");
        break;
    case 9:
        Console.WriteLine("Rooster");
        break;
    case 10:
        Console.WriteLine("Dog");
        break;
    case 11:
        Console.WriteLine("Pig");
        break;
}
