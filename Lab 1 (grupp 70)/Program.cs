namespace Lab_1__grupp_70_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuSelection = -1;
            int hoursStockholm = 14;
            int minutesStockholm = 3;
            int hoursNewyork = 10;
            int minutesNewyork = 10;
            int timeDifference = 6;
            int travelHours = 7;
            int travelMinutes = 25;
            while (menuSelection != 3)
            {
                //The clearing method is used to clear the console before the loop starts again.

                Console.Clear();
                Console.WriteLine("Hello! , Welcome to the flight schedule calculator!\n" + 
                                  "Which flight would you like to know more about?\n" +
                                  "1. Stockholm - New York\n" +
                                  "2. New York - Stockholm\n" +
                                  "3. Exit program");

                //We put a \n > to make it more clear that a input is required to advance

                Console.Write("\n> ");
                menuSelection = Int32.Parse(Console.ReadLine());




            }
            Console.WriteLine("The program will exit now!");
        }
    }
}
