using System;

namespace Cycles1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "Nan", userName = "Nan", userPassword = "Nan", passwordCheck;

            Console.WriteLine("Hello You Can Use New Commands: \n -SetName \n -ChangeConsoleColor \n -SetPassword \n -WriteName \n -Esc");

            while (command != "Esc")
            {
                command = Console.ReadLine();
                switch (command)
                {
                    case "SetName":
                        Console.Clear();
                        Console.WriteLine("Write Your Name: ");
                        userName = Console.ReadLine();
                        Console.WriteLine("Your Name: " + userName);
                        break;
                    case "ChangeConsoleColor":
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine("Your Console Have A New Color, Enjoy :)");
                        break;
                    case "SetPassword ":
                        Console.Clear();
                        Console.Write("Please set your new password: ");
                        userPassword = Console.ReadLine();
                        Console.WriteLine("Succes Your New Password " + userPassword);
                        break;
                    case "WriteName":
                        Console.Clear();
                        Console.Write("Please write your password:");
                        passwordCheck = Console.ReadLine();
                        if (userPassword == passwordCheck)
                        {
                            Console.WriteLine("Hello " + userName + " you are log in :)");
                        }
                        else
                        {
                            Console.WriteLine("Sorry not correct password");
                        }
                        break;
                    case "Esc":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error, not correct number try again");
                        break;

                }

            }
        }

    }
}

