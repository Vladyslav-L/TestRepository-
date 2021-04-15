using System;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Registration registration = new Registration();

            while (true)
            {
                registration.Menu();

                if (Registration._isLogin == true)
                {
                    Menu();
                }
            }
        }

        private static void Menu()
        {
            Wallet wallet = new Wallet();
            bool isExit = true;

            while (isExit)
            {
                Console.WriteLine("Choose action: ShowСurrencyRate = 1, ShowWallet = 2, AddNewBill = 3, PutCash = 4, ConvertTo = 5,  CashOut = 6, Mein menu = 7. ");
                var inputAction = Console.ReadLine();

                switch (inputAction)
                {
                    case "1":
                        wallet.ShowСurrencyRate();
                        break;
                    case "2":
                        wallet.ShowWallet();
                        break;
                    case "3":
                        wallet.AddNewBill();
                        break;
                    case "4":
                        wallet.PutCash();
                        break;
                    case "5":
                        wallet.ConvertTo();
                        break;
                    case "6":
                        wallet.CashOut();
                        break;
                    case "7":
                        isExit = false;
                        break;
                    default: Console.WriteLine("You write incorrect action");
                        break;
                }
            }
        }
    }
}
