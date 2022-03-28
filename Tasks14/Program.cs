using System;

namespace Tasks14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Adini daxil edin");
            string username = Console.ReadLine();
            Console.WriteLine("User Passwordunu daxil edin");
            string password = Console.ReadLine();
            User user1 = new User(username)
            {
                Name = username,
                Password = password
            };
            user1.GetInfo();
            string testStr = "Salam salam S4l4m";
            Console.WriteLine(user1.HasLower(testStr));
            Console.WriteLine(user1.HasUpper(testStr));
            Console.WriteLine(user1.HasDigit(testStr));
        }
    }
}
