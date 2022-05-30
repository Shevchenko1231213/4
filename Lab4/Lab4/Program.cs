using Lab4.Data;
using Lab4.Factory;
using System;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Language ukrainian = new Language(new UkrainianLanguageFactory());
            Language english = new Language(new EnglishLanguageFactory());

            char key;
            char answer;
            do
            {
                Console.WriteLine("==========================");
                Console.WriteLine("          Menu           ");
                Console.WriteLine("==========================");
                Console.WriteLine("1. Ukrainian Language Encrypt, Decrypt:");
                Console.WriteLine("2. English Language Encrypt, Decrypt:");
                Console.WriteLine();
                Console.WriteLine("Choose number ->");
                key = (char)Console.Read();
                Console.ReadLine();
                Console.WriteLine("Enter text that you want to encrypt:");
                string? text = Console.ReadLine();
                Console.WriteLine("Enter the number of characters by which the encryption should be shifted:");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("==========================");
                switch (key)
                {
                    case '1':
                        Console.Write("Encrypted text:"); string textUkrainianEncrypt = ukrainian.Encrypt(text, value); Console.WriteLine(textUkrainianEncrypt);
                        Console.Write("Decrypted text:"); Console.WriteLine(ukrainian.Decrypt(textUkrainianEncrypt, value));
                        Console.Write("Final Decrypt:"); Console.WriteLine(text);
                        break;
                    case '2':
                        Console.Write("Encrypted text:"); var textEnglishEncrypt = english.Encrypt(text, value);  Console.WriteLine(textEnglishEncrypt);
                        Console.Write("Decrypted text:"); Console.WriteLine(english.Decrypt(textEnglishEncrypt, value));
                        Console.Write("Final Decrypt:"); Console.WriteLine(text);
                        break;
                    default: Console.WriteLine("Error! Wrong command."); break;
                }
                Console.WriteLine("==========================");
                Console.WriteLine("Continue y/n");
                answer = (char)Console.Read();
                Console.ReadLine();
            } while (answer != 'n');
        }
    }
}
