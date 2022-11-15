using System;
using static System.Console;
using Packt.Shared;

namespace Packt.Shared
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Registering Alice and Pa$$w0rd");
            var alice = Protector.Register("Alice", "Pa$$w0rd");
            WriteLine($"Name: {alice.Name}");
            WriteLine($"Salt: {alice.Salt}");
            WriteLine("Password (salted and hashed): {0}",
                arg0: alice.SaltedHashedPassword);
            WriteLine();
            WriteLine("Enter a new user to register");
            string username = ReadLine();
            WriteLine($"Enter a password for {username}");
            string password = ReadLine();
            var user = Protector.Register(username, password);
            WriteLine($"Name: {user.Name}");
            WriteLine($"Salt: {user.Salt}");
            WriteLine("Password (salted and hashed): {0}",
                arg0: user.SaltedHashedPassword);
            WriteLine();
            bool correctPassword = false;
            while (!correctPassword)
            {
                Write("Enter a username to log in: ");
                string loginUsername = ReadLine();
                Write("Enter a password to log in: ");
                string loginPassword = ReadLine();
                correctPassword = Protector.CheckPassword(
                    loginUsername, loginPassword);
                if (correctPassword)
                {
                    WriteLine($"Correct! {loginUsername} has been logged in.");
                }
                else
                {
                    WriteLine("Invalid username or password. Try again.");
                }
            }
        }
    }
}
