using Packt.Shared;
using System.Xml;
using System.Xml.Serialization;
using static System.IO.Path;
using static System.Environment;
using static System.Console;

namespace Packt.Shared
{
    public class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a message that you want to encrypt: ");
            string message = ReadLine();
            Write("Enter a password: ");
            string password = ReadLine();
            string cryptoText = Protector.Encrypt(message, password);
            WriteLine($"Encrypted text: {cryptoText}");
            Write("Enter the password: ");
            string password2 = ReadLine();

            try
            {
                string clearText = Protector.Decrypt(cryptoText, password2);
                WriteLine($"Decrypted text: {clearText}");
            }
            catch (Exception ex)
            {
                WriteLine("{0}\nMore details: {1}",
                  arg0: "You entered the wrong password!",
                  arg1: ex.Message);
            }
        }
    }
}