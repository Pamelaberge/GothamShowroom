using System;

namespace MandatoryAssignment2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Gotham's BrandX Showroom");
            Console.WriteLine("Please provide your username to access the BrandX system:");

            CarStock myCarStock = new CarStock(); 

            Console.WriteLine(myCarStock.GetUsername(Console.ReadLine()));
            
            if (myCarStock.correctUsername)
            {
                Console.WriteLine("Please enter your password:");
                Console.WriteLine(myCarStock.GetPassword(Console.ReadLine()));

                if (myCarStock.correctPassword)
                {
                    while (true)
                    {
                        Console.WriteLine("****** Here are your options ******");
                        Console.WriteLine("*Please select the action");
                        Console.WriteLine("1. Show stock count");
                        Console.WriteLine("2. Show total value of all cars in stock");
                        Console.WriteLine("3. Register one car sold");
                        Console.WriteLine("4. Show stock status (very low, low, normal, over)");
                        Console.Write("Choose option: ");

                        
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:

                                Console.WriteLine($"Stock count: {myCarStock.carStock}");
                                break;

                            case 2:

                            int result = myCarStock.TotalValue(myCarStock.carStock * myCarStock.price);
                                Console.WriteLine($"Total value of all cars in stock: ${result}");
                                break;

                            case 3:

                                int resultA = myCarStock.OneCarSold(myCarStock.carStock--);
                                Console.WriteLine($"New car stock count: {resultA}");
                                break;

                            case 4:

                                string resultB = myCarStock.StockStatus(myCarStock.carStock);
                                Console.WriteLine($"Stock status: {resultB}");
                                break;

                            default:

                                Console.WriteLine("Please choose an option 1-4.");
                                break;
                        }
                        Console.Write("Is your session over (y/n)? ");
                        string answer = Console.ReadLine();
                        if (answer.Equals("y"))
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
