using System;

namespace itogovaya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var validator = new PasswordValidator();

            Console.WriteLine("Введите пароль для проверки:");
            string password = Console.ReadLine();

            if (validator.ValidatePassword(password))
            {
                Console.WriteLine("Пароль надежный.");
            }
            else
            {
                Console.WriteLine("Пароль не соответствует требованиям.");
            }
        }
    }
}