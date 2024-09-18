// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

namespace PrintInReverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter empty/nothing to quit.\n");
            Console.Write("Write something : ");

            string text = Console.ReadLine();

            while(text != string.Empty)
            {
                Console.Write("Text reversed : ");

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{text[i]}");
                }

                Console.Write("\nWrite something : ");
                text = Console.ReadLine();
            }
            
        }
    }
}