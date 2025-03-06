using System.ComponentModel.Design;

namespace Bankingloginpage
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("\n:: Login Page ::");

            Console.WriteLine("Enter Usernmae :");
           string username = Console.ReadLine();
            Console.WriteLine("Enter Password :");
           string password = Console.ReadLine();

            if (username != "" && password!="")
            {
                


                if (username == "system" && password == "manager") 
                { 
                 Console.WriteLine("\n Logedin....");
                    Menu();


                }
                 else
                 {
                    Console.WriteLine("Invalid Username or Password");

                }


            }
            else
            {
                Console.WriteLine("Username is required");

            }

            void Menu()
            {
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Check Balance");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice :");
                int switch_on = Convert.ToInt32(Console.ReadLine());
                switch (switch_on)
                {
                   case 1:
                        Console.WriteLine("Create Account");

                        
                        break;
                    case 2:
                        Console.WriteLine("Deposit");
                        break;
                    case 3:
                        Console.WriteLine("Withdraw");
                        break;
                    case 4:
                        Console.WriteLine("Transfer");
                        break;
                    case 5:
                        Console.WriteLine("Check Balance");
                        break;
                    case 6:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }

            Console.ReadKey();

        }
    }
}
