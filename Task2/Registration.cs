using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Registration
{
    private static readonly Dictionary<string, string> _users = new Dictionary<string, string> { { "test", "test" }};
    public static bool _isLogin;  

    public void Menu()
    {
        ChooseAction(); 
    }

    private static void ChooseAction()
    {
        Console.WriteLine("Your WalletApp doesn't welcome you!Please choose the action:\n(R) Registration, (L) Login, (LG) Logout.");
        var userOperation = Console.ReadLine();

        switch (userOperation?.ToLower())
        {
            case "r": UserRegistration(); break;
            case "l": Login(); break;
            case "lg": Logout(); break;
            default: throw new ArgumentException($"Invalid operation {userOperation}.");
        }
    }
    
    private static void Login()
    {
        if (!_isLogin)
        {
            Console.WriteLine("Please, enter your login:");
            var login = Console.ReadLine();
            if (!ValidateLogin(ref login))
                return;

            Console.WriteLine("Please, enter the password.");
            var password = Console.ReadLine();
            if (!ValidatePassword(login, password))
                return;            

            Console.WriteLine($"You have been successfully logged in the system as user with login {login}.");
            _isLogin = true;
        }
        else
            Console.WriteLine("You are logged in the system.");
    }

    private static bool ValidateLogin(ref string login)
    {
        while (!IsLoginExist(login))
        {
            Console.WriteLine("Do you want try again? Y/N");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.WriteLine("Please, enter your login again:");
                login = Console.ReadLine();
            }
            else
                return false;
        }

        return true;
    }

    private static bool IsLoginExist(string login)
    {
        var result = _users.Keys.Any(key => key.Equals(login));

        if (!result)
            Console.WriteLine($"User with login {login} does not exist in the system.");

        return result;
    }

    private static bool ValidatePassword(string login, string password)
    {
        while (!IsPasswordCorrect(login, password))
        {
            Console.WriteLine("Do you want try again? Y/N");
            if (Console.ReadLine().ToLower() == "y")
            {
                Console.WriteLine("Please, enter your password again:");
                password = Console.ReadLine();
            }
            else
                return false;
        }

        return true;
    }

    private static bool IsPasswordCorrect(string login, string password)
    {
        var result = _users[login].Equals(password);

        if (!result)
            Console.WriteLine("Password is incorrect.");

        return result;
    }

    private static void UserRegistration()
    {
        if (!_isLogin)
        {
            while (true)
            {
                Console.WriteLine("Please, enter the login:");
                var login = Console.ReadLine();
                Console.WriteLine("Please, enter the password:");
                var password = Console.ReadLine();

                if (ValidateLoginAtRegistration(login))
                {
                    Console.WriteLine("Incorrect login");
                    continue;
                }
                else
                {
                    ValidateRegistration(login, password);
                    break;
                }
            }
        }
        else
            Console.WriteLine("You are already logged in the system.");
    }

    public static bool ValidateLoginAtRegistration(string login)
    {
        string pattern = @"[\Wа-я]";
        Regex regex = new Regex(pattern);
        return Regex.IsMatch(login, pattern, RegexOptions.IgnoreCase);
    }

    public static void ValidateRegistration(string login, string password)
    {
        if (!_users.TryAdd(login, password))
            Console.WriteLine($"User with login {login} already exists.");
        else
        {
            Console.WriteLine($"You have been successfully registered in the system as user with login {login}.");
            Login();
        }
    }

    private static void Logout()
    {
        if (_isLogin)
        {
            Console.WriteLine("You are successfully logout from the system.");
            _isLogin = false;            
        }
        else
            Console.WriteLine("You are not logged in the system.");
    } 
}