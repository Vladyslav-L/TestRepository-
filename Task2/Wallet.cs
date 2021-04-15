using System;
using System.Collections.Generic;

namespace Task2
{
    //change from Den

    public class Wallet
    {
        public List<Bill> Bills = new List<Bill>();
        public readonly List<Currency> Currencys = new List<Currency>() { { new Currency("UAH", 1) }, { new Currency("USD", 27.939) }, { new Currency("EUR", 32.8632) }, { new Currency("RUB", 0.3656) }, { new Currency("JPY", 0.2529) } };

        public Wallet()
        {

        }

        public void AddNewBill()
        {
            Console.Write("Add new currency in Wallet.\nChoose currency: USD, EUR, UAH, RUB, CNY: ");
            var inputChoose = Console.ReadLine();

            Currency findCurrency = Currencys.Find(currency => currency.Name.ToLower() == inputChoose.ToLower());

            if (findCurrency == null)
            {
                Console.WriteLine($"Currency:{inputChoose}, is does exist.");
                return;
            }
            else
            {
                Bill findHaveBill = Bills.Find(bill => bill.Name.ToLower() == inputChoose.ToLower());

                if (findHaveBill == null)
                    Bills.Add(new Bill(inputChoose.ToLower(), 0));
                else
                    Console.WriteLine($"You have currency: {inputChoose}");
            }
        }

        public void ConvertTo()
        {
            Console.WriteLine("Currency Converter \n Available currencies: UAH, USD, EUR, RUB, JPY.");

            Console.Write("Write give currency: ");
            string inputHaveCurrency = Console.ReadLine();

            Currency findHaveCurrency = Currencys.Find(currency => currency.Name.ToLower() == inputHaveCurrency.ToLower());

            if (findHaveCurrency == null)
            {
                Console.WriteLine($"Currency:{inputHaveCurrency}, is does exist.");
                return;
            }

            Bill findHaveBill = Bills.Find(bill => bill.Name.ToLower() == inputHaveCurrency.ToLower());

            if (findHaveBill == null)
            {
                Console.WriteLine($"You don`t have wallet with currency {inputHaveCurrency}. Please add this currency in your wallet.");
                return;
            }

            Console.Write("Write want currency: ");
            string inputWantCurrency = Console.ReadLine();

            Currency findWantCurrency = Currencys.Find(currency => currency.Name.ToLower() == inputWantCurrency.ToLower());

            if (findWantCurrency == null)
            {
                Console.WriteLine($"Currency: {inputWantCurrency}, is does exist.");
                return;
            }

            Bill findHaveBill2 = Bills.Find(bill => bill.Name.ToLower() == inputWantCurrency.ToLower());

            if (findHaveBill2 == null)
            {
                Console.WriteLine($"You don`t have wallet with currency {inputWantCurrency}. Please add this currency in your wallet.");
                return;
            }

            Console.Write("Write your sum: ");
            string inputValue = Console.ReadLine();

            if (double.TryParse(inputValue, out double sum))
            {
                if (sum > 0)
                {
                    if (sum <= findHaveBill.Sum)
                    {
                        findHaveBill2.Sum = (sum * findHaveCurrency.Value) / findWantCurrency.Value;
                        findHaveBill.Sum -= sum;
                        Console.WriteLine($"You successfully convert {inputHaveCurrency},to {inputWantCurrency}");
                        ShowWallet();
                    }
                    else
                        Console.WriteLine("You don`t have this sum;");
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                    return;
                }
            }
            else
                Console.WriteLine("Write numbers");
        }

        public void ShowWallet()
        {
            Console.WriteLine("Your wallet: ");

            foreach (var bill in Bills)
            {
                Console.WriteLine(bill);
            }

            if (Bills.Count == 0)
            {
                Console.WriteLine("Wallet is empty");
            }
        }

        public void ShowСurrencyRate()
        {
            Console.WriteLine("Currency rate: ");

            foreach (var currency in Currencys)
            {
                Console.WriteLine(currency);
            }
        }

        public void CashOut()
        {
            Console.Write("Put cash on the wallet.\nWrite given currency: ");
            string inputHaveCurrency = Console.ReadLine();

            Currency findHaveCurrency = Currencys.Find(currency => currency.Name.ToLower() == inputHaveCurrency.ToLower());

            if (findHaveCurrency == null)
            {
                Console.WriteLine($"Currency:{inputHaveCurrency}, is does exist.");
                return;
            }

            Console.Write("Write sum: ");
            var inputSum = Console.ReadLine();

            if (double.TryParse(inputSum, out double sum))
            {
                if (sum > 0)
                {
                    Bill findHaveBill = Bills.Find(bill => bill.Name.ToLower() == inputHaveCurrency.ToLower());

                    if (findHaveBill == null)
                    {
                        Console.WriteLine($"You don`t have wallet with currency {inputHaveCurrency}. Please add this currency in your wallet.");
                    }
                    else
                    {
                        if (sum <= findHaveBill.Sum)
                        {
                            findHaveBill.Sum -= sum;
                            Console.WriteLine("You successfully out cash");
                        }
                        else
                            Console.WriteLine("You don`t have this sum;");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                    return;
                }
            }
            else
                Console.WriteLine("Write numbers");
        }

        public void PutCash()
        {
            Console.Write("Put cash on the wallet.\nWrite given currency: ");
            string inputHaveCurrency = Console.ReadLine();

            Currency findHaveCurrency = Currencys.Find(currency => currency.Name.ToLower() == inputHaveCurrency.ToLower());

            if (findHaveCurrency == null)
            {
                Console.WriteLine($"Currency:{inputHaveCurrency}, is does exist.");
                return;
            }

            Console.Write("Write sum: ");
            var inputSum = Console.ReadLine();

            if (double.TryParse(inputSum, out double value))
            {
                if (value > 0)
                {
                    Bill findHaveBill = Bills.Find(bill => bill.Name.ToLower() == inputHaveCurrency.ToLower());
                    if (findHaveBill == null)
                    {
                        Console.WriteLine($"You don`t have wallet with currency {inputHaveCurrency}. Please add this currency in your wallet.");
                    }
                    else
                    {
                        findHaveBill.Sum = value;
                        Console.WriteLine("You successfully put cash");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                    return;
                }
            }
            else
                Console.WriteLine("Write numbers");
        }
    }
}
