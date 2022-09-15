using System;
namespace ignitionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration and initialization
            int number = 10;
            string firstName = "avez";
            char character = 'A';
            bool isWorking = true;

            Console.WriteLine(character);
            Console.WriteLine(number);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            //operators

            int a = 10;
            int b = 20;
            int c = 30;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a != b);
            Console.WriteLine(a == b);
            Console.WriteLine(a > b);
            Console.WriteLine(a > b || b > c);

            //type conversion/casting one data type to another
            byte d = 1;
            int i = d;
            Console.WriteLine(i);

            int f = 1;
            byte e = (byte)f;
            Console.WriteLine(e);

            var number1 = "1234";
            int i1 = Convert.ToInt32(number);
            Console.WriteLine(i);




            // finding largest among 2 numbers 
            int num1 = 20;
            int num2 = 30;

            if (num1 < num2)
            {
                Console.WriteLine("num2 is greater tha num1");
            }

            //finding square root of a number here we have a predefined method Math.sqrt to find square root of no
            Console.WriteLine(Math.Sqrt(36));

            //reversing letters taking inputs from users.. user will inter 3 characters and the output will reverse the characters
            char letter, letter1, letter2;

            Console.Write("Input letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input letter: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", letter2, letter1, letter);
        }
    }
}


        
    

