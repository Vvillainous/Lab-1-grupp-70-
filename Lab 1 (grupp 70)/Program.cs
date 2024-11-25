namespace Lab_1__grupp_70_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Variables 
            int menuSelection = -1;
            int hoursStockholm = 14;
            int minutesStockholm = 3;
            int hoursNewyork = 10;
            int minutesNewyork = 10;
            int timeDifference = 6;
            int travelHours = 7;
            int travelMinutes = 25;

            // The while loop is there to present the user with the menu again incase of a invalid input
            while (menuSelection != 3)
            {


                Console.Clear();
                Console.WriteLine("*******************************************************************************");
                Console.WriteLine("Hello!,Welcome to the flight schedule calculator!\n" +
                                    "Which flight would you like to know more about?\n" +
                                    "1. Stockholm - New York\n" +
                                    "2. New York - Stockholm\n" +
                                    "3. Exit program");

                Console.Write("\nWrite your answer here: ");

                Int32.TryParse(Console.ReadLine(), out menuSelection);


                if (menuSelection == 1)
                {
                    // Stockholm - New york (Departure)
                    int destinationHours = hoursStockholm + travelHours - timeDifference;
                    int destinationMinutes = minutesStockholm + travelMinutes;
                    Console.WriteLine("******************************************************************************* \n");
                    Console.WriteLine($"Departure from Stockholm: {hoursStockholm}:{minutesStockholm.ToString("00")}");

                    //Stockholm - New york(Arrivals)
                    Console.WriteLine($"Arrival to New york: {destinationHours}:{destinationMinutes}");
                    Console.WriteLine("\n\n*******************************************************************************");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (menuSelection == 2)
                {
                    // New york - Stockholm (Departure)
                    int destinationHours = hoursNewyork + travelHours + timeDifference;
                    int destinationMinutes = minutesNewyork + travelMinutes;
                    Console.WriteLine("******************************************************************************* \n");
                    Console.WriteLine($"Departure from New york: {hoursNewyork}:{minutesNewyork.ToString("00")}");

                    // New york - Stockholm  (Arrivals)
                    Console.WriteLine($"Arrival to Stockholm: {destinationHours}:{destinationMinutes}");
                    Console.WriteLine("\n\n*******************************************************************************");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                // Break is put here to skip ahead to the "The program will exit now!" part incase of "3" input
                else if (menuSelection == 3)
                    break;
                else
                {
                    Console.WriteLine("Invalid option, please choose a valid option from the menu (1-3).\nPlease press any key to continue...");
                    Console.ReadKey();
                }
            }
            Console.WriteLine("The program will exit now!"); 
        }
    }
  
}
