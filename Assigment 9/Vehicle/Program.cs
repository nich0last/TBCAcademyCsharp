using Vehicle;

int choice;

do
{
    Console.WriteLine("Choose a vehicle type:");
    Console.WriteLine("1) Battle Vehicle");
    Console.WriteLine("2) Consumer Vehicle");
    Console.WriteLine("3) Public Transport");
    Console.WriteLine("4) Sports Car");

    string input = Console.ReadLine();

    if (int.TryParse(input, out choice))
    {
        if (choice >= 1 && choice <= 4)
            break;
    }

    Console.WriteLine("Invalid choice. Please try again.");
} while (true);

switch (choice)
{
    case 1:
        BattleVehicle battleVehicle = new BattleVehicle();
        battleVehicle.DisplayTypes();
        int battleType;

        do
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out battleType))
            {
                if (battleType >= 1 && battleType <= (int)BattleVehicle.BattleVehicleType.GetValues(typeof(BattleVehicle.BattleVehicleType)).Length)
                    break;
            }

            Console.WriteLine("Invalid type. Please try again.");
        } while (true);

        // Set properties for the chosen battle vehicle type
        // (e.g., battleVehicle.Mass = ...;)
        battleVehicle.DisplayInfo();
        break;

    case 2:
        ConsumerVehicle consumerVehicle = new ConsumerVehicle();
        consumerVehicle.DisplayTypes();
        int consumerType;

        do
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out consumerType))
            {
                if (consumerType >= 1 && consumerType <= (int)ConsumerVehicle.ConsumerVehicleType.GetValues(typeof(ConsumerVehicle.ConsumerVehicleType)).Length)
                    break;
            }

            Console.WriteLine("Invalid type. Please try again.");
        } while (true);

        // Set properties for the chosen consumer vehicle type
        // (e.g., consumerVehicle.Mass = ...;)
        consumerVehicle.DisplayInfo();
        break;

    case 3:
        PublicTransport publicTransport = new PublicTransport();
        publicTransport.DisplayTypes();
        int transportType;

        do
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out transportType))
            {
                if (transportType >= 1 && transportType <= (int)PublicTransport.PublicTransportType.GetValues(typeof(PublicTransport.PublicTransportType)).Length)
                    break;
            }

            Console.WriteLine("Invalid type. Please try again.");
        } while (true);

        // Set properties for the chosen public transport type
        // (e.g., publicTransport.Mass = ...;)
        publicTransport.DisplayInfo();
        break;

    case 4:
        SportsCar sportsCar = new SportsCar();
        sportsCar.DisplayTypes();
        int sportsCarType;

        do
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out sportsCarType))
            {
                if (sportsCarType >= 1 && sportsCarType <= (int)SportsCar.SportsCarType.GetValues(typeof(SportsCar.SportsCarType)).Length)
                    break;
            }

            Console.WriteLine("Invalid type. Please try again.");
        } while (true);

        // Set properties for the chosen sports car type
        // (e.g., sportsCar.Mass = ...;)
        sportsCar.DisplayInfo();
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}