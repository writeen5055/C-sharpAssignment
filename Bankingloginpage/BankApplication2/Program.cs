namespace BankApplication2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Username");

            string username = Console.ReadLine();
            Console.WriteLine("Enter a Password");
            string password = Console.ReadLine();

            if (username != null && password != null)
            {
                if (username == "admin" && password == "admin")
                {
                    menu();
                
                
                }
                else
                {
                    Console.WriteLine("Invalid Username or Password");
                }



            }
            else
            {
                Console.WriteLine("Username & Password is required");
            }

            void menu()
            {
                Console.WriteLine(":: Bank Menu ::");
                Console.WriteLine("1. Customer");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Transactions");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice :");
                int choice= int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Customer");
                        break;
                    case 2:
                        Console.WriteLine("Accounts");
                        break;
                    case 3:
                        Console.WriteLine("Transactions");
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }

            }

        }
        
    }
}
