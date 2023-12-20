namespace Bank
{
    enum MenuOption
    {
        Withdraw, Deposit, Print, Quit
    }
    public class Program
    {
        static MenuOption ReadUserOption()
        {
            MenuOption selection;
            int s;
            do
            {
                Console.WriteLine("Enter 0 to Withdraw :");
                Console.WriteLine("Enter 1 to Deposit :");
                Console.WriteLine("Enter 2 to Print :");
                Console.WriteLine("Enter 3 to Quit :");
                Console.Write("Enter Your Selection between 0 and 3 : ");
                s = Convert.ToInt32(Console.ReadLine());
                selection = (MenuOption)s;
                if (selection < MenuOption.Withdraw || selection > MenuOption.Quit)
                {
                    Console.WriteLine("Envalid choice");
                }
            } while (selection < MenuOption.Withdraw || selection > MenuOption.Quit);
            return selection;
        }
        static void Main(string[] args)
        {
            //Account account = new Account("Jakes Account", 200000);
            //account.Print();
            //account.Deposit(100);
            //account.Print();

            //account.withdraw(100000);
            //account.Print();

            //Console.WriteLine();
            //Account a2 = new Account("NourEldin", 1000);
            //a2.Print();
            //a2.Deposit(2000);
            //a2.Print();
            //a2.withdraw(10000);
            //a2.Print();

            Account userAccount = new Account("nour", 1000);

            while (true)
            {
                MenuOption Choice = ReadUserOption();


                switch (Choice)
                {
                    case MenuOption.Deposit:
                        DoDeposit(userAccount);
                        break;
                    case MenuOption.Withdraw:
                        DoWithdraw(userAccount);
                        break;
                    case MenuOption.Print:
                        DoPrint(userAccount);
                        break;
                    case MenuOption.Quit:
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option selected. Please try again.");
                        break;


                }




                static void DoDeposit(Account account)
                {
                    Console.Write("Enter deposit amount: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());

                    if (account.Deposit(amount))
                    {

                        Console.WriteLine($"Deposit of {amount} successful.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid deposit amount. Please enter a valid number.");
                    }
                }

                static void DoWithdraw(Account account)
                {
                    Console.Write("Enter withdrawal amount: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    if (account.withdraw(amount))
                    {
                        Console.WriteLine($"withdraw of {amount} successful.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid withdrawal amount. Please enter a valid number.");
                    }
                }

                static void DoPrint(Account account)
                {
                    account.Print();
                }
            }
        }
    }
}
