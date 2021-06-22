using System;
using coWorking.Data;

namespace coWorking.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var userData = new UserData();
            userData.CreatedAdmin();
            
            Console.WriteLine("Hello World!");
        }
    }
}
