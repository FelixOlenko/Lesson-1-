using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
            string username = Console.ReadLine();

            if (username.ToLower() == "феликс")
            {
                Console.WriteLine("Да здравствует его Императорское Величество Феликс Первый!");
            }
            else
            {
                Console.Write("Ну здарова...");
                Console.WriteLine(username);
            }



        }
    }
}
